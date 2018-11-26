using System;

namespace Location
{
    public static class RandomContainer
    {
        private static readonly Random randomContainer = new Random();

        public static bool getRandomBool()
        {
            return randomContainer.NextDouble() > 0.5;
        }
    }
}