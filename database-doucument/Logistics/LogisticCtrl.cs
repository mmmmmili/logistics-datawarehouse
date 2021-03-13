using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using Express.Product;
using Express.Detail;
using Express.Express;
using Express.Warehouse;


namespace Express.Logistics
{
    public class LogisticCtrl:Utils
    {
        public static bool saveLogistic(Logistic s)
        {
            String sql = "insert into logistic( lNo, eNo, wNo, time, addressee, address_in)";
            sql += "  values('" + s.lNo + "', '" + s.eNo;
            sql += "', '" + s.wNo + "', '" + s.time + "', '" + s.addressee;
            sql +="', '" + s.address_in + "')";        
            return execNonQuery(sql);
        }
        public static Hashtable listWarehouse()
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
        public static bool deleteLogistic(string logiNo)
        {
            LogisticCtrl.recoverStock(logiNo);
            String sql = " delete from  logistic " +
            " where lNo ='" + logiNo+"'";
            DetailCtrl.deleteDetail(logiNo);
            return execNonQuery(sql);
        }
        public static void loadProduct(string warehouseNo,ListView listView1)
        {
            
            String sql = "SELECT stock.pNo,product.pName,stock.wNo,warehouse.address_out,amount " +
             " FROM stock inner join warehouse on warehouse.wNo=stock.wNo " +
              " inner join product on product.pNo=stock.pNo " +
             "where 1=1 ";
            if (warehouseNo != "")
            {
                sql += " and stock.wNo like '" + warehouseNo + "%'";
            }
            
            string[] ch = { "产品编号","产品名称", "仓库编号", "仓库地址", "货存量" };
            Utils.fillListView(sql, listView1, ch);
        }
        public static void loadCompany(ListView listView2)
        {
            String sql = "SELECT eNo,eName,cost " +
             " FROM express ";            
            string[] ch = { "公司编号", "公司名称", "单价" };
            Utils.fillListView(sql, listView2, ch);
        }
        public static void loadLogistic(ListView listView3)
        {
            listView3.Clear();
            List<object[]> lv = new List<object[]>();
            String sql = "SELECT  logistic.lNo, express.eName, warehouse.address_out, time, addressee, address_in,express.cost,sum(product.price*detail.number),sum(express.cost+product.price*detail.number)" +
             " FROM logistic inner join express on express.eNo=logistic.eNo " +
             "inner join detail on detail.lNo=logistic.lNo inner join warehouse on warehouse.wNo=logistic.wNo inner join product on product.pNo=detail.pNo "+
             "group by logistic.lNo,express.ename,warehouse.address_out,logistic.time,logistic.addressee,logistic.address_in,express.cost";
            string[] ch = { "快递单编号", "快递公司名称", "仓库名称", "时间", "收货人", "收货地址", "快递费用", "产品费用", "总费用" };
            fillListView(sql, listView3, ch);
            listView3.Columns[2].Width = 150;
            listView3.Columns[3].Width = 150;
            listView3.Columns[5].Width = 130;
        }

        public static void loadIncomingFlow(string year,string month,string day,ListView listview1,ref int total)
        {
            listview1.Clear();
            List<object[]> lv = new List<object[]>();
            String sql = "select logistic.lNo,time,sum(product.price*detail.number) " +
                "from logistic inner join detail on detail.lNo=logistic.lNo inner join product on product.pNo=detail.pNo where 1=1 ";
            if (year != "")
                sql += " and YEAR(time)='" + year + "' ";
            if (month != "")
                sql += " and MONTH(time)='" + month + "' ";
            if (day != "")
                sql += " and DAY(time)='" + day + "' ";
            sql += " group by logistic.lNo,time ";
            string[] ch = { "快递单编号", "时间", "产品费用" };
            fillListView(sql, listview1, ch);
            listview1.Columns[1].Width = 150;
            string sql1 = "select sum(product.price*detail.number) " +
                "from detail inner join product on product.pNo=detail.pNo inner join logistic on logistic.lNo=detail.lNo where 1=1 ";
            if (year != "")
                sql1 += " and YEAR(time)='" + year + "' ";
            if (month != "")
                sql1 += " and MONTH(time)='" + month + "' ";
            if (day != "")
                sql1 += " and DAY(time)='" + day + "'";
            List<object[]> vol = execQuery(sql1);
            if(vol[0][0]!=System.DBNull.Value)
                total = (int)vol[0][0];
        }

