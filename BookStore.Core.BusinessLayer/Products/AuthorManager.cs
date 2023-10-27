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
    public class AuthorManager : IManager
    {
        private BookStoreContext _context;

        public AuthorManager(BookStoreContext context) => _context = context;

        public AuthorViewModel Create(AuthorViewModel model) 
        {
            try
            {
                return new AuthorCommand(_context).Create(model.ToBaseEntity()).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public AuthorViewModel Update(AuthorViewModel model)
        {
            try
            {
                return new AuthorCommand(_context).Update(model.ToBaseEntity()).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AuthorViewModel GetById(int id)
        {
            try
            {
                return new AuthorQuery(_context).GetById(id).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<AuthorViewModel> GetAll()
        {
            try
            {
                return new AuthorQuery(_context).GetAll().Select(p=>p.ToBaseModel());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
