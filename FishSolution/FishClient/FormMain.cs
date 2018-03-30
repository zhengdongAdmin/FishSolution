using System;
using System . Drawing;
using System . Windows . Forms;

namespace FishClient
{
    public partial class FormMain : FormBase
    {
        ThreadManager _threadManager = null;
        FormPushMessage _formPushMessage = null; FormRemind _formRemind=null;
        MdiClient _mdiClient = null;
        public FormMain()
        {
            InitializeComponent();
            this.Location = new Point(-1000, -1000);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Login();
        }
        //功能
        protected void GetUserRoles()
        {
            if (FishEntity.Variable.User == null) return;
            FishBll.Bll.PersonBll bll = new FishBll.Bll.PersonBll();
            FishEntity.Variable.Roles = bll.GetPersionRoles(FishEntity.Variable.User.id);
        }

        protected void Login()
        {
            this.Hide();
            FormLogin form = new FormLogin();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Location = new Point(0, 0);
                this.WindowState = FormWindowState.Maximized;
                this.Show();
                this.BringToFront();
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    MdiClient client = this.Controls[i] as MdiClient;
                    if (client == null) continue;
                    _mdiClient = client;
                    _mdiClient.BackColor = Color.White;
                    break;
                }
                //判断页面
                GetUserRoles();

                LoadTreeMenu();

                ShowMenuByRoles();

                tSSLUser.Text = FishEntity.Variable.User == null ? string.Empty : FishEntity.Variable.User.realname + "(" + FishEntity.Variable.User.roletype + ")";

                DrawMdiClientBackground();

                ShowPushMessageForm();

                StartBackThread();

            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// 启动线程
        /// </summary>
        protected void StartBackThread()
        {
            _threadManager = new ThreadManager();
            _threadManager.UIAnnouncementCallBackEvent += _threadManager_UIAnnouncementCallBackEvent;
            _threadManager.StartThread();

            _threadManager . UIAnnouncementRemindEvent += _threadManaget_UIAnnouncementRemindCallBackEvent;
            _threadManager . StartRemidThread ( );
        }

