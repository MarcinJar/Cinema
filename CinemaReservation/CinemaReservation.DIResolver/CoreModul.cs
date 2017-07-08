using CinemaReservation.Core.DataLogic;
using CinemaReservation.Core.DataLogic.IDataLogic;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.DIResolver
{
    public class CoreModul : NinjectModule
    {
        public override void Load()
        {
            Bind<ICinemaLogic>().To<CinemaLogic>();
            Bind<IPersonLogic>().To<PersonLogic>();;
            Bind<IMovieLogic>().To<MovieLogic>();
            Bind<IReservationLogic>().To<ReservationLogic>();
            Bind<IFilmShowLogic>().To<FilmShowLogic>();
        }
    }
}
