using System;


namespace Lessons{
    class Program{
        static void Main(){
            /* Дано двузначное число. Найти:
            а) число десятков в нем;
            б) число единиц в нем;
            в) сумму его цифр;
            г) произведение его цифр. */
            int a, b, c, d, x;
            x = Convert.ToInt32(Console.ReadLine());
            a = x / 10;
            b = x % 10;
            c = x % 10 + x / 10;
            d = x % 10 * (x / 10);
            Console.WriteLine($"{a}, {b}, {c} ,{d}");
        }
    }
}