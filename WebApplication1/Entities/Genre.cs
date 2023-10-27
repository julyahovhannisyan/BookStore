using System.Collections.Generic;

namespace WebApplication1.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreType { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
