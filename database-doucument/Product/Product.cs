using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express.Product
{
    public class Product
    {
        string pNo, pName;
        int price;
         public Product(string pNo,string pName,int price)
        {
            this.pNo = pNo;
            this.pName = pName;
            this.price = price;
        }
    }
}
