using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Inventory;

public class CraftSystem : Singleton<CraftSystem>
{
    public List<Recipe> Recipes = new List<Recipe>();

    public Item Craft(params Item[] materials)
    {
        var subMaterials = materials
            .Skip(1)
            .OrderBy(mat => mat.GetInstanceID())
            .ToArray();

        return Recipes
            .Where(r => r.Materials[0] == materials[0] && r.Materials.Count == materials.Length)
            .Where(recip => recip.Materials
                .Skip(1)
                .OrderBy(mat => mat.GetInstanceID())
                .All((mat, idx) => mat == subMaterials[idx]))
            .FirstOrDefault()?.Product;
    }

    public CraftSystem Add(Recipe recipe)
    {
        Recipes.Add(recipe);
        Debug.Log($"Add to craft system: {recipe.ToString()}");
        return this;
    }
}