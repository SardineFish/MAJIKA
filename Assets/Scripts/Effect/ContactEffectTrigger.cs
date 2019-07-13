using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ContactEffectTrigger : MonoBehaviour, IEffectorTrigger
{
    [HideInInspector]
    [MAJIKA.Utils.StatusEffect]
    public List<EffectInstance> Effects = new List<EffectInstance>();
    List<GameEntity> contactList = new List<GameEntity>();
    // Use this for initialization
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision) => Enter(collision.rigidbody.GetComponent<GameEntity>());
    private void OnCollisionStay2D(Collision2D collision) => Enter(collision.rigidbody.GetComponent<GameEntity>());
    private void OnTriggerEnter2D(Collider2D collision) => Enter(collision.GetComponentInParent<GameEntity>());
    private void OnTriggerStay2D(Collider2D collision) => Enter(collision.GetComponentInParent<GameEntity>());

    private void OnTriggerExit2D(Collider2D collision) => Exit(collision.GetComponentInParent<GameEntity>());

    private void OnCollisionExit2D(Collision2D collision) => Exit(collision.rigidbody.GetComponent<GameEntity>());

    private void Enter(GameEntity entity)
    {
        if (entity && !contactList.Contains(entity))
            contactList.Add(entity);
    }

    private void Exit(GameEntity entity)
    {
        if (entity && contactList.Contains(entity))
            contactList.Remove(entity);
    }

    // Update is called once per frame
    void Update()
    {
        Effects.ForEach(effect =>
            contactList.ForEach(entity =>
                entity.GetComponent<EntityEffector>()
                    .AddEffect(effect.Clone(), this)));
    }
}
