using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace FishClient
{
    public partial class FormTheproblemsheetTable : FormMenuBase
    {
        string getname = string.Empty;
        string bill = string.Empty, billNum = string.Empty, path = string.Empty;
        FishBll.Bll.ProcessStateBll _bll = new FishBll.Bll.ProcessStateBll();
        public FormTheproblemsheetTable()
        {
            InitializeComponent();
        }
        public FormTheproblemsheetTable(string code)
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
            if (code != "")
            {
                getname = code;
                ViewOne();
            }
        }
        public void ViewOne()
        {
            dataGridView1.Rows.Clear();
            List<FishEntity.TheproblemsheetEntity> modelList = _bll.GetTheproblemsheetList(getname);
            if (modelList != null)
            {
                foreach (FishEntity.TheproblemsheetEntity model in modelList)
                {
                    int idx = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[idx];
                    row.Cells["Numbering"].Value = model.Numbering;
                    row.Cells["id"].Value = model.Id;
                    row.Cells["code"].Value = model.Code;
                    row.Cells["codeContract"].Value = model.codeContract;
                    row.Cells["occurDate"].Value = model.OccurDate;
                    row.Cells["EventName"].Value = model.EventName;
                    row.Cells["SolvTtheProblem"].Value = model.SolvTtheProblem;
                    row.Cells["Remarks"].Value = model.Remarks;
                    row.Cells["Chargeback"].Value = model.Chargeback;
                    row.Cells["createman"].Value = model.Createman;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            billNum = dataGridView1.Rows[e.RowIndex].Cells["code"].Value.ToString();
            Reflected("FishClient.FormTheproblemsheet");
        }

        void Reflected(string path)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Form doc = (Form)asm.CreateInstance(path);
            Megres.oddNum = billNum;
            doc.Show();
        }
        public override int Add()
        {
            FormTheproblemsheet form = new FormTheproblemsheet(getname);
            form.ShowDialog();
            ViewOne();
            return 0;
        }
    }
}
