
Item = {}
Item.mt = {}
function Item.find(name)
    local item = {}
    setmetatable(item, Item.mt)
    item.innerItem = resources.item(name);
    item.from = function(recipe)
        return Item.setRecipe(item, recipe)
    end
    return item
end

function Item.union(item1, item2)
    local recipe = Recipe.new()
    recipe.add(item1)
    recipe.add(item2)
    return recipe
end
function Item.setRecipe(item, recipe)
    if getmetatable(recipe) == Item.mt then
        local r = Recipe.new()
        r.add(recipe)
        r.inner.product = item.innerItem
        return r
    else 
        recipe.inner.product = item.innerItem
        return recipe
    end
end
Item.mt.__add = Item.union

Recipe = {}
Recipe.mt = {}
function Recipe.new()
    local recipe = {}
    setmetatable(recipe, Recipe.mt)
    recipe.inner = RecipeType.new()

    recipe.add = function(mat)
        recipe.inner.add(mat.innerItem);
        return recipe;
    end
    return recipe
end

function Recipe.union(recipe, obj)
    if getmetatable(obj) == Item.mt then
        recipe.add(obj)
        return recipe
    elseif getmetatable(obj) == Recipe.mt then
        local newRecipe = Recipe.new()
        for i, item in ipairs(recipe.materials) do
            newRecipe.add(item)
        end
        for i, item in ipairs(obj.materials) do
            newRecipe.add(item)
        end
        return newRecipe
    end
end
Recipe.mt.__add = Recipe.union