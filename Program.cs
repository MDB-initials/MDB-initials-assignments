using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign3
{

    public class passerby {
        public string social { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string address { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<passerby> ptlist = new List<passerby>();
            //template
            passerby p1 = new passerby();
            p1.social = "078-05-1120";
            p1.name = "Groby Manhandler";
            p1.number = "342-943-9433";
            p1.address = "428 Burwell Heights Road";
            ptlist.Add(p1);
            //end template
            passerby p2 = new passerby();
            p2.social = "458-15-1980";
            p2.name = "Meg Sandbag";
            p2.number = "232-743-2303";
            p2.address = "2324 Center Street";
            ptlist.Add(p2);
            passerby p3 = new passerby();
            p3.social = "212-68-5866";
            p3.name = "Spug Yeller";
            p3.number = "240-281-1856";
            p3.address = "2977 Wilmar Farm Road";
            ptlist.Add(p3);
            passerby p4 = new passerby();
            p4.social = "644-09-1896";
            p4.name = "Ting Wallabang";
            p4.number = "903-585-9394";
            p4.address = "864 Thrash Trail";
            ptlist.Add(p4);
            string input2;
            int counter;



            Console.WriteLine("are you trying to find somone based off 'social' 'name' 'number' or 'address'?");
            string input1 = Console.ReadLine().ToLower();

            switch (input1)
            {
                case "social":
                    Console.WriteLine("input the person's social security number including '-'s");
                    input2 = Console.ReadLine().ToLower();
                    counter = ptlist.Capacity;
                    foreach (passerby item in ptlist)
                    {
                        counter--;
                        if (item.social == input2)
                        {
                            Console.WriteLine(item.social);
                            Console.WriteLine(item.name);
                            Console.WriteLine(item.number);
                            Console.WriteLine(item.address);
                            counter++;
                        } else if (counter == 0)
                        {
                            Console.WriteLine("that social security number was not found");
                        }
                        System.Threading.Thread.Sleep(1000);
                    }
                    break;
                case "name":
                    Console.WriteLine("input the person's name");
                    input2 = Console.ReadLine().ToLower();
                    counter = ptlist.Capacity;
                    foreach (passerby item in ptlist)
                    {
                        counter--;
                        if (item.name.ToLower() == input2)
                        {
                            Console.WriteLine(item.social);
                            Console.WriteLine(item.name);
                            Console.WriteLine(item.number);
                            Console.WriteLine(item.address);
                            counter++;
                        }
                        else if (counter == 0)
                        {
                            Console.WriteLine("that name was not found");
                        }
                        System.Threading.Thread.Sleep(1000);
                    }
                    break;
                case "number":
                    Console.WriteLine("input the person's phone number including '-'s");
                    input2 = Console.ReadLine().ToLower();
                    counter = ptlist.Capacity;
                    foreach (passerby item in ptlist)
                    {
                        counter--;
                        if (item.number == input2)
                        {
                            Console.WriteLine(item.social);
                            Console.WriteLine(item.name);
                            Console.WriteLine(item.number);
                            Console.WriteLine(item.address);
                            counter++;
                        }
                        else if (counter == 0)
                        {
                            Console.WriteLine("that phone number was not found");
                        }
                        System.Threading.Thread.Sleep(1000);
                    }
                    break;
                case "address":
                    Console.WriteLine("input the person's address");
                    input2 = Console.ReadLine().ToLower();
                    counter = ptlist.Capacity;
                    foreach (passerby item in ptlist)
                    {
                        counter--;
                        if (item.address.ToLower() == input2)
                        {
                            Console.WriteLine(item.social);
                            Console.WriteLine(item.name);
                            Console.WriteLine(item.number);
                            Console.WriteLine(item.address);
                            counter++;
                        }
                        else if (counter == 0)
                        {
                            Console.WriteLine("that address was not found");
                        }
                        System.Threading.Thread.Sleep(1000);
                    }
                    break;
                default:
                    Console.WriteLine("one of the terms 'social' 'name' 'number' or 'address' was not inputed");
                    break;
            }

        }
    }
}
