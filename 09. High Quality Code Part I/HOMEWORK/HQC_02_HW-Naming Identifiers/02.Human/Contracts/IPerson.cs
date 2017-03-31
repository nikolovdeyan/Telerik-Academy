using Human.Enums;

namespace Human.Contracts
{
    public interface IPerson
    {
        Gender Gender { get; set; }

        string Name { get; set; }

        int Age { get; set; }
    }
}