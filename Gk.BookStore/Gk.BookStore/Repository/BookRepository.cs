using Gk.BookStore.Models;

namespace Gk.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title , string authorName) 
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title = "MVC" , Author = "Nitish" , Description = "This is the description for MVC book" , Category="Programming" , Language="English" , TotalPages=134 },
                new BookModel(){Id = 2, Title = "Dot Net Core" , Author = "Monika"  , Description = "This is the description for .net core book" , Category=".Net core" , Language="Chienese" , TotalPages=567 },
                new BookModel(){Id = 3, Title = "Java" , Author = "Webgentle", Description = "This is the description for Java book" , Category="Java" , Language="Gujarati" , TotalPages=897 },
                new BookModel(){Id = 4, Title = "Php" , Author = "Gk", Description = "This is the description for Php book" , Category="PHP" , Language="Hindi" , TotalPages=555},
                new BookModel(){Id = 5, Title = "C#" , Author = "Jay", Description = "This is the description for C sharp book" , Category="C#" , Language="English" , TotalPages=256 },

            };
        }
    }
}
