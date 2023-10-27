using BookStore.Core.Common;
using System.Collections.Generic;

namespace BookStore.Database.Entities.Entities
{ 
    public class GenreEntity : BaseEntity
    {
        public string GenreType { get; set; }
        public ICollection<BookEntity> Books { get; set; }
    }
}
