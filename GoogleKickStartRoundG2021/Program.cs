using System;
using System.Collections.Generic;

namespace GoogleKickStartRoundG2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, d, c, m, totalcount;
            totalcount = Console.Read();
            string str = "";
            while (totalcount >0)
            {
                n = Console.Read();
                d = Console.Read();
                c = Console.Read();
                m = Console.Read();
                str = Console.ReadLine();
                Console.WriteLine(myMethod(n, d, c, m,str));
                totalcount--;
            }
        }
        private static string myMethod(int TotalAnimal,int dogPortion,int catPortion,int xtraCatPortion,string animals)
        {
            bool IsCatFed = false;
            int constantCatportion = xtraCatPortion;
            for(int i = 0; i < TotalAnimal; i++)
            {
                if (animals[i] == 'D')
                {
                    if (IsCatFed)
                    {
                        xtraCatPortion = constantCatportion;
                        dogPortion--;
                    }
                    else if (dogPortion < 0 || !IsCatFed)
                    {
                        return "No";
                    }
                }
                if (animals[i] == 'C')
                {
                    if (catPortion > 0)
                    {
                        catPortion--;
                        IsCatFed = true;
                    }
                    else 
                    {
                        if(xtraCatPortion > 0)
                        {
                            xtraCatPortion--;
                            IsCatFed = true;
                        }
                        else
                        {
                            IsCatFed = false;
                        }
                    }
                }
            }
            return "Yes";
        }
    }
}
