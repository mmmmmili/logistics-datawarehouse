using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express.Logistics
{
    public class Logistic
    {
        public string lNo, eNo, wNo, time, addressee, address_in;
        public Logistic(string lNo, string eNo, string wNo, string time,string addressee, string address_in)
        {
            this.lNo = lNo;
            this.eNo = eNo;
            this.wNo = wNo;
            this.time = time;
            this.addressee = addressee;
            this.address_in = address_in;
        }       
    }
}
