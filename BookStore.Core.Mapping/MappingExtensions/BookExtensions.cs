using BookStore.Core.Mapping.Models;
using BookStore.Database.Entities.Entities;

namespace BookStore.Core.Mapping.MappingExtensions
{
    public static class BookExtensions 
    {
        public static BookEntity ToBaseEntity(this BookViewModel model)
            => model != null ? new BookEntity()
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                BookLanguage = model.BookLanguage,
                CoverTypeId = model.CoverTypeId,
                CategoryId = model.CategoryId,
                Discount = model.Discount,
                ImageCover = model.ImageCover,
                ISBNCode = model.ISBNCode,
                IsInStock = model.IsInStock,
                IsNew = model.IsNew,
                OriginalTitle = model.OriginalTitle,
                PageCount = model.PageCount,
                Price = model.Price,
                PublishDate = model.PublishDate,
                Publisher = model.Publisher
            }
            : null;

        public static BookViewModel ToBaseModel(this BookEntity entity)
            => entity != null ? new BookViewModel()
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                BookLanguage = entity.BookLanguage,
                CategoryId = entity.CategoryId,
                CoverTypeId = entity.CoverTypeId,
                Discount = entity.Discount,
                ImageCover = entity.ImageCover,
                ISBNCode = entity.ISBNCode,
                IsInStock = entity.IsInStock,
                IsNew = entity.IsNew,
                OriginalTitle = entity.OriginalTitle,
                PageCount = entity.PageCount,
                Price = entity.Price,
                PublishDate = entity.PublishDate,
                Publisher = entity.Publisher
            }
            : null;
    }
}
