using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Core.DataLogic.IDataLogic
{
    public interface IBaseLogic<T>
    {
        T Get(int cinemaDBKey);

        IEnumerable<T> GetAll();

        T Add(T cinamaToCreate);

        T Update(T cinemaToUpdate);

        bool Delete(int cinemaDBKey);
    }
}
