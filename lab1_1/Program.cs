using System;

namespace lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 0;
            double y;
            double A = 0;
            double B = 0;
            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());
            A = 0.1 / x + 4;
            if (x < 1)
            {
                B = 0.65 * x + 8;
            }
            if (1 <= x && x <= 5)
            {
                B = Math.Atan((x + 6.1) / 2 + Math.Exp(x));
            }
            if (x >= 5)
            {
                B = Math.Sqrt(1 + Math.Sqrt(x));
            }
            y = A - B;
            Console.WriteLine("");
            Console.WriteLine($"{Math.Round(y, 2)}");
        }
    }
}
