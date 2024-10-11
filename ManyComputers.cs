using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// *2 *3 *4 - а
// 5 - 20 - ов
namespace SlonitTEST
{
    internal class ManyComputers
    {
        public static string HowMany (int inNum)
        {
            int num = Math.Abs(inNum);
            string result;
            int lastDig = num % 10;
            if ((num>=10 && num<=20) || (lastDig >=5 && lastDig <=9)) 
                { result = $"{inNum} компьютеров"; }
            else if (lastDig == 1) 
                { result = $"{inNum} компьютер"; }
            else 
                { result = $"{inNum} компьютера"; }
            return result;
        }
    }
}
