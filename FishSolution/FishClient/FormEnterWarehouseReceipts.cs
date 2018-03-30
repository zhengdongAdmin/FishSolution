using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FishClient
{
    public partial class FormEnterWarehouseReceipts : FormMenuBase
    {
        FishEntity.EnterWarehouseReceipts _fish = null;
        private UIForms.FormEnterWarehouseReceiptsCodition _Form = null;
        private FishBll.Bll.EnterWarehouseReceiptsBll _bll = new FishBll.Bll.EnterWarehouseReceiptsBll();
        private string _where = string.Empty;
        string _orderBy = " order by id asc limit 1";//limit 1
        private string _rolewhere = string.Empty;
        public FormEnterWarehouseReceipts()
        {
            InitializeComponent();
            InitDataUtil.BindComboBoxData(cmbtName, FishEntity.Constant.Brand, true);
        }
        public override int Query()
        {
            panel1.Enabled = true;
            if (_Form == null)
            {
                _Form = new UIForms.FormEnterWarehouseReceiptsCodition();
                _Form.StartPosition = FormStartPosition.CenterParent;
                _Form.ShowInTaskbar = false;
            }
            if (_Form.ShowDialog() != System.Windows.Forms.DialogResult.OK) return 0;
            _where = _Form.GetWhereCondition;
            List<FishEntity.EnterWarehouseReceipts> list = _bll.GetModelListVo(_where + _rolewhere + _orderBy);
            if (list == null || list.Count < 1)
            {
                _fish = null;
                return 1;
            }
            else
            {
                _fish = list[0];
                SetOnepound();
            }
                return 1;
        }
        protected void SetOnepound()
        {
            txtcode.Text = _fish.Code;
            txtTO.Text = _fish.TO;
            txtZhuangjiao.Text = _fish.Zhuangjiao;
            txtContractNo.Text = _fish.ContractNo;
            txtTEL.Text = _fish.TEL;
            txtANTI.Text = _fish.ANTI;
            txtFAX.Text = _fish.FAX;
            txtRequester.Text = _fish.Requester;
            txtShipname.Text = _fish.Shipname;
            txttonnage.Text = _fish.Tonnage.ToString();
            cmbtName.SelectedValue = _fish.TName;
            txtBillnumber.Text = _fish.Billnumber;
            txtNumberOfPieces.Text = _fish.NumberOfPieces.ToString();
            dtpUnpackingdate.Value = _fish.Unpackingdate.Value;
            txtactualnumber.Text = _fish.Actualnumber.ToString();
            txtStorageLocation.Text = _fish.StorageLocation;
            txtposition.Text = _fish.Position;
            txtRemarks.Text = _fish.Remarks;
        }
        public override int Add()
        {
            tmiQuery.Visible = false;
            tmiDelete.Visible = false;
            tmiModify.Visible = false;
            tmiAdd.Visible = false;
            tmiSave.Visible = true;
            tmiCancel.Visible = true;
            panel1.Enabled = true;

            txtcode.Text = string.Empty;
            txtTO.Text = string.Empty;
            txtZhuangjiao.Text = string.Empty;
            txtContractNo.Text = string.Empty;
            txtTEL.Text = string.Empty;
            txtANTI.Text = string.Empty;
            txtFAX.Text = string.Empty;
            txtRequester.Text = string.Empty;
            txtShipname.Text = string.Empty;
            txttonnage.Text = string.Empty;
            cmbtName.SelectedValue = string.Empty;
            txtBillnumber.Text = string.Empty;
            txtNumberOfPieces.Text = string.Empty;
            dtpUnpackingdate.Value = DateTime.Now;
            txtactualnumber.Text = string.Empty;
            txtStorageLocation.Text = string.Empty;
            txtposition.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            return 1;
        }
        public override void Save() {
            FishEntity.EnterWarehouseReceipts _fish = new FishEntity.EnterWarehouseReceipts();
            _fish.Code = FishBll.Bll.SequenceUtil.GetEnterWarehouseReceipts();
            decimal temp = 0;
            _fish.Requester = txtRequester.Text.Trim();
            _fish.Shipname = txtShipname.Text.Trim();
            decimal.TryParse(txttonnage.Text, out temp);
            _fish.Tonnage = temp;
            _fish.TName = cmbtName.SelectedValue == null ? string.Empty : cmbtName.SelectedValue.ToString().Trim();
            _fish.Billnumber = txtBillnumber.Text;
            decimal.TryParse(txtNumberOfPieces.Text, out temp);
            _fish.NumberOfPieces = temp;
            _fish.Unpackingdate = dtpUnpackingdate.Value;
            decimal.TryParse(txtactualnumber.Text, out temp);
            _fish.Actualnumber = temp;
            _fish.StorageLocation = txtStorageLocation.Text.Trim();
            _fish.Position = txtposition.Text.Trim();
            _fish.Remarks = txtRemarks.Text.Trim();
            _fish.Createtime = DateTime.Now;
            _fish.Createman = FishEntity.Variable.User.username;
            _fish.Modifytime = DateTime.Now;
            _fish.Modifyman = FishEntity.Variable.User.username;
            _fish.TO = txtTO.Text.Trim();
            _fish.Zhuangjiao = txtZhuangjiao.Text;
            _fish.ContractNo = txtContractNo.Text;
            _fish.TEL = txtTEL.Text.Trim();
            _fish.ANTI = txtANTI.Text.Trim();
            _fish.FAX = txtFAX.Text.Trim();

            FishBll.Bll.EnterWarehouseReceiptsBll bll = new FishBll.Bll.EnterWarehouseReceiptsBll();

            bool isok = bll.Exists(_fish.Code);
            while (isok)
            {
                _fish.Code = FishBll.Bll.SequenceUtil.GetEnterWarehouseReceipts();
                isok = bll.Exists(_fish.Code);
            }
            int id = bll.Add(_fish);
            if (id > 0)
            {
                _fish.Id = id;
                tmiQuery.Visible = false;
                tmiDelete.Visible = false;
                tmiModify.Visible = false;
                tmiAdd.Visible = false;
                tmiSave.Visible = true;
                tmiCancel.Visible = true;
                MessageBox.Show("添加成功。");
                txtcode.Text = _fish.Code.ToString();
            }
            else
            {
                // txtCode.Text = _fish.Code;
                MessageBox.Show("添加失败。");
            }
        }
        public override int Modify()
        {
            if (_fish == null)
            {
                MessageBox.Show("请查询需要修改的进仓单。");
                return 0;
            }
            decimal temp = 0;
            _fish.Code = txtcode.Text.ToString();
            _fish.Requester = txtRequester.Text.Trim();
            _fish.Shipname = txtShipname.Text.Trim();
            decimal.TryParse(txttonnage.Text, out temp);
            _fish.Tonnage = temp;
            _fish.TName = cmbtName.SelectedValue == null ? string.Empty : cmbtName.SelectedValue.ToString().Trim();
            _fish.Billnumber = txtBillnumber.Text;
            decimal.TryParse(txtNumberOfPieces.Text, out temp);
            _fish.NumberOfPieces = temp;
            _fish.Unpackingdate = dtpUnpackingdate.Value;
            decimal.TryParse(txtactualnumber.Text, out temp);
            _fish.Actualnumber = temp;
            _fish.StorageLocation = txtStorageLocation.Text.Trim();
            _fish.Position = txtposition.Text.Trim();
            _fish.Remarks = txtRemarks.Text.Trim();
            _fish.Modifytime = DateTime.Now;
            _fish.Modifyman = FishEntity.Variable.User.username;
            _fish.TO = txtTO.Text.Trim();
            _fish.Zhuangjiao = txtZhuangjiao.Text;
            _fish.ContractNo = txtContractNo.Text;
            _fish.TEL = txtTEL.Text.Trim();
            _fish.ANTI = txtANTI.Text.Trim();
            _fish.FAX = txtFAX.Text.Trim();

            FishBll.Bll.EnterWarehouseReceiptsBll bll = new FishBll.Bll.EnterWarehouseReceiptsBll();

            bool isOk = bll.Update(_fish);
            if (isOk)
            {
                MessageBox.Show("修改成功。");
            }
            else
            {
                //txtcode.Text = string.Empty;
                MessageBox.Show("修改失败。");
            }
            return 1;
        }
        public override void Cancel()
        {
            tmiAdd.Visible = true;
            tmiModify.Visible = true;
            tmiQuery.Visible = true;
            tmiDelete.Visible = true;
            tmiSave.Visible = false;
            tmiCancel.Visible = false;

            panel1.Enabled = true;
        }

        private void txtRequester_Click(object sender, EventArgs e)
        {
            FormCompanyList form = new FormCompanyList();
            form.StartPosition = FormStartPosition.CenterParent;
            if (form.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            if (form.SelectCompany == null) return;
            txtRequester.Text = form.SelectCompany.fullname;
            txtRequester.Tag = form.SelectCompany;
        }

        private void txtContractNo_Click(object sender, EventArgs e)
        {
            FormPurchaseRequisition from = new FormPurchaseRequisition();
            //from.signOfOpen = this.Name;        
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (from.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            txtContractNo.Text = string.Empty;
            txtContractNo.Text = from.GetContractNo;
        }
    }
}
