using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FishClient
{
    public partial class FormPaymentForm : FormMenuBase
    {
        FishBll.Bll.PaymentRequisitionBll _bll = new FishBll.Bll.PaymentRequisitionBll();
        FishEntity.PaymentRequisitionEntity _list = new FishEntity.PaymentRequisitionEntity();

        public FormPaymentForm()
        {
            InitializeComponent();
        }
        public override int Query()
        {
            dataGridView2.Rows.Clear();
            string strwhere = "1=1 ";
            if (!string.IsNullOrEmpty(txtapplyCode.Text))
            {
                strwhere+= " and applyCode  like '%" + txtapplyCode.Text+ "%'";
            }
            if (!string.IsNullOrEmpty(textunit.Text))
            {
                strwhere+= " and unit like '%"+textunit.Text+"%'";
            }
            strwhere += string.Format(" and paymentDate>='{0}' and paymentDate<='{1}'",
                dtpdateBefore.Value.ToString("yyyy-MM-dd 00:00:00"),
                dtpdateRear.Value.ToString("yyyy-MM-dd 23:59:59"));
            DataTable queryDatatble = _bll.getTable(strwhere);
            if (queryDatatble != null && queryDatatble.Rows.Count > 0)
            {
                dataGridView2.Rows.Clear();
                for (int i = 0; i < queryDatatble.Rows.Count; i++)
                {
                    int idx = dataGridView2.Rows.Add();
                    DataGridViewRow row = dataGridView2.Rows[idx];
                    row.Cells["applyCode"].Value = queryDatatble.Rows[i]["applyCode"].ToString();
                    row.Cells["purchasecode"].Value = queryDatatble.Rows[i]["purchasecode"].ToString();
                    row.Cells["code"].Value = queryDatatble.Rows[i]["code"].ToString();
                    row.Cells["applyDate"].Value = queryDatatble.Rows[i]["applyDate"].ToString();
                    row.Cells["acountNum"].Value = queryDatatble.Rows[i]["acountNum"].ToString();
                    row.Cells["unit"].Value = queryDatatble.Rows[i]["unit"].ToString();
                    row.Cells["contacts"].Value = queryDatatble.Rows[i]["contacts"].ToString();
                    row.Cells["backDeposit"].Value = queryDatatble.Rows[i]["backDeposit"].ToString();
                    row.Cells["price"].Value = queryDatatble.Rows[i]["price"].ToString();
                    row.Cells["weight"].Value = queryDatatble.Rows[i]["weight"].ToString();
                    row.Cells["paymentMethod"].Value = queryDatatble.Rows[i]["paymentMethod"].ToString();
                    row.Cells["applyMoney"].Value = queryDatatble.Rows[i]["applyMoney"].ToString();
                    row.Cells["paymentType"].Value = queryDatatble.Rows[i]["paymentType"].ToString();
                    row.Cells["paymentDate"].Value = queryDatatble.Rows[i]["paymentDate"].ToString();
                    row.Cells["invoiceType"].Value = queryDatatble.Rows[i]["invoiceType"].ToString();
                    row.Cells["remark"].Value = queryDatatble.Rows[i]["remark"].ToString();
                }
            }
            else {
                MessageBox.Show("查无数据！");
            }
            
            return base.Query();
        }

        private void textunit_Click(object sender, EventArgs e)
        {
            FormCompanyList Form = new FormCompanyList();
            Form.StartPosition = FormStartPosition.CenterParent;
            if (Form.ShowDialog()!=System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            if (Form.SelectCompany==null)
            {
                return;
            }
            textunit.Text = Form.SelectCompany.fullname;
            textunit.Tag = Form.SelectCompany.code;
        }
    }
}
