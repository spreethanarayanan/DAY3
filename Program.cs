using System;

namespace day3
{
    class Class1

    {
        void sum(int a, int b)
        {
            
            Console.WriteLine("sum of integer=" + (a + b));  
        }
        void sum (double a, double b)
        {
            
            Console.WriteLine("sum of float value=" + (a + b));
        }
        static void Main()
        {
            Class1 class1 = new Class1();
            
            
            class1.sum(1,2);
            
            class1.sum(3.1,5.3);
            Console.ReadLine();
        }

    }
}
