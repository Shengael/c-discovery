using System;
using System.Collections.Generic;

namespace kebab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var i = new List<Ingredient>
            {
                new Ingredient("poulet", IngredientType.Poulet),
                new Ingredient("crevette", IngredientType.Crevette),
                new Ingredient("poisson", IngredientType.Poisson),
                new Ingredient("salade", IngredientType.Vegie),
                new Ingredient("parmesan", IngredientType.Fromage),
                new Ingredient("oignon", IngredientType.Vegie),
            };

            var kebab = new Kebab(i);
            Console.WriteLine(kebab);
            Console.WriteLine(kebab.SansOignon());
            Console.WriteLine(kebab.SupplementFromage());
            Console.WriteLine(kebab.CheckType(new List<IngredientType>{IngredientType.Vegie, IngredientType.Poulet}));
        }
    }
}