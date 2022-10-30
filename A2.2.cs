using System;

/* Дано двузначное число. Получить число, образованное при перестановке цифр заданного числа.*/

namespace Lessons{
    class Program{
        static void Main(){
            int x, a, b;
            x = Convert.ToInt32(Console.ReadLine());
            a = x / 10;
            string c = Convert.ToString(a);
            b = x % 10;
            string d = Convert.ToString(b);
            Console.WriteLine(d + c);
        }
    }
}