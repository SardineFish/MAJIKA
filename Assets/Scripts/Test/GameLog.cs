using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLog : Singleton<GameLog>
{
    public Font Font;
    public static void Log(object msg)
    {
        if (!GameLog.Instance)
            return;
        var text = msg.ToString();
        var obj = new GameObject();
        obj.transform.SetParent(GameLog.Instance.transform);
        var ui = obj.AddComponent<Text>();
        ui.text = text;
        ui.font = GameLog.Instance.Font;
        ui.fontSize = 24;
        obj.transform.SetSiblingIndex(0);
    }
}
