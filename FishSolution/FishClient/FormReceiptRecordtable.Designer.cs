namespace FishClient
{
    partial class FormReceiptRecordtable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numbering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuKuanOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuKuandate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeYunFei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeHuiKou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemaUndnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemaUndnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemandSideContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemandSideContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuKuanDanWei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuKuanZhangHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jiner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuKuanType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuKuanMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceTypeOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 265);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(613, 225);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeight = 45;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createMan,
            this.Numbering,
            this.codeContract,
            this.codeTwo,
            this.fuKuanOther,
            this.fuKuandate,
            this.codePrice,
            this.codeYunFei,
            this.codeHuiKou,
            this.DemaUndnit,
            this.DemaUndnitId,
            this.DemandSideContact,
            this.DemandSideContactId,
            this.fuKuanDanWei,
            this.fuKuanZhangHao,
            this.priceOne,
            this.weightOne,
            this.jiner,
            this.fuKuanType,
            this.fuKuanMethod,
            this.RMB,
            this.invoiceTypeOne,
            this.remarkOne});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 30;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(613, 225);
            this.dataGridView3.TabIndex = 207;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 40);
            this.panel2.TabIndex = 0;
            // 
            // createMan
            // 
            this.createMan.HeaderText = "所属人";
            this.createMan.Name = "createMan";
            this.createMan.ReadOnly = true;
            // 
            // Numbering
            // 
            this.Numbering.DataPropertyName = "Numbering";
            this.Numbering.HeaderText = "编号";
            this.Numbering.Name = "Numbering";
            this.Numbering.ReadOnly = true;
            // 
            // codeContract
            // 
            this.codeContract.DataPropertyName = "codeContract";
            this.codeContract.HeaderText = "合同号";
            this.codeContract.Name = "codeContract";
            this.codeContract.ReadOnly = true;
            // 
            // codeTwo
            // 
            this.codeTwo.DataPropertyName = "codeTwo";
            this.codeTwo.HeaderText = "单号";
            this.codeTwo.Name = "codeTwo";
            this.codeTwo.ReadOnly = true;
            this.codeTwo.Width = 60;
            // 
            // fuKuanOther
            // 
            this.fuKuanOther.DataPropertyName = "fuKuanOther";
            this.fuKuanOther.HeaderText = "审核";
            this.fuKuanOther.Name = "fuKuanOther";
            this.fuKuanOther.ReadOnly = true;
            this.fuKuanOther.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fuKuanOther.Width = 60;
            // 
            // fuKuandate
            // 
            this.fuKuandate.DataPropertyName = "fuKuandate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fuKuandate.DefaultCellStyle = dataGridViewCellStyle1;
            this.fuKuandate.HeaderText = "收款日期";
            this.fuKuandate.Name = "fuKuandate";
            this.fuKuandate.ReadOnly = true;
            this.fuKuandate.Width = 80;
            // 
            // codePrice
            // 
            this.codePrice.DataPropertyName = "codePrice";
            this.codePrice.HeaderText = "合同单价";
            this.codePrice.Name = "codePrice";
            this.codePrice.ReadOnly = true;
            this.codePrice.Width = 80;
            // 
            // codeYunFei
            // 
            this.codeYunFei.DataPropertyName = "codeYunFei";
            this.codeYunFei.HeaderText = "运费";
            this.codeYunFei.Name = "codeYunFei";
            this.codeYunFei.ReadOnly = true;
            this.codeYunFei.Width = 60;
            // 
            // codeHuiKou
            // 
            this.codeHuiKou.DataPropertyName = "codeHuiKou";
            this.codeHuiKou.HeaderText = "回扣";
            this.codeHuiKou.Name = "codeHuiKou";
            this.codeHuiKou.ReadOnly = true;
            this.codeHuiKou.Width = 60;
            // 
            // DemaUndnit
            // 
            this.DemaUndnit.DataPropertyName = "DemaUndnit";
            this.DemaUndnit.HeaderText = "需方单位";
            this.DemaUndnit.Name = "DemaUndnit";
            this.DemaUndnit.ReadOnly = true;
            // 
            // DemaUndnitId
            // 
            this.DemaUndnitId.DataPropertyName = "DemaUndnitId";
            this.DemaUndnitId.HeaderText = "DemaUndnitId";
            this.DemaUndnitId.Name = "DemaUndnitId";
            this.DemaUndnitId.ReadOnly = true;
            this.DemaUndnitId.Visible = false;
            // 
            // DemandSideContact
            // 
            this.DemandSideContact.DataPropertyName = "DemandSideContact";
            this.DemandSideContact.HeaderText = "需方联系人";
            this.DemandSideContact.Name = "DemandSideContact";
            this.DemandSideContact.ReadOnly = true;
            // 
            // DemandSideContactId
            // 
            this.DemandSideContactId.DataPropertyName = "DemandSideContactId";
            this.DemandSideContactId.HeaderText = "DemandSideContactId";
            this.DemandSideContactId.Name = "DemandSideContactId";
            this.DemandSideContactId.ReadOnly = true;
            this.DemandSideContactId.Visible = false;
            // 
            // fuKuanDanWei
            // 
            this.fuKuanDanWei.DataPropertyName = "fuKuanDanWei";
            this.fuKuanDanWei.HeaderText = "收款单位";
            this.fuKuanDanWei.Name = "fuKuanDanWei";
            this.fuKuanDanWei.ReadOnly = true;
            this.fuKuanDanWei.Width = 80;
            // 
            // fuKuanZhangHao
            // 
            this.fuKuanZhangHao.DataPropertyName = "fuKuanZhangHao";
            this.fuKuanZhangHao.HeaderText = "收款帐号";
            this.fuKuanZhangHao.Name = "fuKuanZhangHao";
            this.fuKuanZhangHao.ReadOnly = true;
            this.fuKuanZhangHao.Width = 80;
            // 
            // priceOne
            // 
            this.priceOne.DataPropertyName = "price";
            this.priceOne.HeaderText = "货品单价";
            this.priceOne.Name = "priceOne";
            this.priceOne.ReadOnly = true;
            this.priceOne.Width = 80;
            // 
            // weightOne
            // 
            this.weightOne.DataPropertyName = "weight";
            this.weightOne.HeaderText = "货品重量";
            this.weightOne.Name = "weightOne";
            this.weightOne.ReadOnly = true;
            this.weightOne.Width = 80;
            // 
            // jiner
            // 
            this.jiner.DataPropertyName = "jiner";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.jiner.DefaultCellStyle = dataGridViewCellStyle2;
            this.jiner.HeaderText = "货品金额";
            this.jiner.Name = "jiner";
            this.jiner.ReadOnly = true;
            this.jiner.Width = 80;
            // 
            // fuKuanType
            // 
            this.fuKuanType.DataPropertyName = "fuKuanType";
            this.fuKuanType.HeaderText = "款项";
            this.fuKuanType.Name = "fuKuanType";
            this.fuKuanType.ReadOnly = true;
            this.fuKuanType.Width = 60;
            // 
            // fuKuanMethod
            // 
            this.fuKuanMethod.DataPropertyName = "fuKuanMethod";
            this.fuKuanMethod.HeaderText = "收款方式";
            this.fuKuanMethod.Name = "fuKuanMethod";
            this.fuKuanMethod.ReadOnly = true;
            this.fuKuanMethod.Width = 80;
            // 
            // RMB
            // 
            this.RMB.DataPropertyName = "RMB";
            this.RMB.HeaderText = "申请金额";
            this.RMB.Name = "RMB";
            this.RMB.ReadOnly = true;
            this.RMB.Width = 80;
            // 
            // invoiceTypeOne
            // 
            this.invoiceTypeOne.DataPropertyName = "invoiceType";
            this.invoiceTypeOne.HeaderText = "发票类型";
            this.invoiceTypeOne.Name = "invoiceTypeOne";
            this.invoiceTypeOne.ReadOnly = true;
            this.invoiceTypeOne.Width = 80;
            // 
            // remarkOne
            // 
            this.remarkOne.DataPropertyName = "remarkOne";
            this.remarkOne.HeaderText = "备注";
            this.remarkOne.Name = "remarkOne";
            this.remarkOne.ReadOnly = true;
            this.remarkOne.Width = 60;
            // 
            // FormReceiptRecordtable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 323);
            this.Controls.Add(this.panel1);
            this.Name = "FormReceiptRecordtable";
            this.Text = "收款记录单表";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn createMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numbering;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuKuanOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuKuandate;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeYunFei;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeHuiKou;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemaUndnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemaUndnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemandSideContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemandSideContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuKuanDanWei;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuKuanZhangHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn jiner;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuKuanType;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuKuanMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMB;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceTypeOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkOne;
    }
}