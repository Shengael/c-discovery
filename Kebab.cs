using System.Collections.Generic;

namespace kebab
{
    public class Kebab
    {

        bool isVegie(List<Ingredient> ingredients, List<IngredientType> types)
        {
            return !ingredients.Exists(ingredient => types.Contains(ingredient.Type));
        }
    }
}