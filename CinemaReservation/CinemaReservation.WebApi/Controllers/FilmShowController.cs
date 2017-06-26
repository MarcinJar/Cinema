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
    public class FilmShowController : ApiController
    {
        private IList<FilmShow> filmShowList = new List<FilmShow>();

        private IFilmShowLogic filmShowLogic;

        public FilmShowController() { }

        public FilmShowController(IFilmShowLogic filmShowLogic)
        {
            this.filmShowLogic = filmShowLogic;
        }

        // GET: /api/FilmShow/
        [HttpGet]
        public IEnumerable<FilmShow> GetAllFilmShows()
        {
            return this.filmShowLogic.GetAll();
        }

        // GET: /api/FilmShow/id
        [HttpGet]
        public FilmShow GetFilmShow(int id)
        {
            return this.filmShowLogic.Get(id);
        }

        // POST: /api/FilmShow/
        [HttpPost]
        public FilmShow AddFilmShow(FilmShow filmShow)
        {
            return this.filmShowLogic.Add(filmShow);
        }

        // PUT: /api/FilmShow/
        [HttpPut]
        public FilmShow UpdateFilmShow(FilmShow filmShow)
        {
            return this.filmShowLogic.Update(filmShow);
        }

        // DELETE: /api/FilmShow/id
        [HttpDelete]
        public bool DeleteFilmShow(int id)
        {
            return this.filmShowLogic.Delete(id);
        }
    }
}
