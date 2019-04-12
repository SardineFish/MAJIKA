using UnityEngine;
using System.Collections;
using System.Linq;
using Inventory;

namespace MAJIKA.GUI
{
    [RequireComponent(typeof(UITemplateRenderer))]
    [ExecuteInEditMode]
    public class HandbookRenderer : MonoBehaviour
    {
        Item[] Items = new Item[0];
        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            var items = Resources.LoadAll<Item>("Items");
            if (items.Length != Items.Length || items.Any((t, idx) => Items[idx] != t) || GetComponent<UITemplateRenderer>().DataSource == null)
            {
                this.Items = items;
                GetComponent<UITemplateRenderer>().DataSource = items;
            }
        }
    }

}