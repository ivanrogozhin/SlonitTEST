using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlonitTEST.Util
{
    internal class Formating
    {
        static public string ArrayToString(Array arr)
        {
            string resStr = string.Empty;
            resStr += "[";
            foreach (var item in arr)
            {
                try
                {
                    resStr += item.ToString() + ", ";
                }
                catch
                {
                }
            }
            try
            {
                resStr = resStr.Remove(resStr.Length - 2);
            }
            catch {}

            resStr += "]";
            return resStr;
        }

        static public int[] StringToIntArray(string str)
        {
            List<int> list = new List<int>();
            var items = str.Split(' ');
            foreach (var item in items)
            {
                try
                {
                    list.Add(int.Parse(item));
                }
                catch
                {
                    Console.WriteLine("Элемент '" + item + "' не удалось преобразовать в число");
                }
            }
            return list.ToArray();
        }

    }
}
