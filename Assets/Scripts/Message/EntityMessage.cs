using UnityEngine;
using System.Collections;

public class EntityMessage : Message
{
    public GameEntity SenderEntity => Sender as GameEntity;

    public EntityMessage(GameEntity sender) : base(sender)
    {
    }
}
