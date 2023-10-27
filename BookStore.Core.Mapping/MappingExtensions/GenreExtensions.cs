using BookStore.Core.Mapping.Models;
using BookStore.Database.Entities.Entities;

namespace BookStore.Core.Mapping.MappingExtensions
{
    public static class GenreExtensions
    {
        public static GenreEntity ToBaseEntity(this GenreViewModel model)
            => model != null ? new GenreEntity()
            {
                Id = model.Id,
                GenreType = model.GenreType
            }
            : null;

        public static GenreViewModel ToBaseModel(this GenreEntity entity)
            => entity != null ? new GenreViewModel()
            {
                Id = entity.Id,
                GenreType = entity.GenreType
            }
            : null;
    }
}
