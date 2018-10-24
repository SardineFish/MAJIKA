using UnityEngine;
using System.Collections;

[RequireComponent(typeof(EntityEffector))]
public class GameEntity : MonoBehaviour,IMessageSender,IMessageReceiver,IEffectorTrigger
{
    public const string NameRenderer = "Renderer";
    public const string NameCollider = "Collider";
    public GameObject Renderer => transform.Find(NameRenderer).gameObject;
    public GameObject Collider => transform.Find(NameCollider).gameObject;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMessage(SkillImpactMessage msg)
    {
        var effector = GetComponent<EntityEffector>();
        msg.Effects.ForEach(effect => effector.AddEffect(effect, msg.SenderEntity));
    }
}
