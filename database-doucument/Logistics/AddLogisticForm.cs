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
using Express.Product;
using Express.Detail;

namespace Express.Logistics
{
    public partial class AddLogisticsForm : Form
    {

        Hashtable htWareHouse;
        public AddLogisticsForm()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
        List<ListViewItem> choose = new List<ListViewItem>();
        string chooseWNo = "";
        string companyNo = "";

        private void Button1_Click(object sender, EventArgs e)
        {
            string warehouseNo = (string)htWareHouse[comboBox1.Text];
            LogisticCtrl.loadProduct(warehouseNo, listView1);
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (choose.Count ==0)
            {
                MessageBox.Show("请你添加商品");
                return;
            }
            string addressee = textBox1.Text;
            string logiNo= textBox4.Text;
            string time = textBox2.Text;
            string warehouseNo = chooseWNo;
            string address_in = textBox3.Text;
            if (logiNo==""|| time==""|| addressee == ""|| address_in=="")
            {
                MessageBox.Show("请完整填写信息");
                return;
            }
            Logistic temp = new Logistic(logiNo, companyNo, warehouseNo, time, addressee, address_in);
            if (LogisticCtrl.saveLogistic(temp) == false)
            {
                MessageBox.Show("添加快递单出错");
                return;
            }
            for (int i = 0; i < choose.Count; i++)
            {
                Detail.Detail  detail = new Detail.Detail(logiNo, choose[i].SubItems[0].Text, choose[i].SubItems[5].Text);
                if (DetailCtrl.saveDetail(detail) == false)
                {
                    LogisticCtrl.recoverStock(choose[i].SubItems[0].Text, warehouseNo, choose[i].SubItems[5].Text);
                    MessageBox.Show("添加快递流水出错");
                    return;
                }
            }
            choose.Clear();
            Button4_Click(null, null);
            MessageBox.Show("添加成功");
            return;
        }
       
        private void AddLogisticsForm_Load(object sender, EventArgs e)
        {
            htWareHouse = LogisticCtrl.listWarehouse();
            comboBox1.Items.Clear();
            foreach (DictionaryEntry de in htWareHouse)
            {
                comboBox1.Items.Add((string)de.Key);
            }
            LogisticCtrl.loadProduct(null, listView1);
            LogisticCtrl.loadCompany(listView2);
            LogisticCtrl.loadReadyToChoose(listView4);
            choose.Clear();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {

        }

        

        private void ListView3_Click(object sender, EventArgs e)
        {

        }

      
        private void Button3_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("请你指定一种商品");
                return;
            }
            if (this.listView2.SelectedItems.Count != 1)
            {
                MessageBox.Show("请你指定一家快递公司");
                return;
            }
            string numberWanted = textBox5.Text;
            if (numberWanted =="")
            {
                MessageBox.Show("请输入商品数量");
                return;
            }
            string thingsNo = listView1.SelectedItems[0].Text.ToString();
            string warehouseNo = listView1.SelectedItems[0].SubItems[2].Text;
            string totalNumber = listView1.SelectedItems[0].SubItems[4].Text;
           
