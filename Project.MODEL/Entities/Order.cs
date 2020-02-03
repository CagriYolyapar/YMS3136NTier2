using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Order:BaseEntity
    {
        public Order()
        {

        }
        public Order(string Address,int userID,int shipID)
        {
            ShipperAddress = Address;
            AppUserID = userID;
            ShipperID = shipID;
    }
        public string ShipperAddress { get; set; }
        public int AppUserID { get; set; }
        public int ShipperID { get; set; }

        //Relational Properties begin...
        public virtual AppUser AppUser { get; set; }//AppUser ile bire çok ilişki
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual List<Shipper> Shippers { get; set; } //order ile bire çok ilişki
    }
}
