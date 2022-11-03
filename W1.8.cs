using System;

/* W(1.8) Дано число n. Из чисел 1, 4, 9, 16, 25, … напечатать те, которые не превышают n. */

namespace Lessons{
    class Program{
        static void Main(){
            int n, a;
            Console.Write("Введите число n:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите число а:");
            a = int.Parse(Console.ReadLine());
            while (n > Math.Pow(a, 2)){
                Console.WriteLine(Math.Pow(a, 2));
                a++;
            }
        }
    }
}