using System.Collections.Generic;

namespace kebab
{
    public class Kebab
    {

        bool isVegie(List<Ingredient> ingredients)
        {
            return !ingredients.Exists(ingredient => ingredient.Type != "vegie");
        }
    }
}