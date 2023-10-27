using BookStore.Database.Connection;

namespace BookStore.Core.BusinessLayer.Products
{
    public class UnitOfWork //: IDisposable
    {
        private BookStoreContext _context;
        private AuthorManager authorManager;
        private BookManager bookManager;
        private GenreManager genreManager;
        private CategoryManager categoryManager;
        private CoverTypeManager coverTypeManager;
        private GlobalLanguageManager globalLanguageManager;

        public UnitOfWork(BookStoreContext context = null) => _context = context;

        public AuthorManager AuthorManager
        {
            get
            {
                if (authorManager == null)
                    authorManager = new AuthorManager(_context);
                return authorManager;
            }
        }
        public BookManager BookManager
        {
            get
            {
                if (bookManager == null)
                    bookManager = new BookManager(_context);
                return bookManager;
            }
        }
        public GenreManager GenreManager
        {
            get
            {
                if (genreManager == null)
                    genreManager = new GenreManager(_context);
                return genreManager;
            }
        }
        public CategoryManager CategoryManager
        {
            get
            {
                if (categoryManager == null)
                    categoryManager = new CategoryManager(_context);
                return categoryManager;
            }
        }
        public CoverTypeManager CoverTypeManager
        {
            get
            {
                if (coverTypeManager == null)
                    coverTypeManager = new CoverTypeManager(_context);
                return coverTypeManager;
            }
        }
        public GlobalLanguageManager GlobalLanguageManager
        {
            get
            {
                if (globalLanguageManager == null)
                    globalLanguageManager = new GlobalLanguageManager(_context);
                return globalLanguageManager;
            }
        }
    }
}
