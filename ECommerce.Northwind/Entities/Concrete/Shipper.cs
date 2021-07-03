using Core.Entities;

namespace Entities.Concrete
{
    public class Shipper : IEntity
   {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

    }
}
