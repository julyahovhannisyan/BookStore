using System;
using BookStore.Database.Connection;
using BookStore.Database.Entities.Entities;

namespace BookStore.Database.Commands.Commands
{
    public class GenreCommand : ICommand<GenreEntity>
    {
        private BookStoreContext _context;
        public GenreCommand(BookStoreContext context) => _context = context;

        public GenreEntity Create(GenreEntity entity)
        {
            try
            {
                _context.Genres.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public GenreEntity Update(GenreEntity entity)
        {
            try
            {
                _context.Genres.Update(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public GenreEntity Delete(int entityId)
        {
            //find entity
            throw new NotImplementedException();
        }
    }
}
