using System.Collections.Generic;

namespace kebab
{
    public class Kebab
    {

        bool isVegie(List<Ingredient> ingredients)
        {
            return !ingredients.Exists(Ingredient => Ingredient.Type != "vegie");
        }
    }
}