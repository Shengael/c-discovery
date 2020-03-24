using System;

namespace kebab
{
    public class Ingredient
    {
        public Ingredient(string name, IngredientType type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; set; }
        public IngredientType Type { get; set; }

    }
}