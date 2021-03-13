using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express.Express
{
    public class Expressctrl:Utils
    {
        public static int searchecost(string eNo)
        {
            string sql = "select cost from express where eNo='" + eNo + "'";
            return (int)execQuery(sql)[0][0];
        }
    }
}
