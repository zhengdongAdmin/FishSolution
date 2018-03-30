namespace FishClient
{
    partial class FormOnepoundTable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.createman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serialnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Competition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numbering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateofmanufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntothefactoryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grossweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tareweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buyers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sellers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pileangle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shipno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillOfLadingid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 40);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createman,
            this.Serialnumber,
            this.Carnumber,
            this.Competition,
            this.Country,
            this.PName,
            this.Quantity,
            this.Owner,
            this.Numbering,
            this.codeContract,
            this.codeOne,
            this.id,
            this.Dateofmanufacture,
            this.IntothefactoryDate,
            this.Grossweight,
            this.Tareweight,
            this.Goods,
            this.OwnerId,
            this.Buyers,
            this.BuyersId,
            this.Sellers,
            this.SellersId,
            this.Qualit,
            this.Pileangle,
            this.Shipno,
            this.BillOfLadingid,
            this.Address,
            this.Remarks});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(3, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(633, 287);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // createman
            // 
            this.createman.HeaderText = "所属人";
            this.createman.Name = "createman";
            this.createman.ReadOnly = true;
            // 
            // Serialnumber
            // 
            this.Serialnumber.DataPropertyName = "Serialnumber";
            this.Serialnumber.HeaderText = "磅单序号";
            this.Serialnumber.Name = "Serialnumber";
            this.Serialnumber.ReadOnly = true;
            // 
            // Carnumber
            // 
            this.Carnumber.DataPropertyName = "Carnumber";
            this.Carnumber.HeaderText = "车号";
            this.Carnumber.Name = "Carnumber";
            this.Carnumber.ReadOnly = true;
            // 
            // Competition
            // 
            this.Competition.DataPropertyName = "Competition";
            this.Competition.HeaderText = "净重";
            this.Competition.Name = "Competition";
            this.Competition.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "国别";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "PName";
            this.PName.HeaderText = "品牌";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "包数";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Owner
            // 
            this.Owner.DataPropertyName = "Owner";
            this.Owner.HeaderText = "货运公司";
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
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
            this.codeContract.HeaderText = "销售合同号";
            this.codeContract.Name = "codeContract";
            this.codeContract.ReadOnly = true;
            // 
            // codeOne
            // 
            this.codeOne.DataPropertyName = "codeOne";
            this.codeOne.HeaderText = "序号";
            this.codeOne.Name = "codeOne";
            this.codeOne.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Dateofmanufacture
            // 
            this.Dateofmanufacture.DataPropertyName = "Dateofmanufacture";
            this.Dateofmanufacture.HeaderText = "发货日期";
            this.Dateofmanufacture.Name = "Dateofmanufacture";
            this.Dateofmanufacture.ReadOnly = true;
            // 
            // IntothefactoryDate
            // 
            this.IntothefactoryDate.DataPropertyName = "IntothefactoryDate";
            this.IntothefactoryDate.HeaderText = "进厂日期";
            this.IntothefactoryDate.Name = "IntothefactoryDate";
            this.IntothefactoryDate.ReadOnly = true;
            // 
            // Grossweight
            // 
            this.Grossweight.DataPropertyName = "Grossweight";
            this.Grossweight.HeaderText = "毛重";
            this.Grossweight.Name = "Grossweight";
            this.Grossweight.ReadOnly = true;
            // 
            // Tareweight
            // 
            this.Tareweight.DataPropertyName = "Tareweight";
            this.Tareweight.HeaderText = "皮重";
            this.Tareweight.Name = "Tareweight";
            this.Tareweight.ReadOnly = true;
            // 
            // Goods
            // 
            this.Goods.DataPropertyName = "Goods";
            this.Goods.HeaderText = "品名";
            this.Goods.Name = "Goods";
            this.Goods.ReadOnly = true;
            // 
            // OwnerId
            // 
            this.OwnerId.DataPropertyName = "OwnerId";
            this.OwnerId.HeaderText = "货主Id";
            this.OwnerId.Name = "OwnerId";
            this.OwnerId.ReadOnly = true;
            this.OwnerId.Visible = false;
            // 
            // Buyers
            // 
            this.Buyers.DataPropertyName = "Buyers";
            this.Buyers.HeaderText = "采购商";
            this.Buyers.Name = "Buyers";
            this.Buyers.ReadOnly = true;
            // 
            // BuyersId
            // 
            this.BuyersId.DataPropertyName = "BuyersId";
            this.BuyersId.HeaderText = "采购商Id";
            this.BuyersId.Name = "BuyersId";
            this.BuyersId.ReadOnly = true;
            this.BuyersId.Visible = false;
            // 
            // Sellers
            // 
            this.Sellers.DataPropertyName = "Sellers";
            this.Sellers.HeaderText = "销售商";
            this.Sellers.Name = "Sellers";
            this.Sellers.ReadOnly = true;
            // 
            // SellersId
            // 
            this.SellersId.DataPropertyName = "SellersId";
            this.SellersId.HeaderText = "销售商Id";
            this.SellersId.Name = "SellersId";
            this.SellersId.ReadOnly = true;
            this.SellersId.Visible = false;
            // 
            // Qualit
            // 
            this.Qualit.DataPropertyName = "Qualit";
            this.Qualit.HeaderText = "品质规格";
            this.Qualit.Name = "Qualit";
            this.Qualit.ReadOnly = true;
            // 
            // Pileangle
            // 
            this.Pileangle.DataPropertyName = "Pileangle";
            this.Pileangle.HeaderText = "桩角号";
            this.Pileangle.Name = "Pileangle";
            this.Pileangle.ReadOnly = true;
            // 
            // Shipno
            // 
            this.Shipno.DataPropertyName = "Shipno";
            this.Shipno.HeaderText = "船名";
            this.Shipno.Name = "Shipno";
            this.Shipno.ReadOnly = true;
            // 
            // BillOfLadingid
            // 
            this.BillOfLadingid.DataPropertyName = "BillOfLadingid";
            this.BillOfLadingid.HeaderText = "提单号";
            this.BillOfLadingid.Name = "BillOfLadingid";
            this.BillOfLadingid.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "地址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "备注";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // FormOnepoundTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 385);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormOnepoundTable";
            this.Text = "磅单关联表";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serialnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numbering;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateofmanufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntothefactoryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grossweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tareweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buyers;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sellers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pileangle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shipno;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillOfLadingid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}