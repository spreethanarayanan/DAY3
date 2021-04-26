using System;
using System.Collections.Generic;
using System.Text;

namespace day3programs
{
    class Class5
    {
        static void Main()
        {
            string a = "My name is Preetha S";
            char[] arr = a.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLower(arr[i]))
                {
                    Console.Write(char.ToUpper(arr[i]));
                }
                else 
                {
                    Console.Write(char.ToLower(arr[i]));
                }
                Console.ReadLine();
            }


        }
    }
}
