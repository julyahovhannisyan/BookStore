using System;
using BookStore.Database.Connection;
using BookStore.Database.Entities.Entities;

namespace BookStore.Database.Commands.Commands
{
    public class GlobalLanguageCommand : ICommand<GlobalLanguageEntity>
    {
        private BookStoreContext _context;
        public GlobalLanguageCommand(BookStoreContext context) => _context = context;

        public GlobalLanguageEntity Create(GlobalLanguageEntity entity)
        {
            try
            {
                _context.GlobalLanguages.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public GlobalLanguageEntity Update(GlobalLanguageEntity entity)
        {
            try
            {
                _context.GlobalLanguages.Update(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public GlobalLanguageEntity Delete(int entityId)
        {
            //find entity
            throw new NotImplementedException();
        }
    }
}
