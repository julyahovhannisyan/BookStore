using System.Collections.Generic;

namespace BookStore.Database.Commands.Queries
{
    interface IQuery<T>
    {
        public IEnumerable<T> GetAll();
        public T GetById(int id);
    }
}
