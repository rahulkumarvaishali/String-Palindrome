using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any string : ");
            string str = Console.ReadLine();
            int Len = str.Length-1; string str1="";
            for (int i = Len; i >= 0; i--)
            {
                str1=str1 + str[i];
            }
            if (str == str1)
            
                Console.WriteLine("It is Palindrome");
            else
                Console.WriteLine("It is not Palindrome");
            
            
            Console.ReadLine();
        }
    }
}
