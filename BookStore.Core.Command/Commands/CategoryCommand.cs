using System;
using BookStore.Database.Connection;
using BookStore.Database.Entities.Entities;

namespace BookStore.Database.Commands.Commands
{
    public class CategoryCommand : ICommand<CategoryEntity>
    {
        private BookStoreContext _context;

        public CategoryCommand(BookStoreContext context) => _context = context;

        public CategoryEntity Create(CategoryEntity entity)
        {
            try
            {
                _context.Categories.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public CategoryEntity Update(CategoryEntity entity)
        {
            try
            {
                _context.Categories.Update(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public CategoryEntity Delete(int entityId)
        {
            try
            {
                //find entity by Id
                CategoryEntity test = new CategoryEntity();
                _context.Categories.Remove(test);
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
