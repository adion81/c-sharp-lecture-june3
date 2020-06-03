using System;
using System.Collections.Generic;
using LectureDayThree.Models;

namespace LectureDayThree
{
    class Program
    {

        static void BoxingDemo()
        {
            List<object> Banana = new List<object>();
            Banana.Add(5);
            Banana.Add(25);
            Banana.Add(-8);
            Banana.Add(10);
            Banana.Add(-9);
            Banana.Add("Will");
            Banana.Add(true);

            int sum = 0;
            foreach(object b in Banana)
            {
                if(b is int)
                {
                    sum += (int)b;
                }
                if(b is bool)
                {
                    Console.WriteLine("We have a bool here!!!");
                }
            }
            Console.WriteLine(sum);
        }


        static List<string> GreaterThanNum(List<string> Names, int MinLength)
        {
            for(int i = 0; i < Names.Count; i++)
            {
                if(Names[i].Length < MinLength)
                {
                    Names.RemoveAt(i);
                    i--;
                }
            }
            return Names;
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BoxingDemo();
            Dinosaur Benny = new Dinosaur("Benny Bob","Apatosaurus",200,false);
            Benny.Birthday().Birthday().Birthday();

            Bird Larry =  new Bird("Larry","Swallow",2,true);
            Larry.Birthday().Birthday();

            List<string> names = new List<string>
            {
                "William",
                "Betty",
                "Adrien",
                "Sam",
                "Rob"
            };
            GreaterThanNum(names,4);
            System.Console.WriteLine(String.Join(", ", names));
        }
    }
}
