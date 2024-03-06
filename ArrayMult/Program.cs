using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            float [,] FinalArray = new float [2, 1];
            FinalArray[0, 0] = float.Parse(args[0]) * float.Parse(args[4]) + float.Parse(args[1]) * float.Parse(args[5]);
            FinalArray[1, 0] = float.Parse(args[2]) * float.Parse(args[4]) + float.Parse(args[3]) * float.Parse(args[5]);

            Console.WriteLine(FinalArray[0, 0]);
            Console.WriteLine(FinalArray[1, 0]);
        }
    }
}
