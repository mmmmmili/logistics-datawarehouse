using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Express.Product
{
    public class Productctrl : Utils
    {
        public static Hashtable listDept()
        {
            string sql = "select wNo,address_out from warehouse ";
            List<object[]> ans = execQuery(sql);
            Hashtable htDept = new Hashtable();
            for (int i = 0; i < ans.Count; i++)
            {
                object[] oneDept = ans[i];
                htDept.Add(oneDept[1], oneDept[0]);
            }
            return htDept;
        }
        public static void loadProduct(string pNo, string wNo,string pName, ListView listView1,ref int v)
        {
            String sql = "select stock.pNo,pName,stock.wNo,address_out,amount,volume,price from stock inner join warehouse on stock.wNo=warehouse.wNo "+
                 "inner join product on product.pNo=stock.pNo where 1=1 ";
            if (pNo != "")
                sql += " and stock.pNo like '%"+pNo+"%' ";
            if (pName != "")
                sql += " and pName like '%" +pName+"%' ";
            string[] ch2 = { "产品编号", "产品名称", "仓库编号", "仓库地址", "货存量", "仓库容量", "产品单价" };
            Utils.fillListView(sql, listView1, ch2);
            if (wNo == "")
                return;
            if (wNo != null)
            {
                sql = "select volume from warehouse where wNo='" + wNo + "'";
                List<object[]> vol= execQuery(sql);
                v = (int)vol[0][0];
                sql = "select stock.pNo,pName,amount,price from stock inner join warehouse on warehouse.wNo=stock.wNo inner join product on "
                    +"product.pNo=stock.pNo where stock.wNo='" + wNo + "'";
                string[] ch1 = { "产品编号", "产品名称", "货存量", "产品单价" };
                Utils.fillListView(sql, listView1, ch1);
                return;
            }
        }
        public static void loadProduct(string pNo, string pName,ListView lv)
        {
            string sql = "select pNo,pName,price from product where 1=1 ";
            if(pNo!="")
                sql+=" and pNo like '%"+pNo + "%'";
            if (pName != "")
                sql += " and pName like '%" + pName + "%'";
            string [] ch = { "产品编号", "产品名称","产品单价" };
            fillListView(sql, lv, ch);
        }
        public static int sumamount(string wNo)
        {
            string sql = "select sum(amount) from stock where wNo='" + wNo + "'";
            List<object[]> x = execQuery(sql);
            return (int)x[0][0];
        }
        public static bool update(int x,string pNo,string wNo,int volume,int amount)
        {
            if (amount + x > volume)
            {
                MessageBox.Show("进货量超出仓库容量允许范围");
                return false;
            }
            else if (volume - x < 0)
            {
                MessageBox.Show("出货量大于产品现有件数");
                return false;
            }
            else if (volume - x == 0)
            {
                delete(pNo, wNo);
                MessageBox.Show("产品已完全出库！");
                return true;
            }
            string sql="update stock set amount=amount+ '" +x.ToString()+"' where pNo='"+pNo+"' and wNo='"+wNo+"'";
            return execNonQuery(sql);
        }
        public static bool delete(string pNo,string wNo)
        {
            string sql = "delete from stock where pNo='" + pNo + "' and wNo='" + wNo + "'";
            return execNonQuery(sql);
        }
        public static bool pricechange(string pNo,int price)
        {
            string sql = "update product set price='" + price.ToString() + "' where pNo='"+pNo+"'";
            return execNonQuery(sql);
        }
        public static bool productchange(string pNo,string pName)
        {
            string sql2 = "update product set pName='" + pName + "' where pNo='" + pNo + "'";
            if(pName!="")
            {
                execNonQuery(sql2);
                return true;
            }
            return false;
        }
       public static void loadunproduct(string wNo,ListView lv)
        {
            string sql="select pNo,pName,price from product where pNo not in(select pNo from stock where wNo='"+wNo+"')";
            string[] ch = { "产品编号", "产品名称", "产品单价" };
            fillListView(sql,lv,ch);
        }
        public static bool addproduct(string pNo,string wNo,int input,ref int money)
        {
            string sql = "select price from product where pNo='" + pNo + "'";
            List<object[]>x=execQuery(sql);
            money= (int)x[0][0] * input;
            sql = "insert into stock (pNo,wNo,amount) values('" + pNo + "','" + wNo + "','" + input + "')";
            return execNonQuery(sql);
        }
        public static string searchwNo(string pNo)
        {
            string sql = "select wNo from logistic inner join detail on detail.INo=logistic.INo where detail.pNo='" + pNo + "'";
                List<object[]> w=execQuery(pNo);
            return w.ToString();
        }
        public static int searchprice(string pNo)
        {
            string sql = "select price from product where pNo='" + pNo + "'";
            return (int)execQuery(sql)[0][0];
        }
    }
}
