using System;

namespace Location
{
    public class WifiLocator : Handler
    {
        protected override bool execute()
        {
            Console.WriteLine("- Fetching location from WiFi");
            if (RandomContainer.getRandomBool())
            {
                Console.WriteLine("Result found from WiFi");
                return true;
            }
            return false;
        }
    }
}