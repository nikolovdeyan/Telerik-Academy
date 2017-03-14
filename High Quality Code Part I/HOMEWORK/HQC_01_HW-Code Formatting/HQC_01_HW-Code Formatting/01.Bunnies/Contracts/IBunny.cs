namespace Bunnies.Contracts
{
    using Bunnies.Enums;

    /// <summary>
    /// A contract for bunny qualities
    /// </summary>
    public interface IBunny
    {
        /// <summary>
        /// Gets an IBunny age
        /// </summary>
        int Age { get; }

        /// <summary>
        /// Gets an IBunny name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets an IBunny FurType
        /// </summary>
        FurType FurType { get; }

        /// <summary>
        /// Introduces the IBunny using the provided IWriter
        /// </summary>
        /// <param name="writer">An IWriter object to provide output capabilities</param>
        void Introduce(IWriter writer);

        /// <summary>
        /// A ToString override
        /// </summary>
        /// <returns>A string containing the overriden ToString message</returns>
        string ToString();
    }
}
