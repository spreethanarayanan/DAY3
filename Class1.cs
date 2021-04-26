using System;
using System.Collections.Generic;
using System.Text;

namespace day3programs
{

    abstract class employee
    {
        public virtual string VirtualMethod()
        {
            return " hello! i am called from base";
        }
    }

    class Class10 : employee
    {
        public override string VirtualMethod()
        {
            return "heloo i am from derived class";
        }
        public static void Main()
        {
            Class10 class10 = new Class10();
            Console.WriteLine(class10.VirtualMethod());
            Console.ReadLine();
        }
    }
}
   

