using CinemaReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CinemaReservation.Controllers
{
    public class MovieController : ApiController
    {
        private IList<Movie> listOfMovies = new List<Movie>();

        public MovieController() { }

        public MovieController( IList<Movie> movies)
        {
            this.listOfMovies = movies;
        }

        // GET: /api/Movie/
        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            return listOfMovies;
        }

        // GET: /api/Movie/id
        [HttpGet]
        public Movie GetMovieById(int id)
        {
            return listOfMovies.Where(x => x.DBKey == id).FirstOrDefault();
        }

        // PUT: /api/Movie/
        [HttpPut]
        public Movie UpdateMovie(Movie movie)
        {
            Movie mov = listOfMovies.Where(x => x.DBKey == movie.DBKey).FirstOrDefault();
            mov.Name = movie.Name;

            return mov;
        }

        // POST: /api/Movie/
        [HttpPost]
        public int AddMovie(Movie movie)
        {
            listOfMovies.Add(movie);

            return listOfMovies.Count();
        }

        // DELETE: /api/Movie/id
        [HttpDelete]
        public int DeleteMovie(int id)
        {
            listOfMovies.Remove(listOfMovies.Where(x => x.DBKey == id).FirstOrDefault());

            return listOfMovies.Count();
        }
    }
}
