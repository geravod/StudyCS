using System;

/*  С начала суток прошло n секунд. Определить:
    а) сколько полных часов прошло с начала суток;
    б) сколько полных минут прошло с начала очередного часа;
    в) сколько полных секунд прошло с начала очередной минуты.*/

namespace Lessons{
    class Program{
        static void Main(){
             int n, a, b, c;
             n = Convert.ToInt32(Console.ReadLine());
             a = n / 60 / 60 % 24;
             b = n / 60 % 60;
             c = n % 60;
             Console.WriteLine($"{a}, {b}, {c}");
        }
    }
}