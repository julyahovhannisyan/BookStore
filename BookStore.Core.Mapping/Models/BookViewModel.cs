using BookStore.Core.Common;
using BookStore.Core.Common.Enum;
using BookStore.Database.Entities.Entities;
using System;

namespace BookStore.Core.Mapping.Models
{
    public class BookViewModel : BaseViewModel
    {
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string ImageCover { get; set; }
        public int CoverTypeId { get; set; }
        public string Description { get; set; }
        public string BookLanguage { get; set; }
        public int PageCount { get; set; }
        public bool IsNew { get; set; }
        public bool IsInStock { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishDate { get; set; }
        public decimal Discount { get; set; }
        public string ISBNCode { get; set; }
    }
}
