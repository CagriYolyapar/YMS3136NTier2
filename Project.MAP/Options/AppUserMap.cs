using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AppUserMap:BaseMap<AppUser>
    {
        public AppUserMap()
        {
            Property(x => x.UserName).HasColumnName("Kullanıcı Adı");
            Property(x => x.Password).HasColumnName("Parola");
            ToTable("Kullanıcılar");

            HasOptional(x => x.AppUserDetail).WithRequired(x => x.AppUser);





        }





    }
}
