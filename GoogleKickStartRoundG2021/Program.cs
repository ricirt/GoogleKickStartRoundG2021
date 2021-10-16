using System;
using System.Collections.Generic;

namespace GoogleKickStartRoundG2021
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            List<string> strList = new List<string>();
            Console.WriteLine( myMethod(intList ,strList));
        }
        //(intList[0],intList[1],intList[2],intList[3],strList)
        //(int TotalAnimal, int dogPortion, int catPortion, int xtraCatPortion, string animals)
        private static string myMethod(List<int> intList, List<string> queue)
        {
            bool IsCatFed = false;
            int constantCatportion = intList[3];
            for(int i = 0; i < intList[0]; i++)
            {
                string tempStr= queue[i];
                if (tempStr[i] == 'D')
                {
                    if (IsCatFed)
                    {
                        intList[3] = constantCatportion;
                        intList[1]--;
                    }
                    else if (intList[1] < 0 || !IsCatFed)
                    {
                        return "No";
                    }
                }
                if (tempStr[i] == 'C')
                {
                    if (intList[2] > 0)
                    {
                        intList[2]--;
                        IsCatFed = true;
                    }
                    else 
                    {
                        if(intList[3] > 0)
                        {
                            intList[3]--;
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
