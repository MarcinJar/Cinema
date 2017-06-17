using CinemaReservation.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Core.DataLogic.IDataLogic
{
    public interface IMovieLogic
    {
        Movie Get(int movieDBKey);

        IEnumerable<Movie> GetAll();

        Movie Add(Movie movieToCreate);

        Movie Update(Movie movieToUpdate);

        bool Delete(int movieDBKey);
    }
}
