using System;

namespace ForConsole1
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
            int s;
            for(s=1;A<=B; A++)
            {
                s = s * A;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
