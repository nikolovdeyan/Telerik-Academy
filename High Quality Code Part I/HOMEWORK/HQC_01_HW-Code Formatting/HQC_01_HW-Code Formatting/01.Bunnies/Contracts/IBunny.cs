using Bunnies.Enums;

namespace Bunnies.Contracts
{
    public interface IBunny
    {
        int Age { get; }
        string Name { get; }
        FurType FurType { get; }

        void Introduce(IWriter writer);

        string ToString();
    }
}
