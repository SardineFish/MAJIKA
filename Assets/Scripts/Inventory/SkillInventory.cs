using UnityEngine;
using System.Collections;
using System.Linq;

namespace Inventory
{
    public class SkillInventory : EntityBehaviour<GameEntity>
    {
        public MajikaElement[] Elements = new MajikaElement[4];
        public Skill[] Skills = new Skill[4];
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            var elements = Entity.GetEntityComponent<Inventory>().Slots
                .Where(item => item.Item && item.Amount > 0)
                .Select(item => item.Item.GetProperty<MajikaElement>())
                .ToArray();
            var skillController = Entity.GetComponent<SkillController>();
            for (var i = 0; i < 4; i++)
            {
                if (i >= elements.Length && Skills[i])
                {
                    skillController.RemoveSkill(i);
                    Elements[i] = null;
                }
                else if (i < elements.Length && Elements[i] != elements[i])
                {
                    if (Elements[i])
                        skillController.RemoveSkill(i);
                    skillController.AddSkill(elements[i].Skill.GetComponent<Skill>(), i);
                    Elements[i] = elements[i];
                }

            }
        }
    }

}