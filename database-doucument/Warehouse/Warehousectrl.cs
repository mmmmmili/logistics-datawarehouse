using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express.Warehouse
{
   public class Warehousectrl:Utils
    {
       public static int getvolume(string warehouseNo)
        {
            string sql = "select volume from warehouse where wNo='" + warehouseNo + "'";
            return (int)execQuery(sql)[0][0];
        }
    }
}
