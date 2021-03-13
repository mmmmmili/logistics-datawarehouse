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

namespace Express
{
    public partial class IncomingFlow : Form
    {
        public IncomingFlow()
        {
            InitializeComponent();
        }

        private void IncomingFlow_Load(object sender, EventArgs e)
        {
            int total=0;
            Logistics.LogisticCtrl.loadIncomingFlow("","","",listView1,ref total);
            label7.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Clear();
            int total = 0;
            string year = textBox2.Text;
            string month = textBox3.Text;
            string day = textBox4.Text;
            if (!Logistics.LogisticCtrl.timeIsRight(year, month, day))
            {
                MessageBox.Show("日期不存在，请重新输入");
                return;
            }
            Logistics.LogisticCtrl.loadIncomingFlow(year,month,day,listView1, ref total);
            label7.Text = total.ToString();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("请选择一项");
                return;
            }
            String logiNo = listView1.SelectedItems[0].Text.ToString();
            DetailCtrl.loadFlowDetail(listView2, logiNo);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))    //判断输入数值是否为数字
            {
                MessageBox.Show("只能输入数字", "提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;                          
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))    //判断输入数值是否为数字
            {
                MessageBox.Show("只能输入数字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))    //判断输入数值是否为数字
            {
                MessageBox.Show("只能输入数字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }
    }
}
