using System;
using static System.Math;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, Input x coordinate for A");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, Input y coordinate for A");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, Input x coordinate for B");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, Input y coordinate for B");
            double y2 = double.Parse(Console.ReadLine());

            double x3 = 1, y3 = 0;          //точка Х на прямій ОХ

            double cosOA = (x1 * x3 + y1 * y3) / Sqrt((Pow(x1, 2) + Pow(x3, 2)) * (Pow(y1, 2) + Pow(y3, 2)));   
            double angleOA = Acos(cosOA) * 57.2958;       //кут між ОА і ОХ

            double cosOB = (x2 * x3 + y2 * y3) / Sqrt((Pow(x2, 2) + Pow(x3, 2)) * (Pow(y2, 2) + Pow(y3, 2)));
            double angleOB = Acos(cosOB) * 57.2958;       //кут між ОВ і ОХ

            if (angleOA > angleOB)
            {
                Console.WriteLine("OA angle with OX is bigger and equal " + Round(angleOB, 2));
            }
            else if (angleOB > angleOA)
            {
                Console.WriteLine("OB angle with OX is bigger and equal " + Round(angleOB, 2));
            }
            else Console.WriteLine("Both angles are same");


        }
    }
}
