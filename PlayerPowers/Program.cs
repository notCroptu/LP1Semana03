using System;

namespace PlayerPowers
{
    [Flags]
    enum Powers
    {
        Fly = 0,
        XRayVision = 1,
        SuperStrength = 2,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many players? ");
            int n = int.Parse(Console.ReadLine());

            string [][] pPowers = new string[n][];

            for (int i = 0;  i < pPowers.Length; i += 1)
            {
                pPowers[i] = new string [3];

                for (int e = 0; e < 3; e += 1)
                {
                    Console.Write($"Do you have {Enum.GetName(typeof(Powers), e)}? ");
                    string yon = Console.ReadLine();
                    yon = yon.ToLower();
                    
                    if (yon == "yes" || yon == "y")
                    {
                        pPowers[i][e] = ((Powers) e).ToString();
                    }
                    else
                    {
                        pPowers[i][e] = "none";
                    }
                }
            }

            for (int k = 0;  k < pPowers.Length; k += 1)
            {
                string result = $"Player {k + 1} powers: ";
                for (int j = 0; j < 3; j += 1)
                {

                    if (pPowers[k][j] != "none")
                    {
                        result += $"{pPowers[k][j]}, ";
                    }
                }
                result = result.TrimEnd(',', ' ');
                Console.WriteLine(result);

                if (pPowers[k][0] != "none" && pPowers[k][2] !="none")
                {
                    Console.WriteLine("Flying Radiation!");
                }
            }
        }
    }
}
