using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomerListed);
        }

        public IResult Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> GetCustomerDetailById(string id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.CustomerId == id),Messages.CustomerSuccessDetail);
        }
    }
}