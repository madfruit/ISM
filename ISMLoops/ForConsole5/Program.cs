using System;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {

            if (!int.TryParse(Console.ReadLine(), out int N))
            {
                Console.WriteLine("Ошибка ввода!");
            }
            int s = 1;
            for (int i = 1; i <= N; i++)
            {
                s = s * i;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
