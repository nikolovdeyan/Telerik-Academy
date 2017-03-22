namespace Kitchen.Contracts
{
    internal interface IChef
    {
        void Peel(IIngredient ingredient);

        void Cut(IIngredient ingredient);
    }
}