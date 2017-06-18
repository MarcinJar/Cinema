using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Core.DataLogic.IDataLogic
{
    public interface IBaseLogic<T>
    {
        T Get(int DBKey);

        IEnumerable<T> GetAll();

        T Add(T toCreate);

        T Update(T toUpdate);

        bool Delete(int DBKey);
    }
}
