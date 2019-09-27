using System;

namespace ForConsole6
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!int.TryParse(Console.ReadLine(), out int N))
            {
                Console.WriteLine("Ошибка ввода!");
            }
            double s = 0;
            for(double i=1; i<=N; i++, N--)
            {
                s = s + Math.Pow(i, N);
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
