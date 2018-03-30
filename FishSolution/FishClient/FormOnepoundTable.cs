using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace FishClient
{
    public partial class FormOnepoundTable : FormMenuBase
    {
        FishBll.Bll.ProcessStateBll _bll = new FishBll.Bll.ProcessStateBll();
        string bill = string.Empty, billNum = string.Empty, path = string.Empty;
        string getname = string.Empty;
        public FormOnepoundTable()
        {
            InitializeComponent();
        }
        public FormOnepoundTable(string name)
        {
            InitializeComponent();
            tmiQuery.Visible = false;
            tmiSave.Visible = false;
            tmiReview.Visible = false;
            tmiprint.Visible = false;
            tmiPrevious.Visible = false;
            tmiNext.Visible = false;
            tmiModify.Visible = false;
            tmiExport.Visible = false;
            tmiDelete.Visible = false;
            tmiClose.Visible = false;
            tmiCancel.Visible = false;
            tmiAdd.Visible = true;
            if (name != "")
            {
                getname = name;
                view_one();
            }
        }
        public void view_one()
        {
            dataGridView1.Rows.Clear();
            List<FishEntity.OnepoundEntity> modelList = _bll.GetFormOnepoundList(getname);
            if (modelList != null)
            {
                foreach (FishEntity.OnepoundEntity model in modelList)
                {
                    int idx = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[idx];
                    row.Cells["Numbering"].Value = model.Numbering;
                    row.Cells["id"].Value = model.Id;
                    row.Cells["codeOne"].Value = model.Code;
                    row.Cells["Serialnumber"].Value = model.Serialnumber;
                    row.Cells["Dateofmanufacture"].Value = model.Dateofmanufacture;
                    row.Cells["IntothefactoryDate"].Value = model.IntothefactoryDate;
                    row.Cells["Carnumber"].Value = model.Carnumber;
                    row.Cells["Grossweight"].Value = model.Grossweight;
                    row.Cells["Tareweight"].Value = model.Tareweight;
                    row.Cells["Competition"].Value = model.Competition;
                    row.Cells["Goods"].Value = model.Goods;
                    row.Cells["Owner"].Value = model.Owner;
                    row.Cells["OwnerId"].Value = model.OwnerId;
                    row.Cells["Buyers"].Value = model.Buyers;
                    row.Cells["BuyersId"].Value = model.BuyersId;
                    row.Cells["Sellers"].Value = model.Sellers;
                    row.Cells["SellersId"].Value = model.SellersId;
                    row.Cells["Country"].Value = model.Country;
                    row.Cells["PName"].Value = model.PName;
                    row.Cells["Qualit"].Value = model.Qualit;
                    row.Cells["Quantity"].Value = model.Quantity;
                    row.Cells["Pileangle"].Value = model.Pileangle;
                    row.Cells["BillOfLadingid"].Value = model.BillOfLadingid;
                    row.Cells["Address"].Value = model.Address;
                    row.Cells["Remarks"].Value = model.Remarks;
                    row.Cells["Shipno"].Value = model.Shipno;
                    row.Cells["codeContract"].Value = model.codeContract;
                    row.Cells["createman"].Value = model.Createman;
                }
            }
        }
        public override int Add() {
            FormOnepound form = new FormOnepound(getname);
            form.ShowDialog();
            view_one();
            return 0;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            billNum = dataGridView1.Rows[e.RowIndex].Cells["codeOne"].Value.ToString();
            Reflected("FishClient.FormOnepound");
        }
        void Reflected(string path)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Form doc = (Form)asm.CreateInstance(path);
            Megres.oddNum = billNum;
            doc.Show();
        }
    }
}
