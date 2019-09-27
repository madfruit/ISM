using System;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!int.TryParse(Console.ReadLine(), out int A))
            {
                Console.WriteLine("Ошибка ввода!");
            }
            if (!int.TryParse(Console.ReadLine(), out int B))
            {
                Console.WriteLine("Ошибка ввода!");
            }
            int s = 0;
            for(int i =A;i<=B;i++)
            {
                s = s + i * i;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
