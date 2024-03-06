using System;

namespace HeroPerks
{
    [Flags]
    enum Perks
    {
        none = 0,
        WaterBreathing = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    }
    class Program
    {
        static void Main(string[] args)
        {

            Perks PerkSet = Perks.none;

            if (args[0].Length > 0)
            {
                foreach (char i in args[0])
                {
                    string letter = char.ToString(i);
                    if (letter == "w")
                    {
                        PerkSet ^= Perks.WaterBreathing;
                    }
                    else if (letter == "s")
                    {
                        PerkSet ^= Perks.Stealth;
                    }
                    else if (letter == "a")
                    {
                        PerkSet ^= Perks.AutoHeal;
                    }
                    else if (letter == "d")
                    {
                        PerkSet ^= Perks.DoubleJump;
                    }
                    else
                    {
                        Console.WriteLine("Unknown perk!");
                        return;
                    }
                }
            }

            Perks PerkSetLength = PerkSet;

            if (PerkSet == Perks.none)
            {
                Console.WriteLine("No perks at all!");
            }
            else
            {
                if ((PerkSet & Perks.WaterBreathing) == Perks.WaterBreathing)
                {
                    Console.Write("WaterBreathing");

                    if ((PerkSetLength ^ Perks.WaterBreathing) != Perks.none)
                    {
                        Console.Write(", ");
                        PerkSetLength ^= Perks.WaterBreathing;
                    }
                }

                if ((PerkSet & Perks.Stealth) == Perks.Stealth)
                {
                    Console.Write("Stealth");

                    if ((PerkSetLength ^ Perks.Stealth) != Perks.none)
                    {
                        Console.Write(", ");
                        PerkSetLength ^= Perks.Stealth;
                    }
                }

                if ((PerkSet & Perks.AutoHeal) == Perks.AutoHeal)
                {
                    Console.Write("AutoHeal");

                    if ((PerkSetLength ^ Perks.AutoHeal) != Perks.none)
                    {
                        Console.Write(", ");
                    }
                }
                if ((PerkSet & Perks.DoubleJump) == Perks.DoubleJump)
                {
                    Console.Write("DoubleJump");
                }
                Console.Write("\n");

                if ((PerkSet & (Perks.DoubleJump ^ Perks.Stealth)) == (Perks.DoubleJump ^ Perks.Stealth))
                {
                    Console.WriteLine("Silent jumper!");
                }
            }

            if ((PerkSet & Perks.AutoHeal) == Perks.none)
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}
