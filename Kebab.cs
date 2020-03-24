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
        public bool addSauce(List<Sauce> sauce)
        {
            Sauces.AddRange(sauce);
            return true;
        }

        public Kebab SansOignon()
        {
            var k = new Kebab(Ingredients);
            k.Ingredients.RemoveAll(i => i.Type == IngredientType.Oignon);
            k.Sauces.AddRange(Sauces);
            return k;
        }
        
        public Kebab Cheese()
        {
            var k = new Kebab(Ingredients);
            k.Sauces.AddRange(Sauces);
            
            foreach (var i in Ingredients)
            {
                if (i.Type == IngredientType.Fromage)
                {
                    k.Ingredients.Add(i);
                }
            }
            return k;
        }
    }
}