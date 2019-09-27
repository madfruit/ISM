using System;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!int.TryParse(Console.ReadLine(), out int N))
            {
                Console.WriteLine("Ошибка ввода!");
            }
            int i;
            double s = 0;
            for(i=1;i<=N;i++)
            {
                s=s+1.0/i;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
