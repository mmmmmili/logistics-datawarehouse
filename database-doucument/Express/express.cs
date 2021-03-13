using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express.Express
{
    public class express
    {
        string eNo;
        string eName;
        int cost=0;
        express(string eNo,string eName,int cost)
        {
            this.eNo = eNo;
            this.eName = eName;
            this.cost = cost;
        }
    }
}
