using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> favNumbers = new List<int>();
            //favNumbers.Add(7);
            //favNumbers.Add(25);
            //favNumbers.Add(30);

            //foreach(int number in favNumbers)
            //{
            //    //Console.WriteLine(number);
            //}
            ////Use the Count property to get length of the list
            //Console.WriteLine(favNumbers.Count);
            //List<string> books = new List<string> { "Cat in the hat", "Toad and Frog", "Green eggs and ham" };
            //Console.WriteLine(books[0]);
            ////Inserts at the current index moving the previous element down one
            //books.Insert(0, "Horton hears a Who");
            //Console.WriteLine(books[0]);

            ////Create a List and add 5 animals using the .Add()
            ////Print each animal in the list

            ////Crerate the following list:
            ////A bool list{true,false,false,true,false}
            ////Loop through each value
            ////if the value is true print "Better bring an umbrella"
            ////if false print "No rain today, enjoy the sun"

            //List<string> animals = new List<string>();
            //animals.Add("cat");
            //animals.Add("dog");
            //animals.Add("tiger");
            //animals.Add("snake");
            //animals.Add("elephant");

            //foreach(string animalOne in animals)
            //{
            //    Console.WriteLine(animalOne);
            //}
            //List<bool> weather = new List<bool> { true, false, false, true, false };
            //foreach(bool happy in weather)
            //{
            //    if (happy == true)
            //    {
            //        Console.WriteLine("Better be bring an Umbrella!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today enjoy the sun!");
            //    }

            //}

            List<string> favoriteFood = new List<string> { "steak", "fish", "katsudon", "Ice Cream", "Nachos" };
            if (favoriteFood.Contains("fish"))
            {
                Console.WriteLine("I like fish too!");
            }


        }
    }
}
