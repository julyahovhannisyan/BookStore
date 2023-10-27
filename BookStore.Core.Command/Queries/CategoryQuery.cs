using System;
using System.Linq;
using System.Collections.Generic;
using BookStore.Database.Connection;
using BookStore.Database.Entities.Entities;

namespace BookStore.Database.Commands.Queries
{
    public class CategoryQuery : IQuery<CategoryEntity>
    {
        private BookStoreContext _context;

        public CategoryQuery(BookStoreContext context) => _context = context;

        public IEnumerable<CategoryEntity> GetAll()
        {
            try
            {
                return _context.Categories;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public CategoryEntity GetById(int id)
        {
            try
            {
                return _context.Categories.Where(p => p.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
