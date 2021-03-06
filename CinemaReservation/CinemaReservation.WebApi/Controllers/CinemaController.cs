﻿using CinemaReservation.Core.DataLogic.IDataLogic;
using CinemaReservation.Model.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CinemaReservation.WebApi.Controllers
{
    public class CinemaController : ApiController
    {
        private IList<Cinema> cinemaList = new List<Cinema>();
        private ICinemaLogic cinemaLogic;
        //public ILog Logger { get; set; }
        private readonly ILog log;

        public CinemaController() { }

        public CinemaController(ICinemaLogic cinemaLogic, ILog Logger)
        {
            this.cinemaLogic = cinemaLogic;
            this.log = Logger;
        }

        // GET: /api/Cinema/
        [HttpGet]
        public IEnumerable<Cinema> GetAllCinemaRooms()
        {
            IEnumerable<Cinema> cinemas = this.cinemaLogic.GetAll();
            return cinemas;
        }

        // GET: /api/Cinema/id
        [HttpGet]
        public Cinema GetCinema(int id)
        {
            Cinema cinema = this.cinemaLogic.Get(id);
            log.Info("Get cinema withe id = " + id);
            this.log.Info("Get cinema by id");
            return cinema;
        }

        // POST: /api/Cinema/
        [HttpPost]
        public int AddCinema(Cinema cinema)
        {
            cinemaList.Add(cinema);

            return cinemaList.Count;
        }

        // PUT: /api/Cinema/
        [HttpPut]
        public Cinema UpdateCinema(Cinema cinema)
        {
            Cinema cin = cinemaList.Where(x => x.DBKey == cinema.DBKey).FirstOrDefault();
            cin.Name = cinema.Name;

            return cin;
        }

        // DELETE: /api/Cinema/id
        [HttpDelete]
        public int DeleteCinema(int id)
        {
            cinemaList.Remove(cinemaList.Where(c => c.DBKey == id).FirstOrDefault());

            return cinemaList.Count();
        }
    }
}
