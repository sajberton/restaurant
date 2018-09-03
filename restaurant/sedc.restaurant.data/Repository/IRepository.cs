using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedc.restaurant.data.Repository
{
   public interface IRepository<T>
    {
        IList<T> GetAll();

        T Get(int id);

        T Create(T Item);

        void Update(T item);

        void Delete(T item);
    }  
}
