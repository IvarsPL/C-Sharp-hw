using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _moviesList;
        public VideoStore()
        {
            _moviesList = new List<Video>();
        }

        public void AddVideo(string title)
        {
            _moviesList.Add(new Video(title));
        }

        public void Checkout(string title)
        {
            var movie = FindAMovieByTitle(title);
            movie?.BeingCheckedOut();
              
        }

        public void ReturnVideo(string title)
        {
            var movie = FindAMovieByTitle(title);
            movie?.BeingReturned();
        }

        public void TakeUsersRating(double rating, string title)
        {
            var movie= FindAMovieByTitle(title);
                    movie.ReceivingRating(rating);
        }

        public void ListInventory()
        {
            foreach (var movie in _moviesList)
            {
                Console.WriteLine(movie);
            }
        }

        private Video FindAMovieByTitle(string title)
        {
            foreach (var movie in _moviesList)
            {
                if (movie.Title != title) continue;
                {
                    return movie;
                }
            }
            return null;
        }
    }
}
