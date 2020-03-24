using System.Collections.Generic;

namespace kebab
{
    public class Kebab
    {
        
        private List<Ingredient> Ingredients;
        private List<Sauce> Sauces = new List<Sauce>();

        public Kebab(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }

        public bool CheckType(List<IngredientType> types)
        {
            return !Ingredients.Exists(ingredient => !types.Contains(ingredient.Type));
        }

        public bool addSauce(Sauce sauce)
        {
            Sauces.Add(sauce);
            return true;
        }
    }
}