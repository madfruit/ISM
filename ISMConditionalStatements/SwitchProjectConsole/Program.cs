using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
           System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("1. Расшифровка дня недели.");
            Console.WriteLine("2. Расшифровка месяца.");
            Console.WriteLine("3. Выполнение операций над числами.");
            Console.WriteLine("4. Выход");
            if (!int.TryParse(Console.ReadLine(), out int i))
            {
                Console.WriteLine("Ошибка выбора!");
            }
            switch (i)
            {
                case 1:
                    Console.WriteLine("Введите число от 1 до 7");
                    if (!int.TryParse(Console.ReadLine(), out int i1))
                    {
                        Console.WriteLine("Ошибка выбора!");
                    }
                    switch (i1)
                    {
                        case 1:
                            Console.WriteLine("Понедельник");
                            break;
                        case 2:
                            Console.WriteLine("Вторник");
                            break;
                        case 3:
                            Console.WriteLine("Среда");
                            break;
                        case 4:
                            Console.WriteLine("Четверг");
                            break;
                        case 5:
                            Console.WriteLine("Пятница");
                            break;
                        case 6:
                            Console.WriteLine("Суббота");
                            break;
                        case 7:
                            Console.WriteLine("Воскресенье");
                            break;
                        default:
                            Console.WriteLine("Такого дня недели не существует");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите число от 1 до 12");
                    if (!int.TryParse(Console.ReadLine(), out int i2))
                    {
                        Console.WriteLine("Ошибка выбора!");
                    }
                    switch (i2)
                    {
                        case 1:
                            Console.WriteLine("Январь");
                            break;
                        case 2:
                            Console.WriteLine("Февраль");
                            break;
                        case 3:
                            Console.WriteLine("Март");
                            break;
                        case 4:
                            Console.WriteLine("Апрель");
                            break;
                        case 5:
                            Console.WriteLine("Май");
                            break;
                        case 6:
                            Console.WriteLine("Июнь");
                            break;
                        case 7:
                            Console.WriteLine("Июль");
                            break;
                        case 8:
                            Console.WriteLine("Август");
                            break;
                        case 9:
                            Console.WriteLine("Сентябрь");
                            break;
                        case 10:
                            Console.WriteLine("Октябрь");
                            break;
                        case 11:
                            Console.WriteLine("Ноябрь");
                            break;
                        case 12:
                            Console.WriteLine("Декабрь");
                            break;
                        default:
                            Console.WriteLine("Такого месяца не существует");
                            break;
                    }
                    break;
                case 3:
                    if (!double.TryParse(Console.ReadLine(), out double a))
                    {
                        Console.WriteLine("Ошибка выбора!");
                    }
                    if (!double.TryParse(Console.ReadLine(), out double b))
                    {
                        Console.WriteLine("Ошибка выбора!");
                    }
                    Console.WriteLine("Выберите действие");
                    Console.WriteLine("1. Сложение");
                    Console.WriteLine("2. Умножение");
                    Console.WriteLine("3. Вычитание");
                    Console.WriteLine("4. Деление");
                    if (!int.TryParse(Console.ReadLine(), out int i3))
                    {
                        Console.WriteLine("Ошибка выбора!");
                    }
                    switch (i3)
                    {
                        case 1:
                            Console.WriteLine(a + b);
                            break;
                        case 2:
                            Console.WriteLine(a*b);
                            break;
                        case 3:
                            Console.WriteLine(a - b);
                            break;
                        case 4:
                            Console.WriteLine(a / b);
                            break;
                        default:
                            Console.WriteLine("Такої операції не існує");
                            break;
                    }
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Такий пункт меню відсутній");
                    break;
            }
            Console.ReadKey();
        }
    }
}
