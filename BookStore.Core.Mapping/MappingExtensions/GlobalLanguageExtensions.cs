using BookStore.Core.Mapping.Models;
using BookStore.Database.Entities.Entities;

namespace BookStore.Core.Mapping.MappingExtensions
{
    public static class GlobalLanguageExtensions
    {
        public static GlobalLanguageEntity ToBaseEntity(this GlobalLanguageViewModel model)
            => model != null ? new GlobalLanguageEntity()
            {
                Id = model.Id,
                Language = model.Language,
                Flag = model.Flag
            }
            : null;

        public static GlobalLanguageViewModel ToBaseModel(this GlobalLanguageEntity entity)
            => entity != null ? new GlobalLanguageViewModel()
            {
                Id = entity.Id,
                Language = entity.Language,
                Flag = entity.Flag
            }
            : null;
    }
}
