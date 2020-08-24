using System.Linq;
using TDD.Business.DataAccess;
using TDD.Business.DataAccess.Interface;
using TDD.Business.Service.Interface;
using TDD.BusinessEntities;

namespace TDD.Business.Service
{
    public class AddressService : IAddressService
    {
        private readonly IActionFactory _actionFactory;
        private readonly IRepositoryFactory _repositoryFactory;

        public AddressService() : this(new ActionFactory(), new RepositoryFactory()) { }

        public AddressService(IActionFactory actionFactory, IRepositoryFactory repositoryFactory)
        {
            _actionFactory = actionFactory;
            _repositoryFactory = repositoryFactory;
        }

        public Address Create(Address address)
        {
            return _repositoryFactory.GetRepository<Address>().Create(address);
        }

        public Address GetAddressById(int id)
        {
            return _repositoryFactory.GetRepository<Address>().GetAllData().FirstOrDefault(x => x.Id == id);
        }
    }
}
