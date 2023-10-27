using System;
using System.Linq;
using System.Collections.Generic;
using BookStore.Database.Connection;
using BookStore.Database.Entities.Entities;

namespace BookStore.Database.Commands.Queries
{
    public class AuthorQuery : IQuery<AuthorEntity>
    {
        private BookStoreContext _context;

        public AuthorQuery(BookStoreContext context) => _context = context;

        public IEnumerable<AuthorEntity> GetAll()
        {
            try
            {
                return _context.Authors;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public AuthorEntity GetById(int id)
        {
            try
            {
                return _context.Authors.Where(p => p.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
