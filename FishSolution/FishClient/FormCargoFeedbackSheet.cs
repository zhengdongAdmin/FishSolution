using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FishClient
{
    public partial class FormCargoFeedbackSheet : FormMenuBase
    {
        /// <summary>
        /// 流程状态表刷新
        /// </summary>
        FishBll.Bll.ProcessStateBll _Refreshbll = null;
        FishEntity.CargoFeedbackSheetEntity _fish = null;
        private UIForms.CargoFeedbackSheetCondition _Form = null;
        FishBll.Bll.CargoFeedbackSheetBll _bll = new FishBll.Bll.CargoFeedbackSheetBll();
        private string _where = string.Empty;
        string _orderBy = " order by id asc limit 1";//limit 1
        private string _rolewhere = string.Empty;
        string getname = string.Empty;
        string getcode = string.Empty;
        public FormCargoFeedbackSheet()
        {
            InitializeComponent();
            this.panel1.Enabled = false;
        }
        public FormCargoFeedbackSheet(string name)
        {
            InitializeComponent();
            getname = name;
            this.panel1.Enabled = false;
        }
        public override void Review()
        {
            FishBll.Bll.PersonBll getnameBll = new FishBll.Bll.PersonBll();
            FishEntity.PersonEntity getModel = new FishEntity.PersonEntity();
            getModel=getnameBll.Getname(txtcreateman.Text);
            if (getModel!=null)
            {
            Review(this.Name, txtNumbering.Text,getModel.username+" "+getModel.realname, txtcode.Text);
            if (txtNumbering.Text != "")
            {
                _Refreshbll = new FishBll.Bll.ProcessStateBll();
                _Refreshbll.GetFormCargoFeedbackSheet(txtNumbering.Text);
                }
            }
            base.Review();
        }
        private void FormCargoFeedbackSheet_Load(object sender, EventArgs e)
        {
            MenuCode = "M411"; ControlButtomRoles();
            //Megres.oddNum = getname;
            if (Megres.oddNum != "" && Megres.oddNum.ToString() != "")
            {
                _rolewhere = "  code='" + Megres.oddNum + "'";
            
            List<FishEntity.CargoFeedbackSheetEntity> list = _bll.GetModelListVo(_rolewhere);
            getname = Megres.oddNum;
            Megres.oddNum = string.Empty;
            if (list == null || list.Count < 1)
            {
                _fish = null;
            }
            else
            {
                _fish = list[0];
                SetOnepound();
                this.panel1.Enabled = true;
            }
            }
        }
        public override int Query()
        {
            panel1.Enabled = true;
            if (_Form == null)
            {
                _Form = new UIForms.CargoFeedbackSheetCondition();
                _Form.StartPosition = FormStartPosition.CenterParent;
                _Form.ShowInTaskbar = false;
            }
            if (_Form.ShowDialog() != System.Windows.Forms.DialogResult.OK) return 0;
            _where = _Form.GetWhereCondition;
            List<FishEntity.CargoFeedbackSheetEntity> list = _bll.GetModelListVo(_where + _rolewhere + _orderBy);
            if (list == null || list.Count < 1)
            {
                _fish = null;
                MessageBox.Show("查无数据！");
                return 1;
            }
            else
            {
                _fish = list[0];
                SetOnepound();
                panel1.Enabled = true;
            }
            return 1;
        }
        public override int Add()
        {
            panel1.Enabled = true;

            tmiSave.Visible = true;
            tmiClose.Visible = true;
            tmiCancel.Visible = true;
            tmiDelete.Visible = false;
            tmiReview.Visible = false;
            tmiAdd.Visible = false;
            tmiModify.Visible = false;
            tmiQuery.Visible = false;
            txtcode.Text = string.Empty;
            txtsponsor.Text = FishEntity.Variable.User.username;
            txtacceptor.Text = string.Empty;
            txtprocessresult.Text = string.Empty;
            txtevaluation.Text = string.Empty;
            txtattendance.Text = string.Empty;
            txtreview.Text = string.Empty;
            txtremarks.Text = string.Empty;
            txtConfirmTheWeight.Text = string.Empty;
            if (getname!="")
            {
                FishBll.Bll.SalerequisitionBll getbll = new FishBll.Bll.SalerequisitionBll();
                FishEntity.SalesRequisitionEntity _fish1 = new FishEntity.SalesRequisitionEntity();
                _fish1 = getbll.Getname(getname);
                if (_fish1!=null)
                {
                    txtNumbering.Text = _fish1.Numbering;
                    txtCodeOdd.Text = _fish1.code;
                }
            }
            return 1;
        }
        public override void Save()
        {
            if (string.IsNullOrEmpty(txtCodeOdd.Text))
            {
                MessageBox.Show("请选择销售合同号");
                return;
            }

            FishEntity.CargoFeedbackSheetEntity _fish = new FishEntity.CargoFeedbackSheetEntity();
            _fish.Code = FishBll.Bll.SequenceUtil.GetCargoFeedbackSheetSequence();
            decimal temp;
            _fish.Sponsor = txtsponsor.Text.Trim();
            _fish.Acceptor = txtacceptor.Text.Trim();
            _fish.Processresult = txtprocessresult.Text.Trim();
            _fish.Evaluation = txtevaluation.Text.Trim();
            _fish.Attendance = txtattendance.Text.Trim();
            _fish.Review = txtreview.Text.Trim();
            _fish.Remarks = txtremarks.Text.Trim();
            _fish.ConfirmTheWeight = txtConfirmTheWeight.Text;
            _fish.Createtime = DateTime.Now;
            _fish.Createman = FishEntity.Variable.User.username;
            _fish.Modifytime = DateTime.Now;
            _fish.Modifyman = FishEntity.Variable.User.username;
            _fish.codeContract = txtCodeOdd.Text;
            _fish.Numbering = txtNumbering.Text;

            FishBll.Bll.CargoFeedbackSheetBll bll = new FishBll.Bll.CargoFeedbackSheetBll();
            bool isok = bll.Exists(_fish.Code);
            while (isok)
            {
                _fish.Code = FishBll.Bll.SequenceUtil.GetSampleSingleSequence();
                isok = bll.Exists(_fish.Code);
            }
            int id = bll.Add(_fish);
            if (id > 0)
            {
                _fish.Id = id;
                if (txtNumbering.Text!="")
                {
                    _Refreshbll = new FishBll.Bll.ProcessStateBll();
                    _Refreshbll.GetFormCargoFeedbackSheet(txtNumbering.Text);
                }
                tmiSave.Visible = false;
                tmiClose.Visible = true;
                tmiCancel.Visible = false;
                tmiDelete.Visible = true;
                tmiReview.Visible = true;
                tmiAdd.Visible = true;
                tmiModify.Visible = true;
                tmiQuery.Visible = true;
                MessageBox.Show("添加成功。");
                txtcode.Text = _fish.Code.ToString();
                txtcreateman.Text = _fish.Createman.ToString();
                txtmodifyman.Text = _fish.Modifyman.ToString();
            }
            else
            {
                // txtCode.Text = _fish.Code;
                MessageBox.Show("添加失败。");
            }
        }
        public override int Modify()
        {
            _Refreshbll = new FishBll.Bll.ProcessStateBll();
            if (_Refreshbll.ExistsNumbering(txtNumbering.Text, "hwfkExBool") == true)
            {
                MessageBox.Show("已审核无法操作！");
                return 0;
            }
            if (_fish == null)
            {
                MessageBox.Show("请查询需要修改的数据。");
                return 0;
            }
            if (string.IsNullOrEmpty(txtCodeOdd.Text))
            {
                MessageBox.Show("请选择销售合同号");
                return 0;
            }
            FishBll.Bll.CargoFeedbackSheetBll bll = new FishBll.Bll.CargoFeedbackSheetBll();
            decimal temp = 0;
            _fish.Code = txtcode.Text;
            if (bll.ExistsUpdate(_fish.Code,FishEntity.Variable.User.username)!=true)
            {
                MessageBox.Show("不是所属人无法操作！");
                return 0;
            }
            _fish.Sponsor = txtsponsor.Text.Trim();
            _fish.Acceptor = txtacceptor.Text.Trim();
            _fish.Processresult = txtprocessresult.Text.Trim();
            _fish.Evaluation = txtevaluation.Text.Trim();
            _fish.Attendance = txtattendance.Text.Trim();
            _fish.Review = txtreview.Text.Trim();
            _fish.Remarks = txtremarks.Text.Trim();
            _fish.ConfirmTheWeight = txtConfirmTheWeight.Text;
            _fish.Modifytime = DateTime.Now;
            _fish.Modifyman = FishEntity.Variable.User.username;
            _fish.codeContract = txtCodeOdd.Text;
            bool isOk = bll.Update(_fish);
            if (isOk)
            {
                if (txtNumbering.Text != "")
                {
                    _Refreshbll = new FishBll.Bll.ProcessStateBll();
                    _Refreshbll.GetFormCargoFeedbackSheet(txtNumbering.Text);
                }
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
        protected void SetOnepound()
        {
            txtcode.Text = _fish.Code;
            txtsponsor.Text = _fish.Sponsor;
            txtacceptor.Text = _fish.Acceptor;
            txtprocessresult.Text = _fish.Processresult;
            txtevaluation.Text = _fish.Evaluation;
            txtattendance.Text = _fish.Attendance;
            txtreview.Text = _fish.Review;
            txtremarks.Text = _fish.Remarks;
            txtConfirmTheWeight.Text = _fish.ConfirmTheWeight.ToString();
            txtCodeOdd.Text = _fish.codeContract;
            txtNumbering.Text = _fish.Numbering;
            txtcreateman.Text = _fish.Createman;
            txtmodifyman.Text = _fish.Modifyman;
        }

        private void txtCodeOdd_Click(object sender, EventArgs e)
        {
            FormSalesTables from = new FormSalesTables();
            from.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (from.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            txtCodeOdd.Text = string.Empty;
            txtCodeOdd.Text = from.fish.code;
        }

    }
}
