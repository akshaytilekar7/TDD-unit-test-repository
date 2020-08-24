using TDD.BusinessEntities;

namespace TDD.Business.Service.Interface
{
    public interface IAddressService
    {
        Address GetAddressById(int id);

        Address Create(Address address);
    }
}
