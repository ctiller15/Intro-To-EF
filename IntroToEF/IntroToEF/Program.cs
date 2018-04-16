using System;
using System.Collections.Generic;
using System.Linq;
using IntroToEF.Data;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Query DB.
            var dbContext = new DataContext();

            // INSERT
            var movie1 = new IntroToEfMovies
            {
                Title = "Die Hard",
                YearReleased = 1988,
                Genre = "Action",
                Tagline = "Time to Die Hard",
                Rating = 1000
            };

            var movie2 = new IntroToEfMovies
            {
                Title = "The Neverending Story",
                YearReleased = 1987,
                Genre = "Fantasy",
                Tagline = "It never ends!",
                Rating = 7
            };

            var movie3 = new IntroToEfMovies
            {
                Title = "Horifying horror movie",
                YearReleased = 2011,
                Genre = "Horror",
                Tagline = "You will scream!",
                Rating = 10
            };

            dbContext.EFMovies.Add(movie1);
            dbContext.EFMovies.Add(movie2);
            dbContext.EFMovies.Add(movie3);

            dbContext.SaveChanges();


            // SELECT

            var horror = dbContext.EFMovies.Where(movie => movie.Genre == "Horror");

            foreach(var movie in horror)
            {
                Console.WriteLine(movie.Title);
            }
            Console.ReadLine();

            // Update
            var oldmovies = dbContext.EFMovies.Where(movie => movie.YearReleased == 1988);
            //oldmovies.Rating = 10;

            foreach(var movie in oldmovies)
            {
                movie.Rating = 10;
            }

            // save all movies.
            dbContext.SaveChanges();

            var neverEndingStories = dbContext.EFMovies.Where(movie => movie.Title == "The Neverending Story");
            
            foreach(var story in neverEndingStories)
            {
                dbContext.EFMovies.Remove(story);
            }

            dbContext.SaveChanges();

        }
    }
}
