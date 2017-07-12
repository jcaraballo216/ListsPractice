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

            //List<string> favoriteFood = new List<string> { "steak", "fish", "katsudon", "Ice Cream", "Nachos" };
            //if (favoriteFood.Contains("fish"))
            //{
            //    Console.WriteLine("I like fish too!"); 
            //}

            //Create a list with the following numbers: 1 23 9 77 922 6 32 63 14 5
            //use the contains method with the following values: 23 77 15
            //Remove these elements: 23 77 32 and 6
            //use contains() again on these values:23 77 15

            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(23);
            //numbers.Add(9);
            //numbers.Add(77);
            //numbers.Add(922);
            //numbers.Add(6);
            //numbers.Add(32);
            //numbers.Add(63);
            //numbers.Add(14);
            //numbers.Add(5);
            //if (numbers.Contains(23))
            //{
            //    Console.WriteLine("Thats contained");
            //}
            //if (numbers.Contains(77))
            //{
            //    Console.WriteLine("Thats contained");
            //}
            //if (numbers.Contains(15))
            //{
            //    Console.WriteLine("Thats contained");
            //}
            //else
            //{
            //    Console.WriteLine("Not Contained");
            //}
            //if (numbers.Remove(23))
            //{
            //    Console.WriteLine("removed");
            //}
            //if (numbers.Remove(77))
            //{
            //    Console.WriteLine("removed");
            //}
            //if (numbers.Remove(32))
            //{
            //    Console.WriteLine("removed");
            //}
            //if (numbers.Remove(6))
            //{
            //    Console.WriteLine("removed");
            //}

            // Ask the user for a movie 
            //if the movie is in the list inform them that the movie is on the way
            //If the movie is not in the list add it
            //inform the user that the movie has been added
            //if the user enters quit the program should exit
            //the user should be able to add as many movies as they want

            List<string> movies = new List<string> { "dead pool", "anchor man", "tmnt", "spider man" };
            Console.WriteLine("Welcome to Movie Finder!");
            Console.WriteLine("You may enter \"Quit\" at any time");
            string favMovie;
            do
            {
                Console.WriteLine("Please enter a Movie!");
                favMovie = Console.ReadLine().ToLower();
                
                if (favMovie.ToLower() == "quit")
                {
                    Console.WriteLine("Thank you for using Movie Finder!");
                }
                else if (movies.Contains(favMovie))
                {
                    Console.WriteLine("Your movie is on its way!");
                }
                else
                {
                    Console.WriteLine("That movie is not on the list and will be added.");
                    movies.Add(favMovie);
                }

            }
            while (favMovie.ToLower() != "quit");
                       
            Console.WriteLine("Here is a list of the movies in your collection");
            foreach (string moreMovies in movies)
            {
                Console.WriteLine(moreMovies);
            }
           
               
            }
        }
    }
