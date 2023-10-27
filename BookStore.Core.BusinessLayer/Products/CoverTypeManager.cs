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
    public class CoverTypeManager : IManager
    {
        private BookStoreContext _context;

        public CoverTypeManager(BookStoreContext context) => _context = context;

        public CoverTypeViewModel Create(string coverType)
        {
            try
            {
                var model = new CoverTypeViewModel() { Type = coverType };
                return new CoverTypeCommand(_context).Create(model.ToBaseEntity()).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public CoverTypeViewModel Update(CoverTypeViewModel model)
        {
            try
            {
                return new CoverTypeCommand(_context).Update(model.ToBaseEntity()).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public CoverTypeViewModel GetById(int id)
        {
            try
            {
                return new CoverTypeQuery(_context).GetById(id).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<CoverTypeViewModel> GetAll()
        {
            try
            {
                return new CoverTypeQuery(_context).GetAll().Select(p => p.ToBaseModel());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
