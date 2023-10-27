using BookStore.Core.Mapping.Models;
using BookStore.Database.Entities.Entities;

namespace BookStore.Core.Mapping.MappingExtensions
{
    public static class AuthorExtensions
    { 
        public static AuthorEntity ToBaseEntity(this AuthorViewModel model)
            => model != null ? new AuthorEntity()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName
            }
            : null;

        public static AuthorViewModel ToBaseModel(this AuthorEntity entity)
            => entity != null ? new AuthorViewModel()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            }
            : null;
    }
}
