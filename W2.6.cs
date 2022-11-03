using System;

/* W(2.6) Дано натуральное число.
         а) Определить его максимальную цифру.
         б) Определить его минимальную цифру. */

namespace Lessons{
    class Program{
        static void Main(){
        int min, max, a, b;
        Console.Write("Введите число два раза:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        max = a % 10;
        min = b % 10;
        a /= 10;
        b /= 10;
        while(a > 0){
            if (a % 10 > max){
                max = a % 10;
            }
            a /= 10;
        }
        while (b > 0){
            if (b % 10 < min){
                min = b % 10;
            }
            b /= 10;
        }
        Console.Write("Минимальная цифра:");
        Console.WriteLine(min);
        Console.Write("Максимальная цифра:");
        Console.WriteLine(max);
        }
    }
}