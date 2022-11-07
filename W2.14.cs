using System;

/* W2.14. Найти 15 первых натуральных чисел, делящихся нацело на 19 и находящихся в интервале, левая граница которого равна 100. */

namespace Lessons{
    class Program{
        static void Main(){
            int a, q;
            a = 0;
            q = 100;
            while(a < 15){
                q++;
                if(q % 19 == 0){
                    Console.WriteLine(q);
                    a++;
                }
            }
        }
    }
}