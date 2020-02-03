using Project.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.SingeltonPattern
{
   public class DBTool
    {
         DBTool()
        {

        }
     static   MyContext _dbInstace;
     public static   MyContext DBInstance
        {
            get
            {
                if(_dbInstace == null)
                {
                    _dbInstace = new MyContext();
                }
                return _dbInstace;
            }
        }
    }
}
