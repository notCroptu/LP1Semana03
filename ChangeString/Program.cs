using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a string: ");
            string stringLine = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Insert the character to substitute: ");
            string character = Console.ReadLine();
            Console.WriteLine();
            string Result = "";

            foreach (char letter in stringLine)
            {
                if (char.ToString(letter) == character)
                {
                    Result += "X";
                }
                else
                {
                    Result += letter;
                }
            }
            Console.WriteLine(Result);
        }
    }
}
