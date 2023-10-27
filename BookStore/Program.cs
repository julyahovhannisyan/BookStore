using System;
using BookStore.Core.Common.Enum;
using BookStore.Core.Mapping.Models;
using BookStore.Database.Connection;
using Microsoft.EntityFrameworkCore;
using BookStore.Core.BusinessLayer.Products;

namespace BookStore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptions<BookStoreContext>();
            //BookStoreContext context = new BookStoreContext();


            UnitOfWork test = new UnitOfWork(new BookStoreContext(options));

            //test.BookManager.Delete(4);

            var t = test.BookManager.Create(new BookViewModel
            {
                Title = "The Chronicles of Narnia: 7 Books in 1 Paperback",
                OriginalTitle = "The Chronicles of Narnia: 7 Books in 1 Paperback",
                BookLanguage = Language.English.ToString(),
                Discount = 20,
                IsNew = false,
                IsInStock = true,
                ISBNCode = "CODE106",
                Publisher = Publisher.BantamClassics.ToString(),
                PublishDate = new DateTime(2009, 5, 14),
                ImageCover = @"https://images-us.bookshop.org/ingram/9780066238500.jpg?height=500&v=v2",
                CoverTypeId = 1,
                CategoryId = 1,
                PageCount = 448,
                Price = 300,
                Description = "Don't miss one of America's top 100 most-loved novels, selected by PBS's The Great American Read."
            });
            var tt = test.BookManager.Create(new BookViewModel
            {
                Title = "Hamlet: by William Shakespeare",
                OriginalTitle = "Hamlet: by William Shakespeare",
                BookLanguage = Language.English.ToString(),
                Discount = 50,
                IsNew = false,
                IsInStock = true,
                ISBNCode = "CODE170",
                Publisher = Publisher.BantamClassics.ToString(),
                PublishDate = new DateTime(2004, 1, 1),
                ImageCover = @"https://images-us.bookshop.org/ingram/9798674021261.jpg?height=500&v=v2",
                CoverTypeId = 1,
                CategoryId = 1,
                PageCount = 180,
                Price = 60,
                Description = "Hamlet is a tragedy by William Shakespeare, believed to have been written between 1599 and 1601. The play, set in Denmark, recounts how Prince Hamlet exacts revenge on his uncle Claudius, who has murdered Hamlet's father, the King, and then taken the throne and married Hamlet's mother. The play vividly charts the course of real and feigned madness-from overwhelming grief to seething rage-and explores themes of treachery, revenge, incest, and moral corruption."
            });
            var ttt = test.BookManager.Create(new BookViewModel
            {
                Title = "Wuthering Heights",
                OriginalTitle = "Wuthering Heights",
                BookLanguage = Language.English.ToString(),
                Discount = 0,
                IsNew = true,
                IsInStock = true,
                ISBNCode = "CODE331",
                Publisher = Publisher.BantamClassics.ToString(),
                PublishDate = new DateTime(2002, 1, 31),
                ImageCover = @"https://images-us.bookshop.org/ingram/9780141439556.jpg?height=500&v=v2",
                CoverTypeId = 1,
                CategoryId = 1,
                PageCount = 416,
                Price = 35,
                Description = "One of English literature's classic masterpieces--a gripping novel of love, propriety, and tragedy. Nominated as one of America's best-loved novels by PBS's The Great American Read"
            });
            //It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife. However little known the feelings or views of such a man may be on his first entering a neighborhood, this truth is so well fixed in the minds of the surrounding families, that he is considered the rightful property of some one or other of their daughters. "My dear Mr. Bennet," said his lady to him one day, "have you heard that Netherfield Park is let at last?" Mr. Bennet replied that he had not. "But it is," returned she; "for Mrs. Long has just been here, and she told me all about it." Mr. Bennet made no answer. "Do you not want to know who has taken it?" cried his wife impatiently. "You want to tell me, and I have no objection to hearing it." This was invitation enough.
            //test.GenreManager.Create("Classic");
            //test.GlobalLanguageManager.Create("ENG");
            //test.CoverTypeManager.Create("Paperback ");
            Console.ReadLine();
        }
    }
}
