using System;

/* y = x^{1.5}-5cos2x+e^{-2x} */

namespace Lessons{
    class Program{
        static void Main(){
            double a, b, s, height;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());
            s = 0;
            double count = a;
            double widht = (b - a) / limit;
            while (count < b)
            {
                count += widht;
                height = Math.Pow(count, 1.5) - 5 * Math.Cos(2 * count) + Math.Exp(-2 * count);
                s += widht * height;
            }
            Console.WriteLine($"решением определенного интеграла является {s}");
        }
    }
}