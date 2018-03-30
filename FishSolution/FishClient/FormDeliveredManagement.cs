using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FishClient
{
    public partial class FormDeliveredManagement : FormMenuBase
    {
        FishBll.Bll.DeliveredManagementBll _bll = null;
        FishEntity.DeliveredManagementEntity _model = null;
        static string strWhere = string.Empty;
        public FormDeliveredManagement()
        {
            InitializeComponent();
            getCombox();
            getQuery();
        }
        public void getQuery() {
            _bll = new FishBll.Bll.DeliveredManagementBll();
            _model = new FishEntity.DeliveredManagementEntity();
            _model = _bll.getList(strWhere);
            if (_model != null)
            {
                setValue(_model);
            }
            else {
                tmiAdd.Visible = true;
            }            
        }
        public override int Add()
        {
            tmiSave.Visible = true;
            return base.Add();            
        }
        public override int Modify()
        {
            getvalue();
            bool isOk= _bll.Update(_model);
            if (isOk == true)
            {
                MessageBox.Show("保存成功！");
                tmiAdd.Visible = tmiSave.Visible = false;
            }
            return base.Modify(); 
        }
        public override void Save()
        {
            getvalue();
          bool  isOk = _bll.Add(_model);
            if (isOk == true)
            {
                MessageBox.Show("新建成功！");
                tmiAdd.Visible =tmiSave.Visible= false;                
            }
            }
        public void setValue(FishEntity.DeliveredManagementEntity _model)
        {
            txtid.Text =_model.id.ToString();
            cmbTJxssqd.Text = _model.cmbTJxssqd;
            txtTJxssqd.Text = _model.txtTJxssqd;
            cmbSGxssqd.Text = _model.cmbSGxssqd;
            txtSGxssqd.Text = _model.txtSGxssqd;
            cmbTJxsht.Text = _model.cmbTJxsht;
            txtTJxsht.Text = _model.txtTJxsht;
            cmbSGxsht.Text = _model.cmbSGxsht;
            txtSGxsht.Text = _model.txtSGxsht;
            cmbTJfksqd.Text = _model.cmbTJfksqd;
            txtTJfksqd.Text = _model.txtTJfksqd;
            cmbSGfksqd.Text = _model.cmbSGfksqd;
            txtSGfksqd.Text = _model.txtSGfksqd;
            cmbTJbd.Text = _model.cmbTJbd;
            txtTJbd.Text = _model.txtTJbd;
            cmbSGbd.Text = _model.cmbSGbd;
            txtSGbd.Text = _model.txtSGbd;
            cmbTJhwfkd.Text = _model.cmbTJhwfkd;
            txtTJhwfkd.Text = _model.txtTJhwfkd;
            cmbSGhwfkd.Text = _model.cmbSGhwfkd;
            txtSGhwfkd.Text = _model.txtSGhwfkd;
            cmbTJgswtfkd.Text = _model.cmbTJgswtfkd;
            txtTJgswtfkd.Text = _model.txtTJgswtfkd;
            cmbSGgswtfkd.Text = _model.cmbSGgswtfkd;
            txtSGgswtfkd.Text = _model.txtSGgswtfkd;
            cmbTJskjld.Text = _model.cmbTJskjld;
            txtTJskjld.Text = _model.txtTJskjld;
            cmbSGskjld.Text = _model.cmbSGskjld;
            txtSGskjld.Text = _model.txtSGskjld;

            tmiAdd.Visible = false;
            tmiSave.Visible = false;
        }
        public void getvalue() {
            _model = new FishEntity.DeliveredManagementEntity();
            _model.id =int.Parse(txtid.Text.ToString());
            _model.cmbTJxssqd = cmbTJxssqd.Text.ToString();
            _model.txtTJxssqd = txtTJxssqd.Text.ToString();
            _model.cmbSGxssqd = cmbSGxssqd.Text.ToString();
            _model.txtSGxssqd = txtSGxssqd.Text.ToString();
            _model.cmbTJxsht = cmbTJxsht.Text.ToString();
            _model.txtTJxsht = txtTJxsht.Text.ToString();
            _model.cmbSGxsht = cmbSGxsht.Text.ToString();
            _model.txtSGxsht = txtSGxsht.Text.ToString();
            _model.cmbTJfksqd = cmbTJfksqd.Text.ToString();
            _model.txtTJfksqd = txtTJfksqd.Text.ToString();
            _model.cmbSGfksqd = cmbSGfksqd.Text.ToString();
            _model.txtSGfksqd = txtSGfksqd.Text.ToString();
            _model.cmbTJbd = cmbTJbd.Text.ToString();
            _model.txtTJbd = txtTJbd.Text.ToString();
            _model.cmbSGbd = cmbSGbd.Text.ToString();
            _model.txtSGbd = txtSGbd.Text.ToString();
            _model.cmbTJhwfkd = cmbTJhwfkd.Text.ToString();
            _model.txtTJhwfkd = txtTJhwfkd.Text.ToString();
            _model.cmbSGhwfkd = cmbSGhwfkd.Text.ToString();
            _model.txtSGhwfkd = txtSGhwfkd.Text.ToString();
            _model.cmbTJgswtfkd = cmbTJgswtfkd.Text.ToString();
            _model.txtTJgswtfkd = txtTJgswtfkd.Text.ToString();
            _model.cmbSGgswtfkd = cmbSGgswtfkd.Text.ToString();
            _model.txtSGgswtfkd = txtSGgswtfkd.Text.ToString();
            _model.cmbTJskjld = cmbTJskjld.Text.ToString();
            _model.txtTJskjld = txtTJskjld.Text.ToString();
            _model.cmbSGskjld = cmbSGskjld.Text.ToString();
            _model.txtSGskjld = txtSGskjld.Text.ToString();
            _model.createman = FishEntity.Variable.User.username;
            _model.modifyman = FishEntity.Variable.User.username;
        }
        public void getCombox() {
            FishBll.Bll.ReceiptRecordBll _bll = new FishBll.Bll.ReceiptRecordBll();cmbTJxssqd.DataSource = _bll.getDepart();cmbTJxssqd.DisplayMember = "rolename";
            _bll = new FishBll.Bll.ReceiptRecordBll(); cmbSGxssqd.DataSource = _bll.getDepart(); cmbSGxssqd.DisplayMember = "rolename";

            _bll = new FishBll.Bll.ReceiptRecordBll(); cmbTJxsht.DataSource = _bll.getDepart(); cmbTJxsht.DisplayMember = "rolename";
            _bll = new FishBll.Bll.ReceiptRecordBll(); cmbSGxsht.DataSource = _bll.getDepart(); cmbSGxsht.DisplayMember = "rolename";

            _bll = new FishBll.Bll.ReceiptRecordBll(); cmbTJfksqd.DataSource = _bll.getDepart(); cmbTJfksqd.DisplayMember = "rolename";
            _bll = new FishBll.Bll.ReceiptRecordBll(); cmbSGfksqd.DataSource = _bll.getDepart(); cmbSGfksqd.DisplayMember = "rolename";

            _bll = new FishBll.Bll.ReceiptRecordBll(); cmbTJbd.DataSource = _bll.getDepart(); cmbTJbd.DisplayMember = "rolename";
            _bll = new FishBll.Bll.ReceiptRecordBll(); cmbSGbd.DataSource = _bll.getDepart(); cmbSGbd.DisplayMember = "rolename";

            _bll = new FishBll.Bll.ReceiptRecordBll(); cmbTJhwfkd.DataSource = _bll.getDepart(); cmbTJhwfkd.DisplayMember = "rolename";
            _bll = new FishBll.Bll.ReceiptRecordBll(); cmbSGhwfkd.DataSource = _bll.getDepart(); cmbSGhwfkd.DisplayMember = "rolename";

            _bll = new FishBll.Bll.ReceiptRecordBll(); cmbTJgswtfkd.DataSource = _bll.getDepart(); cmbTJgswtfkd.DisplayMember = "rolename";
            _bll = new FishBll.Bll.ReceiptRecordBll(); cmbSGgswtfkd.DataSource = _bll.getDepart(); cmbSGgswtfkd.DisplayMember = "rolename";

            _bll = new FishBll.Bll.ReceiptRecordBll(); cmbTJskjld.DataSource = _bll.getDepart(); cmbTJskjld.DisplayMember = "rolename";
            _bll = new FishBll.Bll.ReceiptRecordBll(); cmbSGskjld.DataSource = _bll.getDepart(); cmbSGskjld.DisplayMember = "rolename";
        }
        private void txtxsssd_Click(object sender, EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            txtTJxssqd.Text = from.getStr;
        }

        private void txtxxht_Click(object sender, EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            txtTJxsht.Text = from.getStr;
        }

        private void txtfksqd_Click(object sender, EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            txtTJfksqd.Text = from.getStr;
        }
        private void txtbd_Click(object sender, EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            txtTJbd.Text = from.getStr;
        }

        private void txthwfkd_Click(object sender, EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            txtTJhwfkd.Text = from.getStr;
        }

        private void txtgswtfkd_Click(object sender, EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            txtTJgswtfkd.Text = from.getStr;
        }

        private void txtskjld_Click(object sender, EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            txtTJskjld.Text = from.getStr;
        }

        private void txtSGxssqd_Click(object sender, EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            txtSGxssqd.Text = from.getStr;
        }

        private void txtSGxsht_Click(object sender, EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            txtSGxsht.Text = from.getStr;
        }

        private void txtSGfksqd_Click(object sender, EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            txtSGfksqd.Text = from.getStr;
        }

        private void txtSGbd_Click(object sender, EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            txtSGbd.Text = from.getStr;
        }

        private void txtSGhwfkd_Click(object sender, EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            txtSGhwfkd.Text = from.getStr;
        }

        private void txtSGgswtfkd_Click(object sender, EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            txtSGgswtfkd.Text = from.getStr;
        }

        private void txtSGskjld_Click(object sender, EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            txtSGskjld.Text = from.getStr;
        }

        private void FormDeliveredManagement_Load(object sender, EventArgs e)
        {
            getQuery();
        }
    }
}
