using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class AppUser:BaseEntity
    {
        public AppUser()
        {

        }
        public AppUser(string name,string pass,string mail)
        {
            UserName = name;
            Password = pass;
            Email = mail;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        //Relational Properties begin...
        public virtual AppUserDetail AppUserDetail { get; set; }//AppUser ile birebir ilişki
        public virtual List<Order> Orders { get; set; } //Order ile bire çok ilişki
    }
}
