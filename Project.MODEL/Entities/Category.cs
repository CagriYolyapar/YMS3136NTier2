using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Category:BaseEntity
    {
        public Category()
        {

        }
        public Category(string name,string desc)
        {
            CategoryName = name;
            Description = desc;
        }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        //Relational Properties begin...
        public virtual List<Product> Products { get; set; }//Category ile bire çok ilişki
    }
}
