using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Product:BaseEntity
    {
        public Product()
        {
            
        }
        public Product(string name, decimal Price, short stock,int categoryID)
        {
            ProductName = name;
            UnitPrice = Price;
            UnitsInStock = stock;
            CategoryID = categoryID;
        }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public int CategoryID { get; set; }

        //Relational Properties begin...
        public virtual Category Category { get; set; }//product ile bire çok ilişki
        public virtual List<OrderDetail> OrderDetails { get; set; } 
    }
}
