using System;
using System.Linq;
using System.Collections.Generic;
using BookStore.Core.Mapping.Models;
using BookStore.Database.Connection;
using BookStore.Database.Commands.Queries;
using BookStore.Database.Commands.Commands;
using BookStore.Core.Mapping.MappingExtensions;

namespace BookStore.Core.BusinessLayer.Products
{
    public class CategoryManager : IManager
    {
        private BookStoreContext _context;

        public CategoryManager(BookStoreContext context) => _context = context;

        public CategoryViewModel Create(string categoryName)
        {
            try
            {
                var model = new CategoryViewModel() { Name = categoryName };
                return new CategoryCommand(_context).Create(model.ToBaseEntity()).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public CategoryViewModel Update(CategoryViewModel model)
        {
            try
            {
                return new CategoryCommand(_context).Update(model.ToBaseEntity()).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public CategoryViewModel GetById(int id)
        {
            try
            {
                return new CategoryQuery(_context).GetById(id).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<CategoryViewModel> GetAll()
        {
            try
            {
                return new CategoryQuery(_context).GetAll().Select(p => p.ToBaseModel());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
