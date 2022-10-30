using System;

/*Дана сторона квадрата. Найти его периметр.*/

namespace Lessons{
    class Program{
        static void Main(){
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(4 * x);
        }
    }
}