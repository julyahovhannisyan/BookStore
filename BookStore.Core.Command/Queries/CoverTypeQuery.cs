using System;
using System.Linq;
using System.Collections.Generic;
using BookStore.Database.Connection;
using BookStore.Database.Entities.Entities;

namespace BookStore.Database.Commands.Queries
{
    public class CoverTypeQuery : IQuery<CoverTypeEntity>
    {
        private BookStoreContext _context;

        public CoverTypeQuery(BookStoreContext context) => _context = context;

        public IEnumerable<CoverTypeEntity> GetAll()
        {
            try
            {
                return _context.CoverTypes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public CoverTypeEntity GetById(int id)
        {
            try
            {
                return _context.CoverTypes.Where(p => p.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
