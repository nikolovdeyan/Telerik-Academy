using System.IO;
using System.Collections.Generic;
using Bunnies.Models.Bunny;
using Bunnies.Enums;
using Bunnies.Models.ConsoleWriter;

namespace Bunnies
{
    public class Startup
    {
        public const string bunniesFilePath = @"..\..\bunnies.txt";
        #region bunnies-list-definition
        public static List<Bunny> bunnies = new List<Bunny>
            {
                new Bunny
                {
                   Name = "Leonid",
                   Age = 1,
                   FurType = FurType.NotFluffy
                },

                new Bunny
                {
                   Name = "Rasputin",
                   Age = 2,
                   FurType = FurType.ALittleFluffy
                },

                new Bunny
                {
                   Name = "Tiberii",
                   Age = 3,
                   FurType = FurType.ALittleFluffy
                },

                new Bunny
                {
                   Name = "Neron",
                   Age = 1,
                   FurType = FurType.ALittleFluffy
                },

                new Bunny
                {
                   Name = "Klavdii",
                   Age = 3,
                   FurType = FurType.Fluffy
                },

                new Bunny
                {
                   Name = "Vespasian",
                   Age = 3,
                   FurType = FurType.Fluffy
                },

                new Bunny
                {
                   Name = "Domician",
                   Age = 4,
                   FurType = FurType.FluffyToTheLimit
                },

                new Bunny
                {
                   Name = "Tit",
                   Age = 2,
                   FurType = FurType.FluffyToTheLimit
                }
            };
        #endregion

        public static void Main()
        {
            ConsoleWriter consoleWriter = new ConsoleWriter();



            foreach (var bunny in bunnies)
            {
                bunny.Introduce(consoleWriter);
            }

            var fileStream = File.Create(bunniesFilePath);

            fileStream.Close();

            using (var streamWriter = new StreamWriter(bunniesFilePath))
            {
                foreach (var bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }
}