            if(int.Parse(numberWanted) > int.Parse(totalNumber))
            {
                MessageBox.Show("该商品数量不够");
                return;
            }
            if (choose.Count == 0) {
                chooseWNo = warehouseNo;
                companyNo= listView2.SelectedItems[0].Text.ToString();
            }
            else if (chooseWNo != warehouseNo)
            {
                MessageBox.Show("本订单只能选择一个发货地址");
                return;
            }
            else if(companyNo!= listView2.SelectedItems[0].Text.ToString())
            {
                MessageBox.Show("本订单只能选择一家快递公司");
                return;
            }
            string number = (-int.Parse(numberWanted) + int.Parse(totalNumber)).ToString();
            if (LogisticCtrl.updateStock(thingsNo, warehouseNo, number) == false)
            {
                MessageBox.Show("加入失败");
                return;
            }
            int p = Productctrl.searchprice(thingsNo);
            for (int i = 0; i < choose.Count; i++)
                if (thingsNo == choose[i].SubItems[0].Text)
                {
                    ListViewItem listItem1 = choose[i];
                    listItem1.SubItems[5].Text = (int.Parse(choose[i].SubItems[5].Text) + int.Parse(numberWanted)).ToString();
                    listItem1.SubItems[6].Text= (int.Parse(choose[i].SubItems[5].Text) * p).ToString();
                    LogisticCtrl.loadReadyToChoose(listView4);
                    for (int j = 0; j < choose.Count; j++)
                        listView4.Items.Add(choose[j]);
                    Button1_Click(null, null);
                    return;
                }
            ListViewItem li = new ListViewItem();//形成一个表项
            li.SubItems.Clear();
            li.SubItems[0].Text = thingsNo; //设置第一列
            li.SubItems.Add(listView1.SelectedItems[0].SubItems[1].Text); //其余的列
            li.SubItems.Add(warehouseNo); //其余的列
            li.SubItems.Add(listView1.SelectedItems[0].SubItems[3].Text); //其余的列
            li.SubItems.Add(listView2.SelectedItems[0].SubItems[1].Text);//其余的列
            li.SubItems.Add(numberWanted); //其余的列
            string price = (int.Parse(numberWanted)*p).ToString();
            //string cost = int.Parse(this.listView2.SelectedItems[0].SubItems[2].Text).ToString();
            //string totalcost = (int.Parse(price) + int.Parse(cost)).ToString();
            li.SubItems.Add(price);
            //li.SubItems.Add(cost);
            //li.SubItems.Add(totalcost);
            listView4.Items.Add(li);
            choose.Add(li);
            Button1_Click(null, null);
        }

        private void ListView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView4_DoubleClick(object sender, EventArgs e)
        {
            
            
            string thingsNo = listView4.SelectedItems[0].Text.ToString();
            string warehouseNo = listView4.SelectedItems[0].SubItems[2].Text;
            string numberWanted = listView4.SelectedItems[0].SubItems[4].Text;
            choose.Remove(listView4.SelectedItems[0]);
            LogisticCtrl.recoverStock(thingsNo, warehouseNo, numberWanted);
            LogisticCtrl.loadReadyToChoose(listView4);
            for (int i=0;i< choose.Count; i++)
            {
                listView4.Items.Add(choose[i]);
            }
            Button1_Click(null, null);
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < choose.Count; i++)
            {
                ListViewItem li = choose[i];
                string thingsNo = li.Text.ToString();
                string warehouseNo = li.SubItems[2].Text;
                string numberWanted = li.SubItems[5].Text;
                LogisticCtrl.recoverStock(thingsNo, warehouseNo, numberWanted);
            }
            LogisticCtrl.loadReadyToChoose(listView4);
            choose.Clear();
            Button1_Click(null, null);
        }

        private void AddLogisticsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //捕捉窗体Close事件,关闭窗口时提示
            if (choose.Count == 0) return;
            if (MessageBox.Show("请您确认是否退出(Y/N),如果退出,备选栏将自动清空", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Button4_Click(null, null);
                e.Cancel = false;//允许退出系统

            }
            else
            {
                e.Cancel = true;//阻止退出系统
            }
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void 查询产品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProductForm newwin = new addProductForm();
            newwin.ShowDialog();
        }


        

        private void 进账流水ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            IncomingFlow flow = new IncomingFlow();
            flow.ShowDialog();
        }

        private void 物流信息ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangeLogisticForm newwin = new ChangeLogisticForm();
            newwin.ShowDialog();
        }

        private void 添加库存ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PricechangeForm newwin = new PricechangeForm();
            newwin.ShowDialog();
        }

        private void 加入仓库新产品ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            newproductForm newwin = new newproductForm();
            newwin.ShowDialog();
        }

        private void oleDbConnection2_InfoMessage(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
        {

        }
    }
}
