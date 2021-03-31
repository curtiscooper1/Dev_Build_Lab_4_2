using System;
using System.Collections.Generic;

namespace Lab_4_2
{
    //Creating class of movies that stores title and category of each movie
    //Categories: Animated, drama, horror, WriteLine

    class MovieDatabase
    {
        public string Title;
        public string Category;

        public MovieDatabase(string movietitle, string moviecategory)
        {
            Title = movietitle;
            Category = moviecategory;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string cat = "";
            List<MovieDatabase> movieList = new List<MovieDatabase>();

            movieList.Add(new MovieDatabase("Toy Story", "animated"));
            movieList.Add(new MovieDatabase("WALL-E", "animated"));
            movieList.Add(new MovieDatabase("The Lion King", "animated"));
            movieList.Add(new MovieDatabase("Beavis and Butt-Head Do America", "animated"));
            movieList.Add(new MovieDatabase("Goodfellas", "drama"));
            movieList.Add(new MovieDatabase("The Godfather", "drama"));
            movieList.Add(new MovieDatabase("Casino", "drama"));
            movieList.Add(new MovieDatabase("Taxi Driver", "drama"));
            movieList.Add(new MovieDatabase("Halloween", "horror"));
            movieList.Add(new MovieDatabase("The Texas Chainsaw Massacre", "horror"));
            movieList.Add(new MovieDatabase("House of 1000 Corpses", "horror"));
            movieList.Add(new MovieDatabase("Get Out", "horror"));
            movieList.Add(new MovieDatabase("Ex Machina", "scifi"));
            movieList.Add(new MovieDatabase("Contact", "scifi"));
            movieList.Add(new MovieDatabase("E.T. the Extra-Terrestrial", "scifi"));
            movieList.Add(new MovieDatabase("The Matrix", "scifi"));

            Console.WriteLine("Welcome to the Movie List Application");
            Console.WriteLine();

            bool done = false; //checks if user still wants to continue
            while (!done)
            {
                bool validCat = false; //validates whether user category input is valid
                while (!validCat)
                {
                    Console.Write("Enter a category (Animated, Drama, Horror, SciFi): ");
                    cat = Console.ReadLine().ToLower(); // category input

                    if (cat != "animated" && cat != "drama" && cat != "horror" && cat != "scifi")
                    {
                        Console.WriteLine("That is not a category in the Movie List. Enter: (Animated, Drama, Horror, WriteLine).");
                        Console.WriteLine();
                    }
                    else
                    {
                        validCat = true;
                    }
                }

                //prints message of title and category that matches user category input
                foreach (MovieDatabase film in movieList)
                {
                    if (film.Category == cat)
                    {

                        Console.WriteLine($"{film.Title} is in the {film.Category} category");
                    }
                }

                //checks if the user entered a valid input to continue
                bool validResp = false;
                while (!validResp)
                {
                    Console.Write("Continue? (y/n): ");
                    string resp = Console.ReadLine().ToLower(); //continue input

                    if (resp != "n" && resp != "y")
                    {
                        Console.WriteLine("Not a valid option, enter y or n");
                    }
                    else if (resp == "y") // continues in !done loop if they want to continue
                    {
                        validResp = true;
                        done = false;
                    }
                    else //exits the program if "n" is entered
                    {
                        validResp = true;
                        done = true;
                    }
                }
            }
        }
    }
}



























