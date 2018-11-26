using System;

namespace Location
{
    internal static class Sender
    {
        public static void Main(string[] args)
        {
            const bool hasWiFi = true;
            const bool hasCellular = true;
            
            Handler gpsLocator = new GpsLocator();
            Handler cellularLocator = new CellularLocator();
            cellularLocator.nextHandler = gpsLocator;
            if (hasWiFi)
            {
                Handler wifiLocator = new WifiLocator();
                gpsLocator.nextHandler = wifiLocator;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Starting request: "+i);
                cellularLocator.Handle();
                Console.WriteLine("");
            }
        }
    }
}