using RestWithASPNET.Model;

namespace RestWithASPNET.Repository
{
    public interface IBookRepository
    {
        Book Create(Book book);
        List<Book> FindAll();
        Book FindById(long id);
        Book Update(Book book);
        void Delete(long id);
        bool Exists(long id);
    }
}
