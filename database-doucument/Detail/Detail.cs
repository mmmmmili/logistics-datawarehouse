using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express.Detail
{
    public class Detail
    {
        public string lNo, pNo, number;
        public Detail(string lNo, string pNo, string number)
        {
            this.lNo = lNo;
            this.pNo = pNo;
            this.number = number;
        }
    }
}
