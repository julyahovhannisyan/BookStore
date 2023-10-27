using System.Collections.Generic;

namespace WebApplication1.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       // public virtual ICollection<Book> Books { get; set; }

        public int MyProperty1 { get; set; }
    }
}
