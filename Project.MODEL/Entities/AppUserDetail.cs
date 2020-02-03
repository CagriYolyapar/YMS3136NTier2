using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class AppUserDetail:BaseEntity
    {
        public AppUserDetail()
        {

        }
        public AppUserDetail(string fName,string lName,string identityNo)
        {
            FirstName = fName;
            LastName = lName;
            IdentityNo = identityNo;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNo { get; set; }

        //Relational Properties begin...
        public virtual AppUser AppUser { get; set; }//birebir ilişki
    }
}