        public static void loadReadyToChoose(ListView lv)//listView4
        {
            lv.View = View.Details;    //定义列表显示的方式
            lv.MultiSelect = false; // 不可以多行选择
            lv.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv.Visible = true;
            lv.GridLines = true;//画表格线
            lv.FullRowSelect = true;//点击时整行选中
            lv.Columns.Clear(); //将原有的列清空
            lv.Items.Clear();// 将原有的行清空
            string[] ch = { "产品编号", "产品名称", "仓库编号", "仓库地址", "快递公司","数量" ,"产品费用"};
            if (ch != null)
                for (int i = 0; i < ch.Length; i++)
                { // 设置表头信息
                    lv.Columns.Add(ch[i], 80,
                    HorizontalAlignment.Center);
                }
            lv.Columns[3].Width = 150;
        }

        public static bool updateStock(string thingsNo, string warehouseNo, string number)
        {
            String sql = "update stock set amount='" + number +"' where pNo='"+thingsNo+"' and wNo='"+warehouseNo+"' ";
            return execNonQuery(sql);
        }
        public static bool recoverStock(string thingsNo, string warehouseNo, string numberWanted)
        {
            String sql1 = "select amount from stock where pNo='" + thingsNo + "' and wNo='" + warehouseNo + "' ";
            List<object[]> temp = execQuery(sql1);
            string number;
            if (temp.Count == 0)
            {
                number = numberWanted;
            }
            else
                number = (int.Parse(numberWanted) + (int)temp[0][0]).ToString();
            int volume = Warehousectrl.getvolume(warehouseNo);
            if (int.Parse(number) > volume)
                MessageBox.Show("仓库容量溢出！");
            String sql = "update stock set amount='" + number + "' where pNo='" + thingsNo + "' and wNo='" + warehouseNo + "' ";
            return execNonQuery(sql);
        }

        public static void recoverStock(string lNo)
        {
            string wNo = findWNo(lNo);
            String sql1 = "select pNo,number from detail where lNo='" + lNo + "' ";
            List<object[]> temp = execQuery(sql1);
            for(int i = 0; i < temp.Count; i++)
            {
                recoverStock((string)temp[i][0], wNo, (temp[i][1]).ToString());
            }
        }
        public static string findWNo(string logiNo)
        {
            String sql1 = "select wNo from logistic where lNo='" + logiNo +"' ";
            List<object[]> temp = execQuery(sql1);
            return (string)temp[0][0];
        }

        public static bool timeIsRight(string year, string month, string day)
        {
            if (month != "")
            {
                int m = int.Parse(month);
                if (day != "")
                {
                    int d = int.Parse(day);
                    if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                    {
                        if (d >= 1 && d <= 31)
                            return true;
                        return false;
                    }
                    else if (m == 2)
                    {
                        if (year != "")
                        {
                            int y = int.Parse(year);
                            if (y % 4 == 0 && y % 100 != 0 || y % 100 == 0 && (y / 100) % 4 == 0)
                            {
                                if (d >= 1 && d <= 29)
                                    return true;
                                return false;
                            }
                            else
                            {
                                if (d >= 1 && d <= 28)
                                    return true;
                                return false;
                            } 
                        }
                        if (d >= 1 && d <= 29)
                            return true;
                        return false;
                    }
                    else if (m == 4 || m == 6 || m == 9 || m == 11)
                    {
                        if (d >= 1 && d <= 30)
                            return true;
                        return false;
                    }
                    else
                        return false;
                }
                if (m >= 1 && m <= 12)
                    return true;
                return false; 
            }
            if (day != "")
            {
                int d = int.Parse(day);
                if (d >= 1 && d <= 31)
                    return true;
                return false;
            }
            return true;
        }
    }
}
