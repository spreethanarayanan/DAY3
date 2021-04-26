using System;
using System.Collections.Generic;
using System.Text;

namespace day3programs
{
    interface I1
    {
        void myMethod();
    }
    interface I2
    {
        void myMethod();
    }
    class MultipleInheritance:I1,I2
    {
        void I1. myMethod()
        {
            Console.WriteLine(" INTERFACE 1");
        }
        void I2.myMethod()
        {
            Console.WriteLine(" INTERFACE 2");

        }
    }
    public class Client
    {
        public static void Main()
        {
            MultipleInheritance Obj1=new MultipleInheritance();
            I1 Interface1 = Obj1;
            Interface1.myMethod();
            I2 Interface2 = Obj1;
            Interface2.myMethod();
            Console.ReadLine();

        }
    }
}
