using System;

namespace lab3ex3
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar");
            int number = int.Parse(Console.ReadLine());
            PatratPerfect(number);

            static void PatratPerfect(int number)
            {
                if (number < 1)
                {
                    Console.WriteLine("Introduceti un numar mai mare decat 0");
                    return;
                }

                double num = Math.Sqrt(number); 

                if(num == (int)num)
                {
                    Console.WriteLine($"Numarul {number} este patrat perfect");
                }
                else
                {
                    Console.WriteLine($"Numarul {number} nu este patrat perfect");
                }
            }
        }
    }
}
