using CinemaReservation.DataAccess;
using CinemaReservation.InterfaceDataAccess;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.DIResolver
{
    public class DataAccessModul : NinjectModule
    {
        public override void Load()
        {
            Bind<ICinemaRepository>().To<CinemaRepository>();
            Bind<IPersonRepository>().To<PersonRepository>();
            Bind<IMovieRepository>().To<MovieRepository>();
            Bind<IReservationRepository>().To<ReservationRepository>();
            Bind<IFilmShowRepository>().To<FilmShowRepository>();
        }
    }
}
