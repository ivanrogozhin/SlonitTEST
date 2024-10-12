using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlonitTEST.Components
{
    internal class PrimeNumbers
    {

        private int startN, endN;
        PrimeNumbers(int startN, int endN)
        {
            this.startN = startN;
            this.endN = endN;
        }

        public int[] GetArray()
        {
            List<int> res = new List<int>();
            if (startN < 2) { startN = 2; }
            for (int i = startN; i < endN; i++)
            {
                int temp = 0;
                for (int j = 2; j < endN; j++)
                {

                    if (i % j != 0) temp++;

                }
                if (temp == 1) res.Add(i);
                temp = 0;
            }
            return res.ToArray();
        }

        public static int[] GetArray(int start, int end)
        {
            List<int> res = new List<int>();
            if (start < 2) { start = 2; }
            for (int i = start; i < end; i++)
            {
                int temp = 0;
                for (int j = 2; j <= i; j++)
                {

                    if (i % j == 0) temp++;

                }
                if (temp == 1) res.Add(i);
                temp = 0;
            }
            return res.ToArray();
        }
    }
}
