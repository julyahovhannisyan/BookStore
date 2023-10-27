using BookStore.Core.BusinessLayer.Products;
using BookStore.Core.Mapping.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class SystemController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public SystemController([FromServices] UnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("books")]
        public async Task<List<BookViewModel>> GetAllBooks() 
        {
            try
            {
                return _unitOfWork.BookManager.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("authors")]
        public async Task<List<AuthorViewModel>> GetAllAuthors()
        {
            try
            {
                return _unitOfWork.AuthorManager.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("genres")]
        public async Task<List<GenreViewModel>> GetAllGenres()
        {
            try
            {
                return _unitOfWork.GenreManager.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("globallanguages")]
        public async Task<List<GlobalLanguageViewModel>> GetAllGlobalLanguages()
        {
            try
            {
                return _unitOfWork.GlobalLanguageManager.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("covertypes")]
        public async Task<List<CoverTypeViewModel>> GetAllCoverTypes()
        {
            try
            {
                return _unitOfWork.CoverTypeManager.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
