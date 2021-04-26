using System;
using System.Collections.Generic;
using System.Text;

namespace day3programs
{
    class Class6
    {
        static void Main()
        {
            Console.WriteLine("input string");
                String a = Console.ReadLine();
            string result = string.Empty;
            char[] arr = a.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if(!result.Contains(arr[i]))
                {
                    result += arr[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
