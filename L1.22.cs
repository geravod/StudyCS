using System;

/*  Вычислить значение логического выражения при всех возможных значениях логических величин X, Y и Z:
    а) не (Y или не X и Z) или Z;
    б) X и не (не Y или Z) или Y;
    в) не (X или Y и Z) или не X.*/

namespace Lessons{
    class Program{
        static void Main(){
            bool x, y, z, a, b, c;
            x = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            y = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            z = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            a = !(y || !x && z) || z;
            b = x && !(!y || z) || y;
            c = !(x || y && z) || !x;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}