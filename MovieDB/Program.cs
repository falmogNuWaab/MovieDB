using System;

namespace MovieDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to my Movie Database");
            //Console.WriteLine("Please start by selecting a category: Animation, Drama, Horror, SciFi");
            //string catSelected = Console.ReadLine();
            bool dbLoop = true;

            MovieDatabase movieDb = new MovieDatabase();
            while (dbLoop)
            {
                movieDb.GetStarted();
                dbLoop = KeepLooping();
            }
            
        }
        public static bool KeepLooping()
        {
            Console.WriteLine("\nWould you like to continue?(y/n) ");
            string response = Console.ReadLine();

            if(response == "y")
            {
                return true;
            }
            else if(response == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that");
                return KeepLooping();
            }
        }
    }
}
