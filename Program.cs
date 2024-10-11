using System;
//
//
//
// 4 Таблица умножения - 45 минут
namespace SlonitTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MultiTable mTable = new MultiTable(45);
            mTable.ShowInConsole();
        }
    }
}
