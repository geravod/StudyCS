using System;

/*Составить программу: вычисления значения функции y=7x2+3x+6 при любом значении x.*/

namespace Lessons{
    class Program{
        static void Main(){
            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = 7*x*x + 3*x + 6;
            Console.WriteLine(y);
        }
    }
}