        /// <summary>
        /// 发现有新的信息，这在右下方弹出窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _threadManager_UIAnnouncementCallBackEvent(object sender, AnnouncementEventArgs e)
        {
            if (e.Announcement == null) return;
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler<AnnouncementEventArgs>(_threadManager_UIAnnouncementCallBackEvent), new object[] { sender, e });
            }
            else
            {
                if (_formPushMessage == null)
                {
                    _formPushMessage = new FormPushMessage();
                    _formPushMessage.Location = new Point(-1000, 0);
                }
                else
                {
                    _formPushMessage.OpenFormEvent -= _formPushMessage_OpenFormEvent;
                    _formPushMessage.OpenFormEvent += _formPushMessage_OpenFormEvent;
                    _formPushMessage.SetPosition();
                }

                _formPushMessage.SetCustomer(e.Announcement);

                Utility.NativeMethods.ShowWindow(new System.Runtime.InteropServices.HandleRef(_formPushMessage, _formPushMessage.Handle), 4);
            }
        }

        void _threadManaget_UIAnnouncementRemindCallBackEvent ( object sender ,AnnouncementRemindEventArgs e )
        {
            if ( e . AnnouncementRemind == null )
                return;
            if ( this . InvokeRequired )
            {
                this . Invoke ( new EventHandler<AnnouncementRemindEventArgs> ( _threadManaget_UIAnnouncementRemindCallBackEvent ) ,new object [ ] { sender ,e } );
            }
            else
            {
                if ( _formRemind == null )
                {
                    _formRemind = new FormRemind ( );
                    _formRemind . Location = new Point ( -1000 ,0 );
                }
                else
                {
                    _formRemind . SetPosition ( );
                }

                _formRemind . setValue ( e . AnnouncementRemind );

                Utility . NativeMethods . ShowWindow ( new System . Runtime . InteropServices . HandleRef ( _formRemind ,_formRemind . Handle ) ,4 );
            }
        }

        void _formPushMessage_OpenFormEvent(object sender, AnnouncementEventArgs e)
        {
            if (e == null || e.Announcement == null) return;

            buttom_Click(btnTip, EventArgs.Empty);


            //buttom_Click(btnLinkman, EventArgs.Empty);

            //if (btnLinkman.Form != null && btnLinkman.Form is FormLinkman)
            //{
            //   (btnLinkman.Form as FormLinkman).SetCustomer(e.Announcement);
            //}                 
        }

        /// <summary>
        /// 停止线程
        /// </summary>
        public void StopBackThread()
        {
            if (_threadManager == null) return;
            _threadManager.StopThread();
            _threadManager . StopRemindThread ( );
        }

        /// <summary>
        /// 显示主界面时，把消息弹出框隐藏在最左边
        /// </summary>
        protected void ShowPushMessageForm()
        {
            try
            {
                if (_formPushMessage == null)
                {
                    _formPushMessage = new FormPushMessage();
                }
                _formPushMessage.Show();
                _formPushMessage.Location = new Point(-1000, 0);
                if ( _formRemind == null )
                {
                    _formRemind = new FormRemind ( );
                }
                _formRemind . Show ( );
                _formRemind . Location = new Point ( -1000 ,0 );
            }
            catch (Exception ex)
            {
                Utility.LogHelper.WriteException(ex);
            }
        }
        protected void LoadTreeMenu()
        {
            btnRole.FormType = typeof(FormRoles);
            btnSystemData.FormType = typeof(FormSystemDataSet);
            btnProductData.FormType = typeof(FormProductDataSet);
            btnUserData.FormType = typeof(FormUserList);
            btnCompany.FormType = typeof(FormCompany);
            btnLinkman.FormType = typeof(FormLinkman);
            btnFish.FormType = typeof(FormFish);
            btnQuote.FormType = typeof(FormQuote);
            btnStorageBills.FormType = typeof(FormStorageBills);
            btnCallRecords.FormType = typeof(FormCallRecords);
            btnhomemadebill.FormType = typeof(FormHomemadeStorage);
            btnCheck.FormType = typeof(FormCheck);
            btnStorageOut.FormType = typeof(FormFoodOut);
            btngoods.FormType = typeof(FormLoadingBills);
            btnShippingRecords.FormType = typeof(FormShippingRecords);

            btnCallRecordReport.FormType = typeof(FormCallRecordsTable);
            btnRequiredReport.FormType = typeof(FormRequredForecastReport);
            btnFlowingReport.FormType = typeof(FormSelftStorageFlowingReport);
            btnStorageReport.FormType = typeof(FormStorageReport);
            btnCustomerAnsyleReport.FormType = typeof(FormCustomerAnalysisTable);
            btnCompanyList.FormType = typeof(FormCompanyList);

            btnInventoryAccount.FormType = typeof(FormInventory);
            btnTip.FormType = typeof(FormRemindMessage);

            btnFurtureContract.FormType = typeof(Contract.FormFuturesContract);
            btnProductContract1.FormType = typeof(Contract.FormProductContract1);
            btnProductContract2.FormType = typeof(Contract.FormProductContract2);
            btnProcessState.FormType = typeof(FormProcessState);
            btnConfirm.FormType = typeof(FormConfirm);
            btnSpot.FormType = typeof(FormSpot);
            btnSelfSale.FormType = typeof(FormSelfSale);
            btnSelfMake.FormType = typeof(FormSelfMake);
            btnSaleRecord.FormType = typeof(FormSaleRecordReport);
            btnFinish.FormType = typeof(FormFinish);
            btnSalesRequisition.FormType = typeof(FormSalesRequisition);//
            btnPresaleRequisition.FormType = typeof(FormPresaleRequisition);
            btnPaymentRequisition.FormType = typeof(FormPaymentRequisition);
            btnTheproblemsheet.FormType = typeof(FormTheproblemsheet);
            btnDisposeofcomments.FormType = typeof(FormDisposeofcomments);
            btnOnepound.FormType = typeof(FormOnepound);
            btnBilloflading.FormType = typeof(FormBilloflading);
            btnPoundsingletable.FormType = typeof(FormPoundsingletable);
            btnBilloftable.FormType = typeof(FormBilloftable);
            btnPurchasingSales.FormType = typeof(FormPurchasingSales);
            btnEnterWarehouseReceipts.FormType = typeof(FormEnterWarehouseReceipts);
            btnSampleSingle.FormType = typeof(FormSampleSingle);
            btnContractProcessingSheet.FormType = typeof(FormContractProcessingSheet);
            btnEntry.FormType = typeof(FormEntry);
            btnCargoFeedbackSheet.FormType = typeof(FormCargoFeedbackSheet);
            btningredients.FormType = typeof(Formingredients);
            btnPurchaseWarehousing.FormType = typeof(FormPurchaseWarehousing);
            btnSalesOutOfTheLibrary.FormType = typeof(FormSalesOutOfTheLibrary);
            btnInquiry.FormType = typeof(FromInquiry);
            btnReceiptRecord.FormType = typeof(FormReceiptRecord);
            btnAccountsReceivable.FormType = typeof(FormAccountsReceivable);
            btnPresaleRContract.FormType = typeof(FormPresaleRContract);
            btnSalesRContract.FormType = typeof(FormSalesRContract);
            btnSalesTables.FormType = typeof(FormSalesTables);
            btnSetReview.FormType = typeof(FormSetReview);
            btnProgram.FormType = typeof(FormProgram);
            btnRemind.FormType = typeof(FormRemind);
            btnPresaleTable.FormType = typeof(FormPresaleTable);
            btnPaymentForm.FormType = typeof(FormPaymentForm);
            btnReceiptRecordForm.FormType = typeof(FormReceiptRecordForm);
            btnJinCangTable.FormType = typeof(FormJinCangTable);
            btnHomemadeWarehouseTable.FormType = typeof(FormHomemadeWarehouseTable);
            btnPurchaseRequisition.FormType = typeof(FormPurchaseRequisition);
            btnTotalDataSheet.FormType = typeof(FormTotalDataSheet);
            btnDeliveredManagement.FormType = typeof(FormDeliveredManagement);
            btnSalesAssessment.FormType = typeof(FormSalesAssessment);

            btnFormPurchaseApplication . FormType = typeof ( FormPurchaseApplication );

            btnRole.Image = btnSystemData.Image = btnProductData.Image = btnTotalDataSheet .Image= btnUserData.Image = btnFish.Image = btnEnterWarehouseReceipts.Image = btnSampleSingle.Image = btnEntry.Image = btnCargoFeedbackSheet.Image = btnSalesOutOfTheLibrary.Image =
            btnCallRecords.Image = btnCheck.Image = btngoods.Image = btnhomemadebill.Image = btnQuote.Image = btnStorageBills.Image = btnStorageOut.Image = btningredients.Image = btnPurchaseWarehousing.Image = btnInquiry.Image = btnSalesRContract.Image = btnDeliveredManagement.Image=
            btnCallRecordReport.Image = btnRequiredReport.Image = btnFlowingReport.Image = btnStorageReport.Image = btnCustomerAnsyleReport.Image = btnPresaleRContract.Image = btnPurchaseRequisition.Image= ImageUtil.ButtonLeftImageNormal;

            btnSetReview.Image = btnProgram.Image = btnRemind.Image = btnShippingRecords.Image = btnProcessState.Image= btnPresaleTable.Image= btnReceiptRecordForm.Image=btnJinCangTable.Image= btnHomemadeWarehouseTable.Image= btnSalesAssessment .Image= ImageUtil.ButtonLeftImageNormal;

            btnFurtureContract.Image = btnProductContract1.Image = btnProductContract2.Image = btnOnepound.Image = btnBilloflading.Image = btnContractProcessingSheet.Image = btnReceiptRecord.Image = btnAccountsReceivable.Image = btnSalesTables.Image =
            btnConfirm.Image = btnSpot.Image = btnSelfSale.Image = btnSelfMake.Image = btnTheproblemsheet.Image = btnPoundsingletable.Image= btnCompanyList.Image = ImageUtil.ButtonLeftImageNormal;
            btnInventoryAccount.Image = btnTip.Image = btnDisposeofcomments.Image = btnBilloftable.Image = btnPurchasingSales.Image = btnPaymentForm.Image = ImageUtil.ButtonLeftImageNormal;
            btnSaleRecord.Image = btnFinish.Image = btnSalesRequisition.Image = btnPresaleRequisition.Image = btnPaymentRequisition.Image = btnCompany.Image = btnLinkman.Image = ImageUtil.ButtonLeftImageNormal;
            btnFormPurchaseApplication . Image = ImageUtil . ButtonLeftImageNormal;
        }

        protected void ShowMenuByRoles()
        {
            if (FishEntity.Variable.Roles == null || FishEntity.Variable.Roles.Count < 1) return;

            ShowMenuByRoles(pushPanelItem1);
            ShowMenuByRoles(pushPanelItem2);
            ShowMenuByRoles(pushPanelItem3);
            ShowMenuByRoles(pushPanelItem4);
        }

        protected void ShowMenuByRoles(UILibrary.PushPanel.PushPanelItem pnl)
        {
            foreach (Control ctl in pnl.Controls)
            {
                UIControls.ButtonEx btn = ctl as UIControls.ButtonEx;
                if (btn == null) continue;
                if (string.IsNullOrEmpty(btn.FunctionCode))
                {
                    btn.Visible = false;
                    continue;
                }
                string code = btn.FunctionCode;
                bool isexist = FishEntity.Variable.Roles.Exists((i) => { return i.funcode.Equals(code, StringComparison.OrdinalIgnoreCase); });
                btn.Visible = isexist;
            }
        }
        //
        protected Form ActivtorForm(Type formType)
        {
            return Activator.CreateInstance(formType) as Form;
        }

        private void DrawMdiClientBackground()
        {
            if (this.IsMdiContainer == false) return;
            if (_mdiClient == null) return;
            if (_mdiClient.ClientSize.Width <= 0 || _mdiClient.ClientSize.Height <= 0) return;
            string path = Application.StartupPath + "\\Images\\bgbar.jpg";
            if (System.IO.File.Exists(path) == false) return;

            Image mdiBg_Image = Image.FromFile(path);
            System.Drawing.Bitmap myImg = new Bitmap(_mdiClient.ClientSize.Width, _mdiClient.ClientSize.Height);
            System.Drawing.Graphics myGraphics = System.Drawing.Graphics.FromImage(myImg);
            myGraphics.Clear(Color.White);

            int myX = 0;
            int myY = 0;
            myX = (myImg.Width - mdiBg_Image.Width) / 2;
            myY = (myImg.Height - mdiBg_Image.Height) / 2;

            myGraphics.DrawImage(mdiBg_Image, myX, myY, mdiBg_Image.Width, mdiBg_Image.Height);
            _mdiClient.BackgroundImage = myImg;
            myGraphics.Dispose();
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            DrawMdiClientBackground();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopBackThread();
        }

        private void buttom_Click(object sender, EventArgs e)
        {
            UIControls.ButtonEx currentBtn = sender as UIControls.ButtonEx;
            if (currentBtn == null) return;

            currentBtn.Image = ImageUtil.ButtomLeftImageSelected;

            foreach (UILibrary.PushPanel.PushPanelItem item in pushPanel1.Items)
            {
                foreach (Control ctl in item.Controls)
                {
                    UILibrary.SkinButtom btn = ctl as UILibrary.SkinButtom;
                    if (btn == null) continue;
                    if (btn.Equals(currentBtn)) continue;
                    btn.Image = ImageUtil.ButtonLeftImageNormal;
                }
            }


            if (currentBtn.Form == null) return;

            if (currentBtn.Form is FormFish)
            {
                FormFish form = currentBtn.Form as FormFish;
                form.ClickGBEvent += form_ClickGBEvent;
            }
            else if (currentBtn.Form is FormQuote)
            {
                FormQuote form = currentBtn.Form as FormQuote;
                form.ClickFishEvent += form_ClickFishEvent;
            }
            else if (currentBtn.Form is FormConfirm)
            {
                FormConfirm form = currentBtn.Form as FormConfirm;
                form.ClickFishEvent += form_ClickFishEvent;
            }
            else if (currentBtn.Form is FormSpot)
            {
                FormSpot form = currentBtn.Form as FormSpot;
                form.ClickFishEvent += form_ClickFishEvent;
            }
            else if (currentBtn.Form is FormSelfSale)
            {
                FormSelfSale form = currentBtn.Form as FormSelfSale;
                form.ClickFishEvent += form_ClickFishEvent;
            }
            else if (currentBtn.Form is FormSelfMake)
            {
                FormSelfMake form = currentBtn.Form as FormSelfMake;
                form.ClickFishEvent += form_ClickFishEvent;
            }
            else if (currentBtn.Form is FormRemindMessage)
            {
                FormRemindMessage form = currentBtn.Form as FormRemindMessage;
                form.ClickRemindEvent += form_ClickRemindEvent;
            }
            ///父窗口
            //currentBtn.Form.MdiParent = this;
            currentBtn.Form.Show();
            currentBtn.Form.BringToFront();

        }

        void form_ClickRemindEvent(object sender, EventArgs e)
        {
            buttom_Click(btnCallRecords, EventArgs.Empty);
        }

        void form_ClickFishEvent(object sender, EventArgs e)
        {
            buttom_Click(btnFish, EventArgs.Empty);
        }

        void form_ClickGBEvent(object sender, EventArgs e)
        {
            buttom_Click(btnCheck, EventArgs.Empty);
        }
    }
}
