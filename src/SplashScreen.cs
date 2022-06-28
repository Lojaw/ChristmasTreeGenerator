using System;

namespace FirTree
{
    partial class main
    {
        public static void splashScreen()
        {
            screenClear();

            screenWriteLine("Christmas tree generator");
            screenWriteLine("version: " + version);
            screenWriteLine("");
            screenWriteLine("Please press any key to continue");

            do
            {

            } while (!Console.KeyAvailable);
            Console.ReadKey();

            screenClear();
        }
    }
}