using System;

namespace Location
{
    // Code inspired by: https://www.javaworld.com/article/2072857/java-web-development/the-chain-of-responsibility-pattern-s-pitfalls-and-improvements.html
    internal static class Sender
    {
        public static void Main(string[] args)
        {
            // As an example we have the option to toggle WiFi should be added to the chain.
            const bool HAS_WIFI = true;
            
            Handler gpsLocator = new GpsLocator();
            Handler cellularLocator = new CellularLocator();
            cellularLocator.NextHandler = gpsLocator;
            if (HAS_WIFI)
            {
                Handler wifiLocator = new WifiLocator();
                gpsLocator.NextHandler = wifiLocator;
            }

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Starting request: "+i);
                cellularLocator.Handle();
                Console.WriteLine("");
            }
        }
    }
}