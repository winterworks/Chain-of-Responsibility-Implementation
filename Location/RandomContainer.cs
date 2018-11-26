using System;

namespace Location
{
    public static class RandomContainer
    {
        private static readonly Random Random = new Random();

        public static bool getRandomBool()
        {
            return Random.NextDouble() > 0.5;
        }
    }
}