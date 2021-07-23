using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_4
{
    class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public Movie[] GetPG(Movie[] movies)
        {
            List<Movie> newMovies = new List<Movie>();
            for (var i = 0; i < movies.Length; i++)
            {
                if (movies[i]._rating == "PG")
                {
                    newMovies.Add(movies[i]);
                }
            }

            Movie[] newMoviesArray = new Movie[newMovies.Count];
            for (int i = 0; i < newMovies.Count; i++)
            {
                newMoviesArray[i] = newMovies[i];
            }
            return newMoviesArray;
        }
    }
}
