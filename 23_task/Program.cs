using System;
using System.Threading;
using System.Threading.Tasks;

namespace _23_task
{
    class Program
    {
        static int Factorial(int f)
        {
            Console.WriteLine("Factorial начал работу");
            int F = 1
                ;
            for (int i = 1; i <= f; i++)
            {
                F *= i;
                Thread.Sleep(100);
            }
            Console.WriteLine("Factorial окончил работу");
            return F;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для факторила: ");
            int f = Convert.ToInt32(Console.ReadLine());

            int factor_async = FactorialAsync(f).Result;
            Console.WriteLine($"Факториал числа {f} = {factor_async}");
            Console.WriteLine();

            int factor_main = Factorial(f);
            Console.WriteLine($"Факториал числа {f} = {factor_main}");
            Console.WriteLine($"Main окончил работу");
            Console.ReadKey();

        }

        static async Task<int> FactorialAsync(int f)
        {
            Console.WriteLine("FactorialAsync начал работу");
            int result = await Task.Run(() => Factorial(f));
            Console.WriteLine("FactorialAsync окончил работу");
            return result;
        }
    }
}
