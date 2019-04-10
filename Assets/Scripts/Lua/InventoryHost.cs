using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;
using Inventory;
using UnityEngine;

namespace LuaHost
{
    public class InventoryHost
    {
        public class ItemProxy: Proxy.ProxyBase<Item>
        {
            public String Name
            {
                get => target.DisplayName;
                set => target.DisplayName = value;
            }
            public Sprite Icon
            {
                get => target.Iconx32;
                set => target.Iconx32 = value;
            }
            public ItemProperty[] Properties
            {
                get => target.Properties;
                set => target.Properties = value;
            }

            public ItemProxy(Item target, LuaScriptHost host) : base(target, host)
            {
            }

            public void AddProperty(ItemProperty property)
            {
                var props = Properties;
                if (props == null)
                    props = new ItemProperty[0];
                Array.Resize(ref props, Properties.Length + 1);
                props[props.Length - 1] = property;
                Properties = props;
            }

            public static Recipe operator +(ItemProxy item1, ItemProxy item2)
                => item1.target + item2.target;
            public static Recipe operator +(ItemProxy item1, Item item2)
                => item1.target + item2;
            public static Recipe operator +(Item item1, ItemProxy item2)
                => item1 + item2.target;
            public static Recipe operator +(ItemProxy item, RecipeProxy recipe)
                => item.target + recipe.target;
            public static Recipe operator +(RecipeProxy recipe, ItemProxy item)
                => recipe.target + item.target;
        }

        public class RecipeProxy : Proxy.ProxyBase<Recipe>
        {
            public Item Product
            {
                get => target.Product;
                set
                {
                    target.Product = value;
                    CraftSystem.Instance.Add(target);
                }
            }
            public RecipeProxy(Recipe target, LuaScriptHost host) : base(target, host)
            {
            }

            public static Recipe New()
            {
                return new Recipe();
            }

            public RecipeProxy Add(Item item)
            {
                target.Materials.Add(item);
                return this;
            }

            public RecipeProxy Add(Recipe recipe)
            {
                this.target.Materials.AddRange(recipe.Materials);
                return this;
            }
        }

    }
}
