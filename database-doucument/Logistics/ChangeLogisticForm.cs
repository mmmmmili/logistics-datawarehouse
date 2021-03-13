using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Express.Detail;
using System.Collections;
using Express.Product;

namespace Express.Logistics
{
    public partial class ChangeLogisticForm : Form
    {
        public ChangeLogisticForm()
        {
            InitializeComponent();
        }

        private void ListView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView3_DoubleClick(object sender, EventArgs e)
        {
            DateTime t1 = Convert.ToDateTime(listView3.SelectedItems[0].SubItems[3].Text).Date;
            DateTime t2 = DateTime.Now.Date;
            if (DateTime.Compare(t1, t2) <= 0)
            {
                MessageBox.Show("此快递单不能修改");
                return;
            }
            String logiNo = listView3.SelectedItems[0].Text.ToString();
            LogisticCtrl.deleteLogistic(logiNo);
            LogisticCtrl.loadLogistic(listView3);
            DetailCtrl.loadDetail(listView4, null);
            MessageBox.Show("已删除");
        }

        private void ChangeLogisticForm_Load(object sender, EventArgs e)
        {
            LogisticCtrl.loadLogistic(listView3);
        }

        private void ListView3_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void ListView3_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count != 1)
            {
                MessageBox.Show("请选择一个快递单");
                return;
            }
            String logiNo = listView3.SelectedItems[0].Text.ToString();
            DetailCtrl.loadDetail(listView4,logiNo);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void listView4_DoubleClick(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count != 1||listView3.SelectedItems.Count != 1)
            {
                MessageBox.Show("请选择要删除的产品和订单");
                return;
            }
            DateTime t1 = Convert.ToDateTime(listView3.SelectedItems[0].SubItems[3].Text).Date;
            DateTime t2 = DateTime.Now.Date;
            if (DateTime.Compare(t1, t2) <= 0)
            {
                MessageBox.Show("此快递单不能修改");
                return;
            }
            string lNo = this.listView3.SelectedItems[0].SubItems[0].Text.ToString();
            string wName = this.listView3.SelectedItems[0].SubItems[2].Text.ToString();
            string pNo = this.listView4.SelectedItems[0].SubItems[0].Text.ToString();
            string num = this.listView4.SelectedItems[0].SubItems[2].Text.ToString();
            Hashtable hs = Productctrl.listDept();
            string wNo = (string)hs[wName];
           if( DetailCtrl.deleteDetail(lNo, pNo, num, wNo))
                MessageBox.Show("删除产品成功！");
            ListView3_Click(null, null);
            if (DetailCtrl.lnum(lNo) == 0)
                LogisticCtrl.loadLogistic(listView3);
        }
    }
}
