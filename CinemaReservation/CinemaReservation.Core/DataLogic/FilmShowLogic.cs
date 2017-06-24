﻿using CinemaReservation.Core.DataLogic.IDataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaReservation.Model.Models;
using CinemaReservation.InterfaceDataAccess;

namespace CinemaReservation.Core.DataLogic
{
    public class FilmShowLogic : IFilmShowLogic
    {
        private IFilmShowRepository filmShowRepository;

        public FilmShowLogic(IFilmShowRepository filmShowRepository)
        {
            this.filmShowRepository = filmShowRepository;
        }

        public FilmShow Add(FilmShow toCreate)
        {
            return this.filmShowRepository.Add(toCreate);
        }

        public bool Delete(int DBKey)
        {
            return this.filmShowRepository.Delete(DBKey);
        }

        public FilmShow Get(int DBKey)
        {
            return this.filmShowRepository.Get(DBKey);
        }

        public IEnumerable<FilmShow> GetAll()
        {
            return this.filmShowRepository.GetAll();
        }

        public FilmShow Update(FilmShow toUpdate)
        {
            return this.filmShowRepository.Update(toUpdate);
        }
    }
}
