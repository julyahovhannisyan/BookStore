using System;
using BookStore.Database.Connection;
using BookStore.Database.Entities.Entities;

namespace BookStore.Database.Commands.Commands
{
    public class AuthorCommand : ICommand<AuthorEntity>
    {
        private BookStoreContext _context;

        public AuthorCommand(BookStoreContext context) => _context = context;

        public AuthorEntity Create(AuthorEntity entity)
        {
            try
            {
                _context.Authors.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public AuthorEntity Update(AuthorEntity entity)
        {
            try
            {
                _context.Authors.Update(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public AuthorEntity Delete(int entityId)
        {
            try
            {
                //find entity by Id
                AuthorEntity test = new AuthorEntity();
                _context.Authors.Remove(test);
                _context.SaveChanges();
                return test;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
