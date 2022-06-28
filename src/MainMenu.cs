using System;

namespace FirTree
{
    partial class main
    {
        public static void mainMenu()
        {
            screenClear();

            screenWriteLine("1. Christmas tree");
            screenWriteLine("2. Christmas tree upside down");
            screenWriteLine("3. change stem height");
            screenWriteLine("4. change tree symbol");
            screenWriteLine("5. exit program");
            screenWriteLine("");
            screenWriteLine("Please select a menu item and confirm it with return");
            screenWriteLine("");
            screenWriteLine("The current stem height: " + currentStemHeight);
            screenWriteLine("The current tree symbol: " + currentTreeSymbol);

            Boolean isCorrect = true;
            int number = 0;

            do
            {
                try
                {
                    number = inputNumber();

                    switch (number)
                    {
                        case 1:
                            christmasTree(false);
                            break;

                        case 2:
                            christmasTree(true);
                            break;

                        case 3:
                            changeStemHeight();
                            break;

                        case 4:
                            changeTreeSymbol();
                            break;

                        case 5:
                            programExit();
                            break;

                        default:
                            isCorrect = false;
                            screenWriteLine("Please enter a number between 1 and 5");
                            break;

                    }                   
                }
                catch (Exception e)
                {
                    isCorrect = false;
                    screenWriteLine("Please enter a number between 1 and 5");
                }
            } while (number == 0 || isCorrect == false);
        }
    }
}