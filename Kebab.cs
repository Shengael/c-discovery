using System.Collections.Generic;

namespace kebab
{
    public class Kebab
    {

        public bool CheckType(List<Ingredient> ingredients, List<IngredientType> types)
        {
            return !ingredients.Exists(ingredient => !types.Contains(ingredient.Type));
        }
    }
}