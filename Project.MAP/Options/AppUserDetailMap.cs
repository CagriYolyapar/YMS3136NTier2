using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AppUserDetailMap:BaseMap<AppUserDetail>
    {
        public AppUserDetailMap()
        {
            Property(x => x.FirstName).HasColumnName("Adı");
            Property(x => x.LastName).HasColumnName("Soyadı");
            Property(x => x.IdentityNo).HasColumnName("Kimlik Numarası");
            ToTable("Kullanıcı Bilgileri");




        }




    }
}
