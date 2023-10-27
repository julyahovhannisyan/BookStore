using System;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;
using BookStore.Database.Connection;
using BookStore.Core.Mapping.Models;
using BookStore.Database.Commands.Queries;
using BookStore.Database.Commands.Commands;
using BookStore.Core.Mapping.MappingExtensions;

namespace BookStore.Core.BusinessLayer.Products
{
    public class BookManager : IManager
    {
        private BookStoreContext _context;

        public BookManager(BookStoreContext context) => _context = context;

        public BookViewModel Create(BookViewModel model)
        {
            try
            {
                return new BookCommand(_context).Create(model.ToBaseEntity()).ToBaseModel();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public BookViewModel Delete(int id)
        {
            var model = _context.Books.Where(p => p.Id == id).FirstOrDefault();
            return new BookCommand(_context).Delete(model).ToBaseModel();
        }
        public BookViewModel Update(BookViewModel model)
        {
            try
            {
                return new BookCommand(_context).Update(model.ToBaseEntity()).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public BookViewModel GetById(int id)
        {
            try
            {
                return new BookQuery(_context).GetById(id).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<BookViewModel> GetAll()
        {
            try
            {
                return new BookQuery(_context).GetAll().Select(p => p.ToBaseModel());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
