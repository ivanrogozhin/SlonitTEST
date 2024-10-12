using System;
using SlonitTEST.Components;
using SlonitTEST.Util;
// 1 Много комьютера - 27 минут
// 2 Общий делитель массива чисел - 35
// 3 Простые числа в диапазоне - 20 минут
// 4 Таблица умножения - 45 минут
namespace SlonitTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = string.Empty;
                Console.WriteLine("1 - Склонение слова 'компьютер'");
                Console.WriteLine("2 - Общий делитель массива чисел");
                Console.WriteLine("3 - Простые числа в диапазоне");
                Console.WriteLine("4 - Таблица умножения");
                command = Console.ReadLine();
                Console.WriteLine();
                int[] arr;
                int[] arr2;
                string str;
                int tInt, tInt2;
                switch (command)
                {
                    case "1":
                        Console.Write("Введите число копьютеров: ");
                        tInt = GetIntFromConsole();
                        Console.WriteLine("У вас получилось '" + ManyComputers.HowMany(tInt)+"'");
                        break;
                    case "2":
                        Console.Write("Введите массив чисел через пробел: ");
                        str = Console.ReadLine();
                        arr = Formating.StringToIntArray(str);
                        arr2 = CommonDivisors.GetComDiv(arr);
                        
                        Console.WriteLine("Введеный массив чисел: "+Formating.ArrayToString(arr));
                        Console.WriteLine("Общие делители массива чисел: " +Formating.ArrayToString(arr2));
                        break;
                    case "3":
                        Console.Write("Введите начальное число диапазона: ");
                        tInt = GetIntFromConsole();
                        Console.Write("Введите конечное число диапазона: ");
                        tInt2 = GetIntFromConsole();
                        arr = PrimeNumbers.GetArray(tInt, tInt2);
                        str = Formating.ArrayToString(arr);
                        Console.WriteLine(str);
                        break;
                    case "4":
                        Console.Write("Введите до какого числа расписать таблицу умножения: ");
                        tInt = GetIntFromConsole();
                        try
                        {
                            MultiTable mTable = new MultiTable(tInt);
                            mTable.ShowInConsole();
                        }
                        catch 
                        {
                            Console.WriteLine("Ошибка, невозможно создать таблицу умножения");
                        }

                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите 'Enter' для продолжения...");
                Console.ReadLine();
                
                Console.Clear();
            }

            static int GetIntFromConsole()
            {
                int tInt;
                try
                {
                    tInt = Int32.Parse(Console.ReadLine());
                }
                catch 
                {
                    tInt = 0;
                    Console.Write("Ошибка, введите число: ");
                    tInt = GetIntFromConsole();
                }
                return tInt;
            }

        }
    }
}
