using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlonitTEST.Components
{
    internal class CommonDivisors
    {
        public static int[] GetComDiv (int[] arr)
        {
            List<int> res = new List<int>();
            int minElm;
            try
            {
                minElm = Math.Abs(arr[0]);
            }
            catch 
            {
                minElm = 0;
            }
            foreach (int i in arr)
            {
                if (minElm > Math.Abs(i)) minElm = Math.Abs(i);
            }
            for (int i = 2; i <= minElm; i++)
            {
                if ((minElm % i) == 0)
                {
                    int divCount = 0;
                    foreach (int j in arr)
                    {
                        if ((j % i) == 0) divCount++; 
                    }
                    if (divCount == arr.Length) res.Add(i);
                }
            }
            return res.ToArray();
        }
    }
}
