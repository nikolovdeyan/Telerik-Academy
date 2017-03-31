using System.Collections.Generic;
using Kitchen.Contracts;

namespace Kitchen.Models
{
    internal class Bowl : IUtensil
    {
        private List<IIngredient> contents;

        public Bowl()
        {
            this.contents = new List<IIngredient>();
        }

        public List<IIngredient> Contents
        {
            get
            {
                return this.contents;
            }

            private set
            {
            }
        }

        public void Add(IIngredient ingredient)
        {
            this.contents.Add(ingredient);
        }

        public void Remove(IIngredient ingredient)
        {
            this.contents.Remove(ingredient);
        }
    }
}