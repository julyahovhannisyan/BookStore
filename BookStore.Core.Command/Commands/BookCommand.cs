using System;
using BookStore.Database.Connection;
using BookStore.Database.Entities.Entities;

namespace BookStore.Database.Commands.Commands
{
    public class BookCommand : ICommand<BookEntity>
    {
        private BookStoreContext _context;
        public BookCommand(BookStoreContext context) => _context = context;

        public BookEntity Create(BookEntity entity)
        {
            try
            {
                _context.Books.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public BookEntity Update(BookEntity entity)
        {
            try
            {
                _context.Books.Update(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public BookEntity Delete(BookEntity entity)
        {
            try
            {
                var model = _context.Books.Remove(entity).Entity;
                _context.SaveChanges();
                return model;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
