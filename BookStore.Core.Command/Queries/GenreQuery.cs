using System;
using System.Linq;
using System.Collections.Generic;
using BookStore.Database.Connection;
using BookStore.Database.Entities.Entities;

namespace BookStore.Database.Commands.Queries
{
    public class GenreQuery : IQuery<GenreEntity>
    {
        private BookStoreContext _context;

        public GenreQuery(BookStoreContext context) => _context = context;

        public IEnumerable<GenreEntity> GetAll()
        {
            try
            {
                return _context.Genres;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public GenreEntity GetById(int id)
        {
            try
            {
                return _context.Genres.Where(p => p.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}