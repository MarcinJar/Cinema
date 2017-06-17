using CinemaReservation.Core.DataLogic.IDataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaReservation.Model.Models;
using CinemaReservation.InterfaceDataAccess;

namespace CinemaReservation.Core.DataLogic
{
    public class MovieLogic : IMovieLogic
    {
        private IMovieRepository movieRepository;

        public MovieLogic(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public Movie Add(Movie movieToCreate)
        {
            return this.movieRepository.Add(movieToCreate);
        }

        public bool Delete(int movieDBKey)
        {
            return this.movieRepository.Delete(movieDBKey);
        }

        public Movie Get(int movieDBKey)
        {
            return this.movieRepository.Get(movieDBKey);
        }

        public IEnumerable<Movie> GetAll()
        {
            return this.movieRepository.GetAll();
        }

        public Movie Update(Movie movieToUpdate)
        {
            return this.movieRepository.Update(movieToUpdate);
        }
    }
}
