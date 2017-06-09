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

        public FilmShowController() { }

        public FilmShowController(IList<FilmShow> filmShowList)
        {
            this.filmShowList = filmShowList;
        }

        // GET: /api/FilmShow/
        [HttpGet]
        public IEnumerable<FilmShow> GetAllFilmShows()
        {
            return filmShowList;
        }

        // GET: /api/FilmShow/id
        [HttpGet]
        public FilmShow GetFilmShow(int id)
        {
            FilmShow filmShow = filmShowList.Where(x => x.DBKey == id).FirstOrDefault();
            return filmShow;
        }

        // POST: /api/FilmShow/
        [HttpPost]
        public int AddFilmShow(FilmShow filmShow)
        {
            filmShowList.Add(filmShow);

            return filmShowList.Count;
        }

        // PUT: /api/FilmShow/
        [HttpPut]
        public FilmShow UpdateFilmShow(FilmShow filmShow)
        {
            FilmShow filS = filmShowList.Where(x => x.DBKey == filmShow.DBKey).FirstOrDefault();
            filS.DateOfFilmShow = filmShow.DateOfFilmShow;

            return filS;
        }

        // DELETE: /api/FilmShow/id
        [HttpDelete]
        public int DeleteFilmShow(int id)
        {
            filmShowList.Remove(filmShowList.Where(c => c.DBKey == id).FirstOrDefault());

            return filmShowList.Count();
        }
    }
}
