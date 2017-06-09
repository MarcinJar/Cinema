using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaReservation.Model.Models
{
    public class Person
    {
        public int DBKey { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string DateOfBirth { get; set; }

        public int Discount { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}