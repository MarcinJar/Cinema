﻿using CinemaReservation.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.InterfaceDataAccess
{
    public interface ICinemaRepository : IBaseRepository<Cinema>
    {
        List<CinemaRoom> GetAllCinemaRooms(int dbKeyCinema);
    }
}
