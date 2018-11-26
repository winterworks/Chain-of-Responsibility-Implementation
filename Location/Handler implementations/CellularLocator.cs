using System;

namespace Location
{
    public class CellularLocator : Handler
    {
        protected override bool execute()
        {
            Console.WriteLine("- Fetching location from cellular towers");
            if (RandomContainer.getRandomBool())
            {
                Console.WriteLine("Result found from cellular towers");
                return true;
            }
            return false;
        }
    }
}