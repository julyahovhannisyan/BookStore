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
    public class GenreManager : IManager
    {
        private BookStoreContext _context;

        public GenreManager(BookStoreContext context) => _context = context;

        public GenreViewModel Create(string genreName)
        {
            try
            {
                var model = new GenreViewModel() { GenreType = genreName };
                return new GenreCommand(_context).Create(model.ToBaseEntity()).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public GenreViewModel Update(GenreViewModel model)
        {
            try
            {
                return new GenreCommand(_context).Update(model.ToBaseEntity()).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public GenreViewModel GetById(int id)
        {
            try
            {
                return new GenreQuery(_context).GetById(id).ToBaseModel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<GenreViewModel> GetAll()
        {
            try
            {
                return new GenreQuery(_context).GetAll().Select(p => p.ToBaseModel());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
