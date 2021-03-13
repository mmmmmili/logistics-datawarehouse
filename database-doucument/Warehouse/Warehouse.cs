using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express.Warehouse
{
    public class Warehouse
    {
        string wNo, address_out;
        int volume=0;
        public Warehouse(string wNo, string address, int volume)
        {
            this.volume = volume;
            this.wNo = wNo;
            this.address_out = address;
        }
    }
}
