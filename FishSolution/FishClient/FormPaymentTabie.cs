using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;


namespace FishClient
{
    public partial class FormPaymentTabie : FormMenuBase
    {
        string getname = string.Empty;
        string bill = string.Empty, billNum = string.Empty, path = string.Empty;
        FishBll.Bll.ProcessStateBll _bll = new FishBll.Bll.ProcessStateBll();
        FishEntity.ProcessStateEntity _list =new FishEntity.ProcessStateEntity();
        public FormPaymentTabie(string name)
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
            if (name!="")
            {
                getname = name;
                view_one();
            }
        }
        public override int Add()
        {
            FormPaymentRequisition form = new FormPaymentRequisition(getname);
            form.ShowDialog();
            view_one();
            return 0;  
        }
        public void view_one()
        {
            dataGridView2.Rows.Clear();
            List<FishEntity.PaymentRequisitionEntity> modelList = _bll.GetListOne(getname);
            if (modelList != null)
            {
                foreach (FishEntity.PaymentRequisitionEntity model in modelList)
                {
                    int idx = dataGridView2.Rows.Add();
                    DataGridViewRow row = dataGridView2.Rows[idx];
                    row.Cells["Numbering"].Value = model.Numbering;
                    row.Cells["applyCode"].Value = model.applyCode;
                    row.Cells["codeOne"].Value = model.code;
                    row.Cells["purchasecode"].Value = model.Purchasecode;
                    row.Cells["applyDate"].Value = model.applyDate;
                    row.Cells["acountNum"].Value = model.AcountNum;
                    row.Cells["unit"].Value = model.unit;
                    row.Cells["contacts"].Value = model.contacts;
                    row.Cells["backDeposit"].Value = model.backDeposit;
                    row.Cells["price"].Value = model.price;
                    row.Cells["weight"].Value = model.weight;
                    row.Cells["jine"].Value = model.price * model.weight;
                    row.Cells["paymentMethod"].Value = model.paymentMethod;
                    row.Cells["paymentType"].Value = model.paymentType;
                    row.Cells["paymentDate"].Value = model.paymentDate;
                    row.Cells["invoiceType"].Value = model.invoiceType;
                    row.Cells["remark"].Value = model.remark;
                    row.Cells["state"].Value = model.paymentMethodOther;
                    row.Cells["createMan"].Value = model.createMan;
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            billNum = dataGridView2.Rows[e.RowIndex].Cells["codeOne"].Value.ToString();
            Reflected("FishClient.FormPaymentRequisition");
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
