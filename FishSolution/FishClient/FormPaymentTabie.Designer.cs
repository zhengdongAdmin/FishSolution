namespace FishClient
{
    partial class FormPaymentTabie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acountNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numbering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 241);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 201);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeight = 45;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createMan,
            this.codeOne,
            this.state,
            this.applyDate,
            this.price,
            this.weight,
            this.jine,
            this.paymentDate,
            this.paymentMethod,
            this.purchasecode,
            this.acountNum,
            this.unit,
            this.contacts,
            this.backDeposit,
            this.paymentType,
            this.invoiceType,
            this.Numbering,
            this.applyCode,
            this.remark});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 30;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(771, 201);
            this.dataGridView2.TabIndex = 207;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 40);
            this.panel2.TabIndex = 0;
            // 
            // createMan
            // 
            this.createMan.DataPropertyName = "createMan";
            this.createMan.HeaderText = "所属人";
            this.createMan.Name = "createMan";
            this.createMan.ReadOnly = true;
            // 
            // codeOne
            // 
            this.codeOne.DataPropertyName = "code";
            this.codeOne.HeaderText = "单号";
            this.codeOne.Name = "codeOne";
            this.codeOne.ReadOnly = true;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "审核";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.state.Width = 60;
            // 
            // applyDate
            // 
            this.applyDate.DataPropertyName = "applyDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.applyDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.applyDate.HeaderText = "申请日期";
            this.applyDate.Name = "applyDate";
            this.applyDate.ReadOnly = true;
            this.applyDate.Width = 80;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "货品单价";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 80;
            // 
            // weight
            // 
            this.weight.DataPropertyName = "weight";
            this.weight.HeaderText = "货品重量";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.Width = 80;
            // 
            // jine
            // 
            this.jine.DataPropertyName = "jine";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.jine.DefaultCellStyle = dataGridViewCellStyle2;
            this.jine.HeaderText = "货品金额";
            this.jine.Name = "jine";
            this.jine.ReadOnly = true;
            this.jine.Width = 80;
            // 
            // paymentDate
            // 
            this.paymentDate.DataPropertyName = "paymentDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.paymentDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.paymentDate.HeaderText = "付款日期";
            this.paymentDate.Name = "paymentDate";
            this.paymentDate.ReadOnly = true;
            this.paymentDate.Width = 80;
            // 
            // paymentMethod
            // 
            this.paymentMethod.DataPropertyName = "paymentMethod";
            this.paymentMethod.HeaderText = "付款方式";
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.ReadOnly = true;
            this.paymentMethod.Width = 80;
            // 
            // purchasecode
            // 
            this.purchasecode.DataPropertyName = "purchasecode";
            this.purchasecode.HeaderText = "采购合同号";
            this.purchasecode.Name = "purchasecode";
            this.purchasecode.ReadOnly = true;
            // 
            // acountNum
            // 
            this.acountNum.DataPropertyName = "acountNum";
            this.acountNum.HeaderText = "帐号";
            this.acountNum.Name = "acountNum";
            this.acountNum.ReadOnly = true;
            this.acountNum.Width = 60;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "单位名称";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 80;
            // 
            // contacts
            // 
            this.contacts.DataPropertyName = "contacts";
            this.contacts.HeaderText = "联系人";
            this.contacts.Name = "contacts";
            this.contacts.ReadOnly = true;
            this.contacts.Width = 70;
            // 
            // backDeposit
            // 
            this.backDeposit.DataPropertyName = "backDeposit";
            this.backDeposit.HeaderText = "开户行";
            this.backDeposit.Name = "backDeposit";
            this.backDeposit.ReadOnly = true;
            this.backDeposit.Width = 70;
            // 
            // paymentType
            // 
            this.paymentType.DataPropertyName = "paymentType";
            this.paymentType.HeaderText = "款项";
            this.paymentType.Name = "paymentType";
            this.paymentType.ReadOnly = true;
            this.paymentType.Width = 60;
            // 
            // invoiceType
            // 
            this.invoiceType.DataPropertyName = "invoiceType";
            this.invoiceType.HeaderText = "发票类型";
            this.invoiceType.Name = "invoiceType";
            this.invoiceType.ReadOnly = true;
            this.invoiceType.Width = 80;
            // 
            // Numbering
            // 
            this.Numbering.DataPropertyName = "Numbering";
            this.Numbering.HeaderText = "编号";
            this.Numbering.Name = "Numbering";
            this.Numbering.ReadOnly = true;
            // 
            // applyCode
            // 
            this.applyCode.DataPropertyName = "applyCode";
            this.applyCode.HeaderText = "销售合同号";
            this.applyCode.Name = "applyCode";
            this.applyCode.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "备注";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Width = 60;
            // 
            // FormPaymentTabie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 299);
            this.Controls.Add(this.panel1);
            this.Name = "FormPaymentTabie";
            this.Text = "付款申请单表";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn createMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn jine;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn acountNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn backDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numbering;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
    }
}