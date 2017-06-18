using CinemaReservation.Core.DataLogic.IDataLogic;
using CinemaReservation.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CinemaReservation.WebApi.Controllers
{
    public class MovieController : ApiController
    {
        private IList<Movie> movieList = new List<Movie>();

        private IMovieLogic movieLogic;

        public MovieController() { }

        public MovieController(IMovieLogic movieLogic)
        {
            this.movieLogic = movieLogic;
        }

        // GET: /api/Movie/
        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            movieList = this.movieLogic.GetAll().ToList();
            return movieList;
        }

        // GET: /api/Movie/id
        [HttpGet]
        public Movie GetMovieById(int id)
        {
            return this.movieLogic.Get(id);
        }

        // PUT: /api/Movie/
        [HttpPut]
        public Movie UpdateMovie(Movie movie)
        {
            return this.movieLogic.Update(movie);
        }

        // POST: /api/Movie/
        [HttpPost]
        public Movie AddMovie(Movie movie)
        {
            return this.movieLogic.Add(movie);
        }

        // DELETE: /api/Movie/id
        [HttpDelete]
        public bool DeleteMovie(int id)
        {
            return this.movieLogic.Delete(id);
        }
    }
}
