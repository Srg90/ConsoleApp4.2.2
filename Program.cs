using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое количество чисел");
            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int kp = 0, a;
            int ko = 0;
            int n1 = 0;
            Console.WriteLine();


            do
            {
                Console.Write("Введите число - ");
                a = Convert.ToInt32(Console.ReadLine());
                n1++;
                if (a > 0)
                    kp += i;
                if (a < 0)
                    ko += i;

            } while (n1 < n);

            Console.WriteLine();
            Console.WriteLine("Количество положительных чисел = " + kp);
            Console.WriteLine();
            Console.WriteLine("Количество отрицательных чисел = " + ko);
            Console.WriteLine();
            if (kp > ko)
            {
                Console.WriteLine("Количество положительных чисел больше чем отрицательных");
            }
            if (kp < ko)
            {
                Console.WriteLine("Количество отрицательных чисел больше чем положительных");
            }
            if (kp == ko)
            {
                Console.WriteLine("Количество положительных чисел равно количеству отрицательных");
            }
            Console.ReadKey();


        }
    }
}

        
    

