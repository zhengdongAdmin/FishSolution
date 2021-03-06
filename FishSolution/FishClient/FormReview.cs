﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace FishClient
{
    public partial class FormReview : FormMenuBase
    {
        FishEntity.ReviewEntity model = new FishEntity.ReviewEntity();
        FishBll.Bll.SetReviewBll _bll = new FishBll.Bll.SetReviewBll();
        string programId, oddNum;
        string getcreateman;
        string Number;

        public FormReview(string programId, string oddNum, string SingleNumber)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            menuStrip1.Visible = false;
            //MessageBox.Show(FishEntity.Variable.User.roletype);
            this.oddNum = oddNum;
            this.programId = programId;
            Number = SingleNumber;
            if (_bll.examinePow(FishEntity.Variable.User.username, programId) == true)
            {
                rabExamine.Visible = true;
                if (_bll.getStr1(oddNum, programId, FishEntity.Variable.User.username, SingleNumber) == true)
                {
                    rabExamine.Text = "撤审";
                }
                else {
                    if (_bll.getStr(oddNum, programId, FishEntity.Variable.User.username) == true)
                    {
                        rabExamine.Text = "撤审";
                    }
                    else
                    {
                        if (_bll.getStr1(oddNum, programId, SingleNumber) == true)
                        {
                            rabExamine.Text = "撤审";
                        }
                        else {
                            if (_bll.getStr(oddNum, programId) == true)
                            {
                                rabExamine.Text = "撤审";
                            }
                            else {
                                rabExamine.Text = "审核";
                            }
                        }
                    }
                }
            }
            else
                rabExamine.Visible = false;
        }
        public FormReview(string programId, string oddNum, string createman, string SingleNumber)
        {
            InitializeComponent();
            getcreateman = createman;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            menuStrip1.Visible = false;
            this.oddNum = oddNum;
            this.programId = programId;
            Number = SingleNumber;
            if (_bll.examinePow(FishEntity.Variable.User.username, programId) == true)
            {
                rabExamine.Visible = true;
                if (_bll.getStr1(oddNum, programId, FishEntity.Variable.User.username, SingleNumber) == true)
                {
                    rabExamine.Text = "撤审";
                }
                else if (_bll.getStr1(oddNum, programId, SingleNumber) == true)
                {
                    rabExamine.Text = "撤审";
                }
                else if (_bll.getStr(oddNum, programId, FishEntity.Variable.User.username) == true)
                {
                    rabExamine.Text = "撤审";
                }
                else if (_bll.getStr(oddNum, programId) == true)
                {
                    rabExamine.Text = "撤审";
                }
                else {
                    rabExamine.Text = "审核";
                }
            }
            else
                rabExamine.Visible = false;
        }


        private void btnOk_Click(object sender, System.EventArgs e)
        {
            if (rabReview.Checked == false && rabReject.Checked == false && rabExamine.Checked == false && radioAdopt.Checked == false && radioInform.Checked == false)
            {
                MessageBox.Show("请选择");
                return;
            }
            if (rabExamine.Checked == false && string.IsNullOrEmpty(texReview.Text))
            {
                MessageBox.Show("请选择送审对象");
                return;
            }

            List<FishEntity.ReviewEntity> modelList = new List<FishEntity.ReviewEntity>();



            string[] strUser;
            if (texReview.Text.Contains("|"))
            {
                string[] strSplit = texReview.Text.Split('|');

                foreach (string s in strSplit)
                {
                    model = new FishEntity.ReviewEntity();
                    strUser = s.Trim().Split(' ');
                    if (strUser.Length >= 2)
                    {
                        getValue(model);
                        model.userNameReview = strUser[0];
                        modelList.Add(model);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(texReview.Text))
            {
                strUser = texReview.Text.Trim().Split(' ');
                if (strUser.Length >= 2)
                {
                    model = new FishEntity.ReviewEntity();
                    getValue(model);
                    model.userNameReview = strUser[0];
                    modelList.Add(model);
                }
            }
            else
            {
                model = new FishEntity.ReviewEntity();
                getValue(model);
                model.userNameReview = string.Empty;
                modelList.Add(model);
            }
            if (model.state.Equals("撤审") == false)
            {
                bool result = _bll.Review(modelList);
                if (result == true)
                {
                    MessageBox.Show("送审成功");
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("送审失败");
            }
            else if (model.state.Equals("撤审") == true)
            {
                bool result = _bll.examine(model.Numbering, model.programId);
                if (result == true)
                {
                    MessageBox.Show("撤审成功");
                    this.DialogResult = DialogResult.OK;
                }
                else {
                    if (_bll.examine(model.Numbering, model.programId, FishEntity.Variable.User.username) == true)
                    {
                        MessageBox.Show("撤审成功");
                        this.DialogResult = DialogResult.OK;
                    }
                    else {                   
                    bool inx = _bll.examine_1(model.Numbering, model.programId, Number);
                        if (inx == true)
                    {
                        MessageBox.Show("撤审成功");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        if (_bll.examine_1(model.Numbering, model.programId, FishEntity.Variable.User.username, Number) == true) 
                            {
                            MessageBox.Show("撤审成功");
                            this.DialogResult = DialogResult.OK;
                        }
                        else {
                            MessageBox.Show("撤审失败");
                            }
                        }
                    }
                }
            }
        }

        void getValue(FishEntity.ReviewEntity model)
        {
            model.programId = this.programId;
            model.Numbering = this.oddNum;
            model.content = richOpinion.Text;
            model.createMan = model.modifyMan = FishEntity.Variable.User.username;
            model.userName = FishEntity.Variable.User.username;
            model.SingleNumber = Number;
            if (rabExamine.Checked == true)
                model.state = rabExamine.Text;
            else if (rabReview.Checked == true)
                model.state = rabReview.Text;
            else if (rabReject.Checked == true)
                model.state = rabReject.Text;
            else if (radioAdopt.Checked == true)
                model.state = radioAdopt.Text;
            else if (radioInform.Checked == true)
                model.state = radioInform.Text;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        FishBll.Bll.DeliveredManagementBll getBll = null;
        FishEntity.DeliveredManagementEntity getModel = null;
        private void rabReview_Click(object sender, System.EventArgs e)
        {
            if (rabReview.Checked == true)
            {
                getBll = new FishBll.Bll.DeliveredManagementBll();
                getModel = new FishEntity.DeliveredManagementEntity();
                getModel = getBll.getList("");
                switch (this.programId)
                {
                    case "FormSalesRequisition": texReview.Text = getModel.txtTJxssqd; break;
                    case "FormSalesRContract": texReview.Text = getModel.txtTJxsht; break;
                    case "FormPaymentRequisition": texReview.Text = getModel.txtTJfksqd; break;
                    case "FormOnepound": texReview.Text = getModel.txtTJbd; break;
                    case "FormCargoFeedbackSheet": texReview.Text = getModel.txtTJhwfkd; break;
                    case "FormTheproblemsheet": texReview.Text = getModel.txtTJgswtfkd; break;
                    case "FormReceiptRecord": texReview.Text = getModel.txtTJskjld; break;
                }
            }
        }

        private void rabExamine_Click(object sender, System.EventArgs e)
        {
            if (rabExamine.Checked == true)
            {
                getBll = new FishBll.Bll.DeliveredManagementBll();
                getModel = new FishEntity.DeliveredManagementEntity();
                getModel = getBll.getList("");
                switch (this.programId)
                {
                    case "FormSalesRequisition": texReview.Text = getModel.txtSGxssqd; break;
                    case "FormSalesRContract": texReview.Text = getModel.txtSGxsht; break;
                    case "FormPaymentRequisition": texReview.Text = getModel.txtSGfksqd; break;
                    case "FormOnepound": texReview.Text = getModel.txtSGbd; break;
                    case "FormCargoFeedbackSheet": texReview.Text = getModel.txtSGhwfkd + "|" + getcreateman; break;
                    case "FormTheproblemsheet": texReview.Text = getModel.txtSGgswtfkd; break;
                    case "FormReceiptRecord": texReview.Text = getModel.txtSGskjld; break;
                }
            }
        }

        private void texReview_Click(object sender, System.EventArgs e)
        {
            FormUserList from = new FormUserList(true);
            from.StartPosition = FormStartPosition.CenterParent;
            if (from.ShowDialog() != DialogResult.OK)
                return;
            texReview.Text = from.getStr;
        }
    }
}
