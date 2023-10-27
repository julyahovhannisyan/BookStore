using BookStore.Core.Common;
using BookStore.Core.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Database.Entities.Entities
{
    public class BookEntity : BaseViewModel
    {
        public decimal Price { get; set; }
        //public Category CategoryName { get; set; }

        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public string ImageCover { get; set; }
        [ForeignKey("CoverType")]
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

        public ICollection<AuthorEntity> Authors { get; set; }
        public ICollection<GenreEntity> Genres { get; set; }
        public CoverTypeEntity CoverType { get; set; }
        public CategoryEntity Category { get; set; }

    }
}
