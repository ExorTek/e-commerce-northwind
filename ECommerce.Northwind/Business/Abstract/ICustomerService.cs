using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IResult Add(Customer customer);
        IDataResult<Customer> GetCustomerDetailById(string id);
    }
}