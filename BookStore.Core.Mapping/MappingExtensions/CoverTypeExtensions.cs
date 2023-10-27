using BookStore.Core.Mapping.Models;
using BookStore.Database.Entities.Entities;

namespace BookStore.Core.Mapping.MappingExtensions
{
    public static class CoverTypeExtensions
    {
        public static CoverTypeEntity ToBaseEntity(this CoverTypeViewModel model)
                => model != null ? new CoverTypeEntity()
                {
                    Id = model.Id,
                    Type = model.Type
                }
                : null;

        public static CoverTypeViewModel ToBaseModel(this CoverTypeEntity entity)
                => entity != null ? new CoverTypeViewModel()
                {
                    Id = entity.Id,
                    Type = entity.Type
                }
                : null;
    }
}
