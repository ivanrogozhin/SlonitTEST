using System;
// 1 Много комьютера - 27 минут
// 2 Общий делитель массива чисел
// 3 Простые числа в диапазоне
// 4 Таблица умножения - 45 минут
namespace SlonitTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //-------------------------4
            MultiTable mTable = new MultiTable(45);
            //-------------------------1
            int temp;
            while (true)
            {
                string stemp = Console.ReadLine();
                try
                {
                    temp = Int32.Parse(stemp);
                    Console.WriteLine(ManyComputers.HowMany(temp));
                }
                catch (Exception)
                {
                    temp = 0;
                    Console.WriteLine("Ошибка, попробуйте еще");
                } 
                
            }
        }
    }
}
