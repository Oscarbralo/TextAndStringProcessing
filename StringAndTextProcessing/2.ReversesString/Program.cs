//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas


using System;
using System.Text;
class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }

