using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace FishClient
{
    public partial class FormBillofladingTable : FormMenuBase
    {
        string getname = string.Empty;
        string bill = string.Empty, billNum = string.Empty, path = string.Empty;
        FishEntity.ProcessStateEntity _list = new FishEntity.ProcessStateEntity();
        FishBll.Bll.ProcessStateBll _bll = new FishBll.Bll.ProcessStateBll();
        public FormBillofladingTable(string name)
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
                ViewOne();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            billNum = dataGridView1.Rows[e.RowIndex].Cells["codeOne"].Value.ToString();
            Reflected("FishClient.FormBilloflading");
        }
        void Reflected(string path)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Form doc = (Form)asm.CreateInstance(path);
            Megres.oddNum = billNum;
            doc.Show();
        }
        public void ViewOne()
        {
            dataGridView1.Rows.Clear();
            List<FishEntity.BillofladingEntity> modelList = _bll.GetBillofladingListOne(getname);
            if (modelList != null)
            {
                foreach (FishEntity.BillofladingEntity model in modelList)
                {
                    int idx = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[idx];
                    row.Cells["Numbering"].Value = model.Numbering;
                    row.Cells["id"].Value = model.Id;
                    row.Cells["codeOne"].Value = model.Code;
                    row.Cells["Issuingtime"].Value = model.Issuingtime;
                    row.Cells["codeContract"].Value = model.codeContract;
                    row.Cells["contactsunit"].Value = model.Contactsunit;
                    row.Cells["ContactsunitId"].Value = model.ContactsunitId;
                    row.Cells["warehouse"].Value = model.Warehouse;
                    row.Cells["species"].Value = model.Species;
                    row.Cells["specification"].Value = model.Specification;
                    row.Cells["cornerno"].Value = model.Cornerno;
                    row.Cells["ferryname"].Value = model.Ferryname;
                    row.Cells["listname"].Value = model.Listname;
                    row.Cells["Ton"].Value = model.Ton;
                    row.Cells["packagenumber"].Value = model.Packagenumber;
                    row.Cells["Remarks"].Value = model.Remarks;
                    row.Cells["ShipNotice"].Value = model.ShipNotice;
                    row.Cells["Storagecosts"].Value = model.Storagecosts;
                    row.Cells["Recipient"].Value = model.Recipient;
                    row.Cells["SerialNumber"].Value = model.SerialNumber;
                    row.Cells["createman"].Value = model.Createman;
                }
            }
        }
        public override int Add()
        {
            FormBilloflading form = new FormBilloflading(getname);
            form.ShowDialog();
            ViewOne();
            return 0;
        }
    }
}
