using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Express.Product
{
    public partial class PricechangeForm : Form
    {
        public PricechangeForm()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int price;
            if (textBox3.Text == "")
            {
                MessageBox.Show("请输入更改后的价格");
                return;
            }
            try
            {
                price = int.Parse(textBox3.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return;
            }
            if (price<=0)
            {
                MessageBox.Show("产品价格不能为负！");
                return;
            }
            if(this.listView1.SelectedItems.Count!=1)
            {
                MessageBox.Show("请选择需要修改单价产品");
                return;
            }
            string pNo=listView1.SelectedItems[0].Text.ToString();
            if(Productctrl.pricechange(pNo, price))
                MessageBox.Show("单价修改成功");
            button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pNo = textBox1.Text;
            string pName = textBox2.Text;
            Productctrl.loadProduct(pNo, pName, listView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("请选择需要修改信息的产品");
                return;
            }            
            string pNo = this.listView1.SelectedItems[0].Text.ToString();
            string pName = textBox5.Text;
            if (Productctrl.productchange(pNo,pName))
                MessageBox.Show("产品信息修改成功");
            else
                MessageBox.Show("请输入产品名称");
            button1_Click(null, null);
        }
    }
}
