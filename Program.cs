using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign1
{
    class Program
    {
        //1
        /* static void Main(string[] args)
       {
           Console.WriteLine("Type 'dotnet':");
           string input = Console.ReadLine();
           if (input == "dotnet") {
           Console.WriteLine("you wrote " + input);
       } else
           {
               Console.WriteLine("please follow instructions");
           }
       }
       System.Threading.Thread.Sleep(1000);*/

        //2
        static void Main(string[] args)
        {
            string a = "never trust";
            string b = "a plastic";
            string c = "hippo";
            Console.WriteLine(a + " " + b + " " + c);
            Console.WriteLine($"{a} {b} {c}");
            System.Threading.Thread.Sleep(1000);
        }

        //3
        /*static void Main(string[] args)
        {
            int a = 11;
            int b = 3;
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            System.Threading.Thread.Sleep(1000);
        }*/
    }
}
