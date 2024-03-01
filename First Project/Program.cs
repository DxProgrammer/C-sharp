using System;

namespace Hello
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number : ");
            String a = Console.ReadLine();
            Console.WriteLine("entert the second number :  ");
            String b = Console.ReadLine();
            int c = int.Parse(a) + int.Parse(b);
            Console.WriteLine("sum of two number :"+c);
            Console.ReadLine();
        }
    }
}