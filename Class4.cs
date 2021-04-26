using System;
using System.Collections.Generic;
using System.Text;

namespace day3programs
{
    class Class4
    {
        static void Main()
        {
            string str = "it is a bad colour";
            if (str.Contains("ia s"))
            {
                Console.WriteLine("present");
            }
            else
            {
                Console.WriteLine(" not present");
            }
            //string substr = str.Substring(2, 6);
            //Console.WriteLine(substr);
            Console.ReadLine();
        }

    }
}
