using System;

/*  Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него?*/

namespace Lessons{
    class Program{
        static void Main(){
             int a, b, ab;
             a = Convert.ToInt32(Console.ReadLine());
             b = Convert.ToInt32(Console.ReadLine());
             ab = Convert.ToInt32(Console.ReadLine());
             string c = Convert.ToString(a * b / (ab * ab));
             Console.WriteLine(c);
        }
    }
}