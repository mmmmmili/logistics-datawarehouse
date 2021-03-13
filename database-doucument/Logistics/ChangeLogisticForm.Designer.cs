namespace Express.Logistics
{
    partial class ChangeLogisticForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView4 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView3);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1254, 283);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快递单";
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(14, 24);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(1224, 253);
            this.listView3.TabIndex = 28;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.ListView3_SelectedIndexChanged);
            this.listView3.ClientSizeChanged += new System.EventHandler(this.ListView3_ClientSizeChanged);
            this.listView3.Click += new System.EventHandler(this.ListView3_Click);
            this.listView3.DoubleClick += new System.EventHandler(this.ListView3_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView4);
            this.groupBox4.Location = new System.Drawing.Point(21, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(889, 254);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "详细信息";
            // 
            // listView4
            // 
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(14, 22);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(857, 212);
            this.listView4.TabIndex = 28;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.DoubleClick += new System.EventHandler(this.listView4_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(939, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "双击删除快递信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(939, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "单机查看详细信息";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ChangeLogisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChangeLogisticForm";
            this.Text = "ChangeLogisticForm";
            this.Load += new System.EventHandler(this.ChangeLogisticForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}