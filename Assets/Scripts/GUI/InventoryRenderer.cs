using UnityEngine;
using System.Collections;
using Inventory;

namespace MAJIKA.GUI
{
    [RequireComponent(typeof(UITemplateRenderer))]
    public class InventoryRenderer : Singleton<InventoryRenderer>
    {
        public Inventory.Inventory Inventory;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(Inventory)
            {
                GetComponent<UITemplateRenderer>().DataSource = Inventory.Slots;
            }
        }
    }

}
