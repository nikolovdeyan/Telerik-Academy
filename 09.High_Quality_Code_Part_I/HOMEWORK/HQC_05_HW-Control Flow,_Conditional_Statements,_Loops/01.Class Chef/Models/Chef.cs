using System;
using Kitchen.Contracts;
using Kitchen.Enums;

namespace Kitchen.Models
{
    public class Chef : IChef
    {
        // A factory method to create Ingredients, should not be in the instanced class usually
        public static IIngredient GetIngredient(Ingredients ingredient)
        {
            switch (ingredient)
            {
                case Ingredients.Carrot:
                    return new Carrot();
                case Ingredients.Potato:
                    return new Potato();
                default:
                    throw new ArgumentException("Unimplemented ingredient provided.");
            }
        }

        // This chef only knows this one recipe...
        public void Cook()
        {
            IIngredient potato = GetIngredient(Ingredients.Potato);
            IIngredient carrot = GetIngredient(Ingredients.Carrot);
            IUtensil bowl = new Bowl();

            this.Peel(potato);
            this.Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        public void Cut(IIngredient ingredient)
        {
            if (ingredient.IsPeeled == false)
            {
                Console.WriteLine("Ingredient must be peeled before it can be sliced.");
            }
            else if (ingredient.IsCut == false)
            {
                ingredient.IsCut = true;
            }
        }

        public void Peel(IIngredient ingredient)
        {
            if (ingredient.IsPeeled == false)
            {
                ingredient.IsPeeled = true;
            }
        }
    }
}