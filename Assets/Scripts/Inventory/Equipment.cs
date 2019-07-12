using UnityEngine;
using System.Collections;
using System.Linq;

namespace Inventory
{
    public class Equipment : EntityBehaviour, ISlotEditor
    {
        [Slot("Skills")]
        public ItemWrapper[] SkillSlots = new ItemWrapper[4];
        [Slot("Cloak")]
        public ItemWrapper Cloak;
        [Slot("Wand")]
        public ItemWrapper Wand;

        Item[] skillElements = new Item[4];
        // Use this for initialization
        void Start()
        {
            for (var i = 0; i < skillElements.Length; i++)
                skillElements[i] = null;
            Entity.GetComponent<SkillController>().ClearSkills();
            Entity.GetComponent<SkillController>().SetSkills(skillElements
                .Select(element => element?.GetProperty<MajikaElement>()?.Skill.GetComponent<Skill>())
                .ToArray());
        }

        // Update is called once per frame
        void Update()
        {
            if(SkillSlots.Any((items, idx)=>skillElements[idx]!=items.Item))
            {
                skillElements = SkillSlots.Select(items => items.Item).ToArray();
                Entity.GetComponent<SkillController>().ClearSkills();
                Entity.GetComponent<SkillController>().SetSkills(skillElements
                    .Select(element => element?.GetProperty<MajikaElement>()?.Skill.GetComponent<Skill>())
                    .ToArray());
            }
        }
    }

}