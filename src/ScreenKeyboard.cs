using System;

namespace FirTree
{
    partial class main
    {
        static void screenWriteLine(string text)
        {
            Console.WriteLine(text);
        }

        static void screenWriteLine(int text)
        {
            Console.WriteLine(text);
        }

        static void screenWrite(string text)
        {
            Console.Write(text);
        }
        static void screenWrite(char Character)
        {
            Console.Write(Character);
        }

        static void screenClear()
        {
            Console.Clear();
        }

        static int inputNumber()
        {
            int result = int.Parse(Console.ReadLine());

            return result;
        }

        static string inputString()
        {
            string result = Console.ReadLine();

            return result;
        }

        static char inputChar()
        {
            char result = Console.ReadKey().KeyChar;

            return result;
        }

        public static void programExit()
        {
            Environment.Exit(0);
        }
    }
}