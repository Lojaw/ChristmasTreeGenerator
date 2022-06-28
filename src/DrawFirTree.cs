using System;

namespace FirTree
{
    partial class main
    {
        public static void drawStem(int hight, char stemSymbol)
        {

            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < 39; j++)
                {
                    screenWrite(" ");
                }
                screenWrite(stemSymbol);
                screenWrite("\n");
            }
        }

        public static void drawFirTree(int heightFir, char stemSymbol, Boolean isOnTheHead)
        {
            screenClear();

            for (int i = 0; i < 23 - (heightFir - (currentStemHeight - 2)); i++)
            {
                screenWrite("\n");
            }

            if (isOnTheHead)
            {
                drawStem(currentStemHeight, currentTreeSymbol);
            }

            for (int i = 0; i < heightFir; i++)
            {
                if (isOnTheHead)
                {
                    for (int j = 0; j < (40 - heightFir + i); j++)
                    {
                        screenWrite(" ");
                    }

                    for (int j = 0; j < 2 * (heightFir - i) - 1; j++)
                    {
                        screenWrite(stemSymbol);
                    }
                    screenWrite("\n");

                }
                else
                {
                    for (int j = 0; j < 39 - i; j++)
                    {
                        screenWrite(" ");
                    }

                    for (int j = 0; j < 2 * i + 1; j++)
                    {
                        screenWrite(stemSymbol);
                    }
                    screenWrite("\n");
                }
            }

            if (!isOnTheHead)
            {
                drawStem(currentStemHeight, currentTreeSymbol);
            }

            screenWriteLine("Press '1' to continue playing");
            screenWriteLine("Press '2' to exit");
            Boolean isCorrect = false;

            string inputStr;

            do
            {
                inputStr = inputString();

                if (inputStr.Equals("1"))
                {
                    isCorrect = true;
                    mainMenu();

                }
                else if (inputStr.Equals("2"))
                {
                    isCorrect = true;
                    programExit();

                }
                else if (inputStr.Equals("c#"))
                {
                    isCorrect = true;
                    easterEgg();

                }
                else
                    screenWriteLine("Please enter a number between 1 and 2");

            } while (inputStr == "" || isCorrect == false);
        }
    }
}