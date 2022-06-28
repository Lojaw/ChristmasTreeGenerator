using System;

namespace FirTree
{
    partial class main
    {

        public static string version = "1.0.0";
        public static int currentStemHeight = 2;
        public static char currentTreeSymbol = '*';


        static void Main(string[] args)
        {
            splashScreen();
            mainMenu();
        }

        public static void easterEgg()
        {
            screenClear();
            screenWriteLine("You have found the Easter Egg!");
            screenWriteLine("Congratulations!");

            do
            {

            } while (!Console.KeyAvailable);
            Console.ReadKey();

        }

        public static void christmasTree(Boolean isOnTheHead)
        {
            screenClear();
            screenWriteLine("How high (lines) should the fir tree be (1 to 22)? Enter the height as a number and confirm with return");

            int height = 0;
            Boolean isCorrect = false;

            do
            {    
                try
                {
                    height = inputNumber();
                    if( height >= 1 &&  height <= 22)
                    {
                        isCorrect = true;
                        if(isOnTheHead)
                        {
                            drawFirTree(height, currentTreeSymbol, isOnTheHead);
                        } else
                            drawFirTree(height, currentTreeSymbol, isOnTheHead);

                    } else
                        screenWriteLine("Please enter a number between 1 and 22");
              
                }
                catch (Exception e)
                {
                    screenWriteLine("Please enter a number between 1 and 22");
                }
            } while (height == 0 || isCorrect == false);          
        }

    }
}
