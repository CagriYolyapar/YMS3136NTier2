using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class OrderDetail:BaseEntity
    {
        public OrderDetail()
        {

        }
        public OrderDetail(int orderID,int productID)
        {
            OrderID = orderID;
            ProductID = productID;
        }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        //Relational Properties begin...
        public virtual Order Order { get; set; } //Order ve Product ile bire bir ilişki 
        public virtual Product Product { get; set; }

    }
}
