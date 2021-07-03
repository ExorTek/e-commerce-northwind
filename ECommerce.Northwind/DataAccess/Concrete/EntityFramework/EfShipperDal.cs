using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfShipperDal : EfEntityRepositoryBase<Shipper, NorthwindContext>, IShipperDal
    {
    }
}
