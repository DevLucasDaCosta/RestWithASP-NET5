using RestWithASPNET.Model;
using RestWithASPNET.Model.Base;

namespace RestWithASPNET.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {

        T Create(T item);
        List<T> FindAll();
        T FindById(long id);
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);

    }
}
