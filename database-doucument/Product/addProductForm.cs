using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Express.Logistics;
using System.Collections;

namespace Express.Product
{
    public partial class addProductForm : Form
    {
        public addProductForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pNo = textBox1.Text;
            string pName = textBox2.Text;
            int v = 0;
            Productctrl.loadProduct(pNo, "",pName, listView1,ref v);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int v = 0;
            string add = comboBox1.Text;
            string wNo = (string)hs[add];
            Productctrl.loadProduct("", wNo,"", listView2,ref v);
            if (comboBox1.Text != "")
                label7.Text = v.ToString();
            else
                label7.Text = "";
        }

        Hashtable hs = Productctrl.listDept();
        private void addProductForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (DictionaryEntry de in hs)
            {
                comboBox1.Items.Add((string)de.Key);
            }
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("请输入件数！");
                return;
            }
            if (listView2.SelectedItems.Count != 1)
            {
                MessageBox.Show("请选择需要更改库存的产品");
                return;
            }
            ListViewItem li = this.listView2.SelectedItems[0];
            string pNo = li.SubItems[0].Text;
            int price=(int.Parse)(li.SubItems[3].Text);
            int x;
            try
            {
                x = int.Parse(textBox4.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return;
            }
            int volume = int.Parse(label7.Text);
            string add = comboBox1.Text;
            string wNo = (string)hs[add];
            int amount = Productctrl.sumamount(wNo);
            if(Productctrl.update(x, pNo, wNo, volume, amount)&&x>0)
                MessageBox.Show("产品进货成功！成本为"+price*x+"元");
            button2_Click(null, null);
            if (listView1.Items.Count != 0)
                button1_Click(null, null);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("请输入件数！");
                return;
            }
            ListViewItem li = this.listView1.SelectedItems[0];
            string pNo = li.SubItems[0].Text;
            int price = (int.Parse)(li.SubItems[6].Text);
            string wNo = li.SubItems[2].Text;
            int x;
            try
            {
                x = int.Parse(textBox4.Text);           
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
                return;
            }
            int amount = Productctrl.sumamount(wNo);
            int volume= int.Parse(li.SubItems[5].Text);
            if(Productctrl.update(x, pNo, wNo, volume, amount)&&x>0)
                MessageBox.Show("产品进货成功！成本为" + price * x + "元");
            button1_Click(null, null);
            if (listView2.Items.Count != 0)
                button2_Click(null, null);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
