using LMS_API_DB_ID.Models;

namespace LMS_API_DB_ID.Repositories
{
    public class AddBookRepositorie : IAddBookRepositorie
    {
        private List<LMSModel> books = new List<LMSModel>();
        public int AddBook(LMSModel book)
        {
            //book.BookID = books.Count + 1;
            books.Add(book);
            return book.BookID;
        }
        public List<LMSModel> GetAllBooks()
        {
            return books;
        }
    }
}
