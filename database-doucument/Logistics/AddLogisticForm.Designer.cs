namespace Express.Logistics
{
    partial class AddLogisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView4 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.物流信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询产品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加库存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加入仓库新产品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进账流水ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView2);
            this.groupBox3.Location = new System.Drawing.Point(964, 62);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(468, 374);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "快递公司";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(22, 29);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(437, 327);
            this.listView2.TabIndex = 28;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.ListView2_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(309, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(648, 374);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "商品信息";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 29);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(620, 327);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.ListView1_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "收货地址";
            this.label5.Click += new System.EventHandler(this.Label5_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 520);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 28);
            this.textBox3.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "发货日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "仓库地点";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 478);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 28);
            this.textBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 116);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 26);
            this.comboBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "查询仓库商品";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 668);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 37);
            this.button2.TabIndex = 26;
            this.button2.Text = "生成快递单";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 611);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "快递单编号";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 611);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 28);
            this.textBox4.TabIndex = 28;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView4);
            this.groupBox4.Location = new System.Drawing.Point(309, 444);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(1123, 358);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "备选栏";
            // 
            // listView4
            // 
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(20, 26);
            this.listView4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(1094, 323);
            this.listView4.TabIndex = 28;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.SelectedIndexChanged += new System.EventHandler(this.ListView4_SelectedIndexChanged);
            this.listView4.DoubleClick += new System.EventHandler(this.ListView4_DoubleClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 346);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 37);
            this.button3.TabIndex = 31;
            this.button3.Text = "加入备选栏";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "数量";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(138, 284);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 28);
            this.textBox5.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "收货人姓名";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 565);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 28);
            this.textBox1.TabIndex = 34;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(129, 400);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 37);
            this.button4.TabIndex = 36;
            this.button4.Text = "清空备选栏";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.产品管理ToolStripMenuItem,
            this.进账流水ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1467, 32);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.物流信息ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 28);
            this.toolStripMenuItem1.Text = "物流信息";
            // 
            // 物流信息ToolStripMenuItem
            // 
            this.物流信息ToolStripMenuItem.Name = "物流信息ToolStripMenuItem";
            this.物流信息ToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.物流信息ToolStripMenuItem.Text = "查看/修改物流信息";
            this.物流信息ToolStripMenuItem.Click += new System.EventHandler(this.物流信息ToolStripMenuItem_Click_1);
            // 
            // 产品管理ToolStripMenuItem
            // 
            this.产品管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询产品ToolStripMenuItem,
            this.添加库存ToolStripMenuItem,
            this.加入仓库新产品ToolStripMenuItem});
            this.产品管理ToolStripMenuItem.Name = "产品管理ToolStripMenuItem";
            this.产品管理ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.产品管理ToolStripMenuItem.Text = "产品管理";
            // 
            // 查询产品ToolStripMenuItem
            // 
            this.查询产品ToolStripMenuItem.Name = "查询产品ToolStripMenuItem";
            this.查询产品ToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.查询产品ToolStripMenuItem.Text = "仓库产品查询";
            this.查询产品ToolStripMenuItem.Click += new System.EventHandler(this.查询产品ToolStripMenuItem_Click);
            // 
            // 添加库存ToolStripMenuItem
            // 
            this.添加库存ToolStripMenuItem.Name = "添加库存ToolStripMenuItem";
            this.添加库存ToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.添加库存ToolStripMenuItem.Text = "产品信息修改";
            this.添加库存ToolStripMenuItem.Click += new System.EventHandler(this.添加库存ToolStripMenuItem_Click_1);
            // 
            // 加入仓库新产品ToolStripMenuItem
            // 
            this.加入仓库新产品ToolStripMenuItem.Name = "加入仓库新产品ToolStripMenuItem";
            this.加入仓库新产品ToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.加入仓库新产品ToolStripMenuItem.Text = "加入仓库新产品";
            this.加入仓库新产品ToolStripMenuItem.Click += new System.EventHandler(this.加入仓库新产品ToolStripMenuItem_Click_1);
            // 
            // 进账流水ToolStripMenuItem1
            // 
            this.进账流水ToolStripMenuItem1.Name = "进账流水ToolStripMenuItem1";
            this.进账流水ToolStripMenuItem1.Size = new System.Drawing.Size(94, 28);
            this.进账流水ToolStripMenuItem1.Text = "进账流水";
            this.进账流水ToolStripMenuItem1.Click += new System.EventHandler(this.进账流水ToolStripMenuItem1_Click_1);
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=LAPTOP-I4PL8JVA\\MSSQLSERVER1;Integrated Security=S" +
    "SPI;Initial Catalog=Company";
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.InfoMessage += new System.Data.OleDb.OleDbInfoMessageEventHandler(this.oleDbConnection2_InfoMessage);
            // 
            // AddLogisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 847);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddLogisticsForm";
            this.Text = "AddLogisticsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddLogisticsForm_FormClosing);
            this.Load += new System.EventHandler(this.AddLogisticsForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 产品管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询产品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加库存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加入仓库新产品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 物流信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进账流水ToolStripMenuItem1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbConnection oleDbConnection2;
    }
}