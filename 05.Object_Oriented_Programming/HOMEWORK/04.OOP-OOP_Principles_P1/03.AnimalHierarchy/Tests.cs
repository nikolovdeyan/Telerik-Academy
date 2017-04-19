using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    class Tests
    {
        public static void Main(string[] args)
        {
            // Create arrays of different kinds of animals and calculate the average age
            // of each kind of animal using a static method.

            Animal[] myFantasyAnimals = new Animal[]
            {
                new Frog("Trevor", 4, Gender.Male),
                new Dog("Molly", 3, Gender.Female),
                new Kitten("Tabitha Twitchit", 1),
                new Tomcat("Greebo", 11),
                new Kitten("Dinah", 2),
                new Dog("Kujo", 7, Gender.Male),
                new Dog("Fang", 5, Gender.Male),
                new Dog("Lassie", 8, Gender.Female),
                new Kitten("Bombalurina", 4),
                new Kitten("Buttercup", 1),
                new Frog("Kermit", 8, Gender.Male),
                new Tomcat("Crookshanks", 4),
                new Tomcat("Maurice", 2),
                new Dog("Toto", 2, Gender.Male)
            };

            // Print the array of animals.
            DisplayAnimals(myFantasyAnimals);

            // Use a static method to calculate the average age of each kind of animal.
            double avgAgeDogs = AnimalAvgAge(myFantasyAnimals, "Dog");
            double avgAgeFrogs = AnimalAvgAge(myFantasyAnimals, "Frog");
            double avgAgeKittens = AnimalAvgAge(myFantasyAnimals, "Kitten");
            double avgAgeTomcats = AnimalAvgAge(myFantasyAnimals, "Tomcat");

            // Print the respective groups average age.
            Console.WriteLine(new String('*', 50));
            Console.WriteLine("The average age of the groups in the collection:\n");
            Console.WriteLine(" * Dogs:        {0:F2}", avgAgeDogs);
            Console.WriteLine(" * Frogs:       {0:F2}", avgAgeFrogs);
            Console.WriteLine(" * Cats:        {0:F2}", (avgAgeKittens+avgAgeTomcats/2));
            Console.WriteLine("   - Kittens:   {0:F2}", avgAgeKittens);
            Console.WriteLine("   - Tomcats:   {0:F2}", avgAgeTomcats);
            Console.WriteLine();
        }



        // This static method will return the average age of the animals mathing the given animal type.
        private static double AnimalAvgAge(IEnumerable<Animal> collection, string animalType)
        {
            var averageAgeGroup = collection.Where(x => x.GetType().Name == animalType)
                                            .Average(x => x.Age);

            return averageAgeGroup;
        }

        // This static method will display the animals in a collection.
        private static void DisplayAnimals(IEnumerable<Animal> collection)
        {
            Console.WriteLine(new String('*', 50));
            Console.WriteLine("Printing the list of animals: \n");

            foreach (var animal in collection)
            {
                Console.WriteLine("Hi! I am {0} and I am a {1}! {2}", animal.Name, animal.GetType().Name, animal.MakeSound());
            }

            Console.WriteLine();
        }
    }
}
