using System;
using System.Linq;
using System.Collections.Generic;
using BookStore.Database.Connection;
using BookStore.Database.Entities.Entities;

namespace BookStore.Database.Commands.Queries
{
    public class BookQuery : IQuery<BookEntity>
    {
        private BookStoreContext _context;

        public BookQuery(BookStoreContext context) => _context = context;

        public IEnumerable<BookEntity> GetAll()
        {
            try
            {
                return _context.Books;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public BookEntity GetById(int id)
        {
            try
            {
                return _context.Books.Where(p => p.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
