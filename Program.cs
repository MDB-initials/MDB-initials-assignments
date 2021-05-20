using System;

namespace assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            /*Console.WriteLine("Enter one of the following cities:");
            Console.WriteLine("Columbus, Wheeling, Washington, Rochester");

            string cityName = Console.ReadLine();

            switch (cityName)
            {
                case "Columbus":
                    Console.WriteLine("welcome to Columbus!");
                    break;
                case "Wheeling":
                    Console.WriteLine("welcome to Wheeling!");
                    break;
                case "Washington":
                    Console.WriteLine("welcome to Washington!");
                    break;
                case "Rochester":
                    Console.WriteLine("welcome to Rochester!");
                    break;
                default:
                    Console.WriteLine("please follow instructions");
                    break;
            }
            System.Threading.Thread.Sleep(1000);*/

            //2
            /*int[] array = new int[5] { 1,2,3,4,5};
            foreach (int elements in array)
            {
                Console.Write(elements);
            }
            System.Threading.Thread.Sleep(1000);*/

            //3
            int counter = 1;
            int[] arrayFib = new int[2] { 0, 1 };
            int print = 0;
            Console.WriteLine(0);
            System.Threading.Thread.Sleep(1000);
            while (counter < 12)
            {
                foreach (int elements in arrayFib)
                {
                    if (counter % 2 == 0)
                    {
                        print = elements + Convert.ToInt32(arrayFib[0]);
                        arrayFib[0] = print;
                        Console.WriteLine(print);
                        counter++;
                        //Console.WriteLine("       " + arrayFib[0] + " fib " + arrayFib[1]);
                        System.Threading.Thread.Sleep(1000);
                    }
                    else
                    {
                        print = elements + Convert.ToInt32(arrayFib[1]);
                        arrayFib[1] = print;
                        Console.WriteLine(print);
                        counter++;
                        //Console.WriteLine("       " + arrayFib[0] + " fib " + arrayFib[1]);
                        System.Threading.Thread.Sleep(1000);

                    }

                }
            }
        }
    }
}
