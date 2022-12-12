using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. Найти среднее значение чѐтных элементов заданного массива Х[1..15]. */

namespace Lab_4_2_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив и заполняем его случаными числами и выводим в консоль.
            int[] X = new int[15];
            Random r = new Random();
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = r.Next(-50, 50);
                Console.Write(X[i] + " ");
            }
            Console.WriteLine("\n");

            // Находим среднее значение четных элементов.
            double sum = 0;
            int count = 0;
            for (int i = 0; i < X.Length; i++)            
                if (X[i] % 2 == 0)
                {
                    sum += X[i];
                    count++;
                }
            double sred = sum / count;
            Console.WriteLine($"Среднее значение четных элементов = {sred}");

            // Linq
            Console.WriteLine($"Среднее значение четных элементов = " +
                $"{X.Where(x => x % 2 == 0).Average()}");

            Console.ReadKey();
        }
    }
}
