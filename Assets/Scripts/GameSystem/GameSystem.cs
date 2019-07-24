using UnityEngine;
using System.Collections;

public class GameSystem : Singleton<GameSystem>
{
    public string TutorialScenePath;
    public GameEntity PlayerInControl;
    public TextManager TextManager;
    public MAJIKA.TextManager.ConversationManager ConversationManager;
    private void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);
        TextManager.Asset.Reload();
    }

    public void Control(GameEntity entity)
    {
        if(PlayerInControl != entity)
        {
            if(PlayerInControl)
            {
                PlayerInControl.GetComponent<EntityController>().ResetController();
                PlayerInControl.GetComponents<EntityInputPlugin>().ForEach(t => Destroy(t));
            }
            if(entity)
            {
                entity.gameObject.AddComponent<EntityInputPlugin>();
            }
            PlayerInControl = entity;
            if (GameGUIManager.Instance)
            {
                GameGUIManager.Instance.GetComponent<SkillUIManager>().DisplayEntity = entity;
                GameGUIManager.Instance.PlayerHP.DisplayEntity = entity as LifeEntity;
            }
        }
        
    }
}
