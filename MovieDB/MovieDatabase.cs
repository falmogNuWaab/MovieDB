using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDB
{
    class MovieDatabase
    {
        public List<Movie> MovieDB { get; set; } = new List<Movie>();

        public MovieDatabase()
        {
            MovieDB.Add(new Movie("Off the Map", "Drama"));
            MovieDB.Add(new Movie("Final: The Rapture", "Horror"));
            MovieDB.Add(new Movie("Hang Loose", "Drama"));
            MovieDB.Add(new Movie("Ice Age", "Animation"));
            MovieDB.Add(new Movie("Paw Patrol", "Animation"));
            MovieDB.Add(new Movie("Tokyo Gore Police", "SciFi"));
            MovieDB.Add(new Movie("Guardians of the Galaxy", "SciFi"));
            MovieDB.Add(new Movie("The Conjuring", "Horror"));
            MovieDB.Add(new Movie("Children of the Corn", "Horror"));
            MovieDB.Add(new Movie("Scarlet Bamboo", "Horror"));

           // MovieDB.Sort();
        }
        public string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string response = Console.ReadLine();

            return response;
        }

        public void GetStarted()
        {
            string pickCategory = GetUserInput("Please start by selecting a category from this menu: \n1: Animation \n2: Drama\n3: Horror\n4: SciFi");
            pickCategory = pickCategory.ToLower();
            if(pickCategory == "animation" || pickCategory == "drama" || pickCategory == "horror" || pickCategory == "scifi"){
                PrintMovieDB(pickCategory);
            } 
            else if(pickCategory == "1")
            {                
                PrintMovieDB("animation");
            } 
            else if(pickCategory == "2")
            {
                PrintMovieDB("drama");
            } 
            else if(pickCategory == "3")
            {
                PrintMovieDB("horror");
            } 
            else if(pickCategory == "4")
            {
                PrintMovieDB("scifi");
            }
            else
            {
                Console.WriteLine("I apologize, I didn't understand that. Please try again");
                GetStarted();
            }

        }
        public void PrintMovieDB(string input)
        {
           
            for (int i = 0; i < MovieDB.Count; i++)
            {
                Movie Film = MovieDB[i];
                if (input.ToLower() == Film.Category.ToLower())
                {
                    Console.WriteLine(Film.Title);
                }
                //Console.WriteLine($"{i} : {Film.Title} , {Film.Category}");
            }
        }
    }
}
