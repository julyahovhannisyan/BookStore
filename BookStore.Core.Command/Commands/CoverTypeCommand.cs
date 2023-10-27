using System;
using BookStore.Database.Connection;
using BookStore.Database.Entities.Entities;

namespace BookStore.Database.Commands.Commands
{
    public class CoverTypeCommand : ICommand<CoverTypeEntity>
    {
        private BookStoreContext _context;
        public CoverTypeCommand(BookStoreContext context) => _context = context;

        public CoverTypeEntity Create(CoverTypeEntity entity)
        {
            try
            {
                _context.CoverTypes.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public CoverTypeEntity Update(CoverTypeEntity entity)
        {
            try
            {
                _context.CoverTypes.Update(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public CoverTypeEntity Delete(int entityId)
        {
            //find entity
            throw new NotImplementedException();
        }
    }
}
