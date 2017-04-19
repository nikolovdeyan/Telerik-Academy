namespace Bunnies.Models.Bunny
{
    using System;
    using System.Text;
    using Bunnies.Contracts;
    using Bunnies.Enums;
    using StringExtensions;

    [Serializable]
    public class Bunny : IBunny
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public FurType FurType { get; set; }

        public void Introduce(IWriter writer)
        {
            var furTypeString = this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter();

            writer.WriteLine($"{this.Name} - \"I am {this.Age} years old!\"");
            writer.WriteLine($"{this.Name} - \"And I am {furTypeString}");
        }

        public override string ToString()
        {
            var builderSize = 200;
            var builder = new StringBuilder(builderSize);
            var furTypeString = this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter();

            builder.AppendLine($"Bunny name: {this.Name}");
            builder.AppendLine($"Bunny age: {this.Age}");
            builder.AppendLine($"Bunny fur: {furTypeString}");

            return builder.ToString();
        }
    }
}