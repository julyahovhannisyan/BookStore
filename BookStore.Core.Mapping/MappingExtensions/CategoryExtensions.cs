using BookStore.Core.Mapping.Models;
using BookStore.Database.Entities.Entities;

namespace BookStore.Core.Mapping.MappingExtensions
{
    public static class CategoryExtensions
    {
        public static CategoryEntity ToBaseEntity(this CategoryViewModel model)
           => model != null ? new CategoryEntity()
           {
               Id = model.Id,
               Name = model.Name
           }
           : null;

        public static CategoryViewModel ToBaseModel(this CategoryEntity entity)
            => entity != null ? new CategoryViewModel()
            {
                Id = entity.Id,
                Name = entity.Name
            }
            : null;
    }
}
