using System;


namespace Lessons{
    class Program{
        static void Main(){
            string name;
            name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            string sex;
            sex = Console.ReadLine();
            bool withPet;
            withPet = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"{name}, {age}, {sex}, {withPet}");
        }
    }
}