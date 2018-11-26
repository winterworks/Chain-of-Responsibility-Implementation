using System;

namespace Location
{
    public class GpsLocator : Handler
    {
        protected override bool execute()
        {
            Console.WriteLine("- Fetching location from GPS");
            if (RandomContainer.getRandomBool())
            {
                Console.WriteLine("Result found from GPS");
                return true;
            }
            return false;
        }
    }
}