using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {

            float [][] FirstArray = new float [2][];
            FirstArray[0] = new float [2] {float.Parse(args[0]), float.Parse(args[1])};
            FirstArray[1] = new float [2] {float.Parse(args[2]), float.Parse(args[3])};

            float [][] SecondArray = new float [2][];
            SecondArray[0] = new float [1] {float.Parse(args[4])};
            SecondArray[1] = new float [1] {float.Parse(args[5])};

            float [][] FinalArray = new float [2][];
            FinalArray[0] = new float [1] {0};
            FinalArray[1] = new float [1] {0};

            for (int i = 0;  i < FinalArray.Length; i += 1)
            {
                for (int e = 0; e < FinalArray[i].Length; e += 1)
                {
                    FinalArray[i] = new float [1] {FirstArray[i][0] * SecondArray[0][0] + FirstArray[i][1] * SecondArray[1][0]};
                }
            }
            //FinalArray[0, 0] = float.Parse(args[0]) * float.Parse(args[4]) + float.Parse(args[1]) * float.Parse(args[5]);
            //FinalArray[1, 0] = float.Parse(args[2]) * float.Parse(args[4]) + float.Parse(args[3]) * float.Parse(args[5]);

            Console.WriteLine(FinalArray[0][0]);
            Console.WriteLine(FinalArray[1][0]);
        }
    }
}
