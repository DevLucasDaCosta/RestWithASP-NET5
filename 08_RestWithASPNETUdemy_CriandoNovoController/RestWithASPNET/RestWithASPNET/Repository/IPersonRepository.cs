using RestWithASPNET.Model;

namespace RestWithASPNET.Repository
{
    public interface IPersonRepository
    {

        Person Create(Person person);
        List<Person> FindAll();
        Person FindById(long id);
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long id);

    }
}
