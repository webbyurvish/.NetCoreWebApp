using Gk.BookStore.Models;

namespace Gk.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookId(int id)
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
                new BookModel(){Id = 1, Title = "MVC" , Author = "Nitish"},
                new BookModel(){Id = 2, Title = "Dot Net Core" , Author = "Monika"},
                new BookModel(){Id = 3, Title = "Java" , Author = "Webgentle"},
                new BookModel(){Id = 4, Title = "Php" , Author = "Gk"},
                new BookModel(){Id = 5, Title = "C#" , Author = "Jay"},

            };
        }
    }
}
