using BookStore.Core.Common;

namespace BookStore.Database.Entities.Entities
{
    public class GlobalLanguageEntity : BaseEntity
    {
        public string Language { get; set; }
        public string Flag { get; set; }
    }
}
