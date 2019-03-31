using UnityEngine;
using System.Collections;
using System.Linq;

namespace Inventory
{
    [RequireComponent(typeof(Animator), typeof(SpriteRenderer), typeof(SimpleMovement))]
    public class DropedItem : MonoBehaviour
    {
        public Item Item;
        public float TraceRadius = 5;
        public Vector2 PickupVelocity;
        public float Acceleration;


        private void Start()
        {
            GetComponent<SpriteRenderer>().sprite = Item.Iconx32;
            GetComponent<Animator>().runtimeAnimatorController = Item?.DropedAnimation;
            StartCoroutine(TraceTarget());
        }

        IEnumerator TraceTarget()
        {
            RaycastHit2D[] hits = new RaycastHit2D[10];
            int count = 0;
            Inventory inventory = null;
            do
            {
                count = Physics2D.CircleCastNonAlloc(transform.position, TraceRadius, Vector2.zero, hits, 0, 1 << 11);
                inventory = hits.Take(count)
                        .Select(hit => hit.rigidbody?.GetComponent<GameEntity>()?.GetEntityComponent<Inventory>())
                        .Where(t => t && t.AutoPickup)
                        .FirstOrDefault();
                yield return null;
            }
            while (!inventory);
            
            /*var movement = GetComponent<SimpleMovement>();
            movement.Velocity = PickupVelocity;
            movement.StartMovement();*/
            GetComponent<Rigidbody2D>().velocity = PickupVelocity;
            while (true)
            {
                var bodyCenter = inventory.Entity.transform.localToWorldMatrix.MultiplyPoint(inventory.Entity.GetComponent<Rigidbody2D>().centerOfMass);
                Debug.DrawLine(bodyCenter, transform.position);
                GetComponent<Rigidbody2D>().AddForce((inventory.Entity.transform.position - transform.position).normalized * Acceleration, ForceMode2D.Force);
                //movement.Acceleration = (inventory.Entity.transform.position - transform.position).normalized * Acceleration;
                if ((bodyCenter.ToVector2()-transform.position.ToVector2()).magnitude <= inventory.PickupDistance)
                {
                    inventory.Items.Add(Item);
                    inventory.Entity.GetComponent<AudioController>().PlayEffect(Item.PickupSoundEffect);
                    break;
                }
                yield return null;
            }

            Destroy(gameObject);
        }

        private void OnDrawGizmosSelected()
        {
            Color color = Color.green;
            Gizmos.DrawWireSphere(transform.position, TraceRadius);
        }

    }
}