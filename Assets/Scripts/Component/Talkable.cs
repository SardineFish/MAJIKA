using UnityEngine;
using System.Collections;

[RequireComponent(typeof(InteractiveEntity))]
public class Talkable : EventBehaviour
{
    public Talker Talker;
    public Conversation Conversation;
    void Awake()
    {
        Bind(GetComponent<EventBus>());   
    }

    [EventListener(InteractiveEntity.EventInteract)]
    public void OnInteract(GameEntity entity)
    {
        ConversationUI.Instance.LeftTalker = Talker;
        ConversationUI.Instance.RightTalker = (entity as Player)?.Talker;
        ConversationUI.Instance.Conversation = Conversation;
    }
}
