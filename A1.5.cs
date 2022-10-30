using System;

/*  С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период и сколько лет и сколько секунд?*/

namespace Lessons{
    class Program{
        static void Main(){
             int days, weeks, years, sec;
             days = Convert.ToInt32(Console.ReadLine());
             weeks = days / 7;
             years = days / 365;
             sec = days * 24 * 60 * 60;
             Console.WriteLine($"{weeks}, {years}, {sec}");
        }
    }
}