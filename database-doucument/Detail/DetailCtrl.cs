using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Express.Logistics;

namespace Express.Detail
{
    public class DetailCtrl:Utils
    {
        public static bool deleteDetail(string logiNo)
        {

            String sql = " delete from  detail " +
            " where lNo ='" + logiNo + "'";
            return execNonQuery(sql);
        }
        public static int lnum(string lNo)
        {
            string sql = "select pNo from detail where lNo='" + lNo + "'";
            return execQuery(sql).Count;
        }
        public static bool deleteDetail(string lNo, string pNo, string num, string wNo)
        {
            if (lnum(lNo) == 1)
            {
                return LogisticCtrl.deleteLogistic(lNo);
            }
            LogisticCtrl.recoverStock(pNo, wNo, num);
            string sql = "delete from detail where lNo='" + lNo + "' and pNo='" + pNo + "'";
            return execNonQuery(sql);
        }
        public static bool saveDetail(Detail d)
        {

            String sql = "insert into detail( lNo, pNo, number)";
            sql += "  values('" +d.lNo + "', '" + d.pNo;
            sql += "', '" + d.number + "')";
            return execNonQuery(sql);
        }
        public static void loadDetail(ListView listView, string logiNo)
        {
            String sql = " SELECT d.pNo,p.pName,d.number,p.price*d.number FROM detail d inner join product p on p.pNo = d.pNo ";
            sql += " where d.lNo='" + logiNo + "'";
            string[] ch = { "产品编号", "产品名称", "数量" ,"产品费用"};
            Utils.fillListView(sql, listView, ch);
        }
        public static void loadFlowDetail(ListView listView, string logiNo)
        {
            String sql = " SELECT d.pNo,p.pName,d.number,address_out FROM detail d " +
                " inner join product p on p.pNo = d.pNo inner join logistic l on l.lNo=d.lNo inner join warehouse w on w.wNo=l.wNo ";
            sql += " where d.lNo='" + logiNo + "'";
            string[] ch = { "产品编号", "产品名称", "数量", "仓库地点" };
            Utils.fillListView(sql, listView, ch);
            listView.Columns[3].Width = 100;
        }
    }
}
