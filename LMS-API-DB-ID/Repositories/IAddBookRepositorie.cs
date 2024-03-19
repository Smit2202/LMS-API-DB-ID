using LMS_API_DB_ID.Models;

namespace LMS_API_DB_ID.Repositories
{
    public interface IAddBookRepositorie
    {
        int AddBook(LMSModel book);
        List<LMSModel> GetAllBooks();

    }
}
