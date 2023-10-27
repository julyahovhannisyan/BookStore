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
    public class GlobalLanguageManager : IManager
    {
        private BookStoreContext _context;

        public GlobalLanguageManager(BookStoreContext context) => _context = context;

        public GlobalLanguageViewModel Create(string languageName)
        {
            try
            {
                var model = new GlobalLanguageViewModel() { Language = languageName };
                return new GlobalLanguageCommand(_context).Create(model.ToBaseEntity()).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public GlobalLanguageViewModel Update(GlobalLanguageViewModel model)
        {
            try
            {
                return new GlobalLanguageCommand(_context).Update(model.ToBaseEntity()).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public GlobalLanguageViewModel GetById(int id)
        {
            try
            {
                return new GlobalLanguageQuery(_context).GetById(id).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<GlobalLanguageViewModel> GetAll()
        {
            try
            {
                return new GlobalLanguageQuery(_context).GetAll().Select(p => p.ToBaseModel());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
