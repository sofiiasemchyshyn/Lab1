using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //тільки для додатніх чисел
            Console.WriteLine("Введiть порядковий номер:");
            int number = int.Parse(Console.ReadLine());
            int[] F = new int[number];
            F[0] = 0; F[1] = 1;
            
            for (int i = 2; i < number; i++)
            {
                F[i] = F[i - 1] + F[i - 2];
            }

            Console.WriteLine( number + " число Фiбоначчi дорівнює " + F[number-1]);
        }
    }
}
