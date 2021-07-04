using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
    {
        public CustomerDetailDto GetCustomerDetailById(string id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = (from c in context.Customers
                    where c.CustomerId == id
                    select new CustomerDetailDto
                    {
                        CustomerId = c.CustomerId,
                        CompanyName = c.CompanyName,
                        ContactName = c.ContactName,
                        ContactTitle = c.ContactTitle,
                        Address = c.Address,
                        City = c.City,
                        Region = c.Region,
                        PostalCode = c.PostalCode,
                        Country = c.Country,
                        Phone = c.Phone,
                        Fax = c.Fax
                    }).FirstOrDefault();
                return result;
            }
        }
    }
}