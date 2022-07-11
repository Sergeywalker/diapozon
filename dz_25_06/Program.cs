using System;
namespace ConsoleApp1
{
    class test
    {
        static void Main(string[] args)
        {

            Console.Write("От: ");
            int ot = int.Parse(Console.ReadLine());
            int while1 = ot;
            Console.Write("До: ");
            int do1 = int.Parse(Console.ReadLine());
            Console.Write(while1);
            while (while1 < do1)
            {
                Console.Write(",");
                while1++;
                Console.Write(while1);
            }
        }
    }
}