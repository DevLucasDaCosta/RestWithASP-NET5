using RestWithASPNET.Data.VO;

namespace RestWithASPNET.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        List<PersonVO> FindAll();
        PersonVO FindById(long id);
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}
