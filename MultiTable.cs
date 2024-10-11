using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SlonitTEST
{
    class MultiTable (int multiplier)
    {
        private int maxSymb = (multiplier * multiplier).ToString().Length;
        private string FillSpaces(string inputString)
        {
            //while (inputString.Length < maxSymb + 1)
            //{
            //    inputString = " " + inputString;
            //}
            inputString = inputString.PadLeft(maxSymb+1);
            return inputString;           
        }

        public void ShowInConsole()
        {
            Console.WriteLine();
            for (int i = 0; i != multiplier + 1; i++)
            {
                if (i == 0)
                {
                    Console.Write(FillSpaces(""));
                    for (int j = 1; j != multiplier + 1; j++)
                    {
                        Console.Write(FillSpaces(j.ToString()));
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(FillSpaces(i.ToString()));
                    for (int j = 1; j != multiplier + 1; j++)
                    {
                        Console.Write(FillSpaces((j * i).ToString()));
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
