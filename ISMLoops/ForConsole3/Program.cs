using System;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!double.TryParse(Console.ReadLine(), out double A))
            {
                Console.WriteLine("Ошибка ввода!");
            }
            if (!int.TryParse(Console.ReadLine(), out int N))
            {
                Console.WriteLine("Ошибка ввода!");
            }
            double s = 1.0;
            for (int i= 1; i <= N; i++)
                {
                    s = s * A;
                }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
