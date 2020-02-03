﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Shipper:BaseEntity
    {
        public Shipper()
        {
                
        }
        public Shipper(string name,string phone)
        {
            CompanyName = name;
            Phone = phone;
        }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        //Relational Properties begin...
        public virtual List<Order> Orders { get; set; }// Shipper ile bire çok ilişki 

    }
}
