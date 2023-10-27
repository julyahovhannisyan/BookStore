using BookStore.Database.Connection;
using BookStore.Database.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Database.Commands.Queries
{
    public class GlobalLanguageQuery : IQuery<GlobalLanguageEntity>
    {
        private BookStoreContext _context;

        public GlobalLanguageQuery(BookStoreContext context) => _context = context;

        public IEnumerable<GlobalLanguageEntity> GetAll()
        {
            try
            {
                return _context.GlobalLanguages;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public GlobalLanguageEntity GetById(int id)
        {
            try
            {
                return _context.GlobalLanguages.Where(p => p.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
