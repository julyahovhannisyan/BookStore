using BookStore.Core.Common;
using System.Collections.Generic;

namespace BookStore.Database.Entities.Entities
{
    public class AuthorEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<BookEntity> Books { get; set; }
    }
}
