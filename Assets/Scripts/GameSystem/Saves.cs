using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using System.IO;
using System;
using System.Linq;

public class Saves : Singleton<Saves>
{
    public TextAsset InitialSaves;
    public PlayerProfile Profile;
    public string SavesFolder => Path.Combine(Application.persistentDataPath, "saves");
    public string SavesFile => Path.Combine(SavesFolder, "player.save");
    public string SavesBackup => Path.Combine(SavesFolder, "player.bak");
    public string SavesTemp => Path.Combine(SavesFolder, "player.save.tmp");

    private void Awake()
    {
        Load();
    }

    public bool Save()
    {
        var player = GameSystem.Instance.PlayerInControl?.GetComponent<Player>();
        if (player)
            player.SyncProfileToSaves();
        try
        {
            if (!Directory.Exists(SavesFolder))
                Directory.CreateDirectory(SavesFolder);
            var json = Serialize(Profile);
            using (var fs = new FileStream(SavesTemp, FileMode.Create))
            using (var sw = new StreamWriter(fs))
            {
                sw.Write(json);
            }
            if (File.Exists(SavesFile))
                File.Copy(SavesFile, SavesBackup, true);
            File.Copy(SavesTemp, SavesFile, true);
            return true;
        }
        catch (Exception ex)
        {
            Debug.LogError($"Failed to save: {ex.Message}");
        }
        return false;
    }

    public bool Load()
    {
        try
        {
            if(!File.Exists(SavesFile))
            {
                Profile = Deserialize(InitialSaves.text);
                Save();
                return true;
            }
            using (var sr = new StreamReader(File.Open(SavesFile, FileMode.Open)))
            {
                var json = sr.ReadToEnd();
                Profile = Deserialize(json);
            }
            return true;
        }
        catch(Exception  ex)
        {
            Debug.LogError($"Failed to load: {ex.Message}");
            Debug.LogWarning("Attempt to load backup.");
            if(File.Exists(SavesTemp))
            {
                try
                {
                    using (var sr = new StreamReader(File.Open(SavesBackup, FileMode.Open)))
                    {
                        var json = sr.ReadToEnd();
                        Profile = Deserialize(json);
                    }
                }
                catch (Exception exx)
                {
                    Debug.LogError($"Failed to load backup: {exx.Message}");
                    Profile = Deserialize(InitialSaves.text);
                }
            }
        }
        return false;
    }

    public string Serialize(PlayerProfile profile)
    {
        profile.inventory = profile.inventory
            .Select(item => new SerializableItem() { name = item.name, amount = item.amount })
            .ToArray();
        profile.skillSlots = profile.SkillSlots
            .Select(item => new SerializableItem() { name = item.Item.name, amount = item.Amount })
            .ToArray();
        return JsonUtility.ToJson(profile);
    }

    public PlayerProfile Deserialize(string json)
    {
        var profile = JsonUtility.FromJson<PlayerProfile>(json);
        profile.Inventory = profile.inventory
            .Select(item => DeserializeItem(item))
            .ToArray();
        profile.SkillSlots = profile.skillSlots
            .Select(item => DeserializeItem(item))
            .ToArray();
        return profile;
    }

    public Inventory.ItemWrapper DeserializeItem(SerializableItem item)
    {
        return AssetsManager.FindItem(item.name)?.Create(item.amount) ?? new Inventory.ItemWrapper();
    }
}
