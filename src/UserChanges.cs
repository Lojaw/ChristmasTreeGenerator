using System;

namespace FirTree
{
    partial class main
    {

        public static void changeStemHeight()
        {
            screenClear();
            screenWriteLine("The current stem sign is " + currentStemHeight);
            screenWriteLine("What should be the value of the stem height?");

            int height = 0;
            Boolean isCorrect = false;

            do
            {
                try
                {
                    height = inputNumber();
                    if (height >= 1 && height <= 22)
                    {
                        isCorrect = true;
                        currentStemHeight = height;
                        mainMenu();

                    }
                    else
                        screenWriteLine("Please enter a number between 1 and 22");

                }
                catch (Exception e)
                {
                    screenWriteLine("Please enter a number between 1 and 22");
                }
            } while (height == 0 || isCorrect == false);
        }

        public static void changeTreeSymbol()
        {
            screenClear();
            screenWriteLine("The current tree symbol is " + currentTreeSymbol);
            screenWriteLine("Please enter the new symbol for the tree: ");

            char treeSymbol;
            Boolean isCorrect = false;

            do
            {
                try
                {
                    treeSymbol = inputChar();
                    isCorrect = true;
                    currentTreeSymbol = treeSymbol;
                    mainMenu();

                } catch (Exception e)
                {
                    screenWriteLine("Please enter a character");
                }

            } while (isCorrect == false);
        }
    }
}
