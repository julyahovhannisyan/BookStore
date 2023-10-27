using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Database.Commands.Commands
{
    interface ICommand<T> 
    {
        public T Create(T entity);
        public T Update(T entity);
        //public T Delete(int entityId);
    }
}
