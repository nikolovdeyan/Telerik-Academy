using System;

namespace Minesweeper.Providers
{
    internal static class Randomizer
    {
        private static Random random = new Random();

        public static Random GetRandomSeed()
        {
            var result = random;

            return result;
        }
    }
}
