using System.Collections.Generic;

namespace Kitchen.Contracts
{
    public interface IUtensil
    {
        List<IIngredient> Contents { get; }

        void Add(IIngredient ingredient);
    }
}