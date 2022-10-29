using System;

/*S1.8. Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.*/

namespace Lessons{
    class Program{
        static void Main(){
            int a, b, c, d;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} {b} {c} {d}");



        }
    }
}