namespace Kitchen.Contracts
{
    public interface IIngredient
    {
        bool IsPeeled { get; set; }

        bool IsCut { get; set; }

        bool IsRotten { get; set; }
    }
}