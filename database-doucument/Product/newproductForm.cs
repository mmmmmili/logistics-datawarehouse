using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Express.Product
{
    public partial class newproductForm : Form
    {
        public newproductForm()
        {
            InitializeComponent();
        }
        Hashtable hs = Productctrl.listDept();
        private void newproduct_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (DictionaryEntry de in hs)
            {
                comboBox1.Items.Add((string)de.Key);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wName = comboBox1.Text;
            string wNo = (string)hs[wName];
            if(wNo==null)
            {
                MessageBox.Show("请选择仓库地址");
                return;
            }
            int v = 0;
            Productctrl.loadProduct("", wNo, "", listView2, ref v);
            Productctrl.loadunproduct(wNo, listView1);
            label6.Text = v.ToString();
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count != 1)
            {
                MessageBox.Show("请选择需要删除的产品");
                return;
            }
            string pNo = this.listView2.SelectedItems[0].Text.ToString();
            string wName = comboBox1.Text;
            string wNo = (string)hs[wName];
            if(Productctrl.delete(pNo,wNo))
            {
                MessageBox.Show("产品删除成功！");
            }
            button1_Click(null, null);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int input, volume;
            if (textBox4.Text == "")
            {
                MessageBox.Show("请输入产品数量！");
                return; 
            }
            try
            {
                input = int.Parse(textBox4.Text);
                volume = int.Parse(label6.Text);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
                return;
            }
                     
            string wName = comboBox1.Text;
            string wNo = (string)hs[wName];
            int amount = Productctrl.sumamount(wNo);            
            if (input < 0)
            {
                MessageBox.Show("添加件数不可为负！");
                return;
            }
            if (input + amount > volume)
            {
                MessageBox.Show("添加件数超过仓库容量允许范围");
                return;
            }
            if(this.listView1.SelectedItems.Count!=1)
            {
                MessageBox.Show("请选择一个产品");
                return;
            }
            string pNo = this.listView1.SelectedItems[0].Text.ToString();
            int money=0;
            if(Productctrl.addproduct(pNo, wNo, input,ref money))
                MessageBox.Show("产品添加成功！成本为"+money.ToString()+"元");
            button1_Click(null, null);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
