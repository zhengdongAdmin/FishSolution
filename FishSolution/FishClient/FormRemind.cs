using System;
using System . Collections . Generic;
using System . Drawing;
using System . Reflection;
using System . Windows . Forms;

namespace FishClient
{
    public partial class FormRemind :FormMenuBase
    {
        //FishEntity.ReviewEntity _list=null;
        List<FishEntity . ReviewEntity> modelList=null;
        FishBll .Bll.SetReviewBll _bll=new FishBll.Bll.SetReviewBll();

        public event EventHandler<AnnouncementRemindEventArgs> OpenFormEvent = null;
        string strWhere="1=1";
        
        public FormRemind ( )
        {
            InitializeComponent ( );

            //this . TopMost = true;
            this . ShowInTaskbar = false;

            tmiQuery .Visible = true;
            menuStrip1 . Visible = true;            
            Query ( );
        }

        public override int Query ( )
        {
            dataGridView1.Rows.Clear();
            strWhere = string . Empty;
            List<FishEntity . ReviewEntity> modelList = _bll . modelList ( FishEntity . Variable . User . username ,strWhere );
            setValue ( modelList );

            return base . Query ( );
        }
        /// <summary>
        /// 赋值给送审界面
        /// </summary>
        /// <param name="modelList"></param>
        public void setValue ( List<FishEntity . ReviewEntity> modelList )
        {
            dataGridView1 . Rows . Clear ( );
            if ( modelList != null )
            {
                foreach ( FishEntity . ReviewEntity list in modelList )
                {
                    int idx = dataGridView1 . Rows . Add ( );
                    DataGridViewRow row = dataGridView1 . Rows [ idx ];
                    row . Cells [ "userName" ] . Value = list . userName;
                    row . Cells [ "realname" ] . Value = list . realName;
                    row . Cells [ "programId" ] . Value = list . programId;
                    row . Cells [ "programName" ] . Value = list . programName;
                    row . Cells [ "code" ] . Value = list . code;
                    row . Cells [ "state" ] . Value = list . state;
                    row . Cells [ "content" ] . Value = list . content;
                    row . Cells [ "date" ] . Value = list . date;
                }
            }
        }

        private void FormRemind_Load(object sender, System.EventArgs e)
        {
            tmiQuery.Visible = true;
        }

        string bill=string.Empty,billNum=string.Empty,path=string.Empty;
        private void dataGridView1_CellClick ( object sender ,DataGridViewCellEventArgs e )
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("programName", StringComparison.OrdinalIgnoreCase) == true)
            {
                bill = dataGridView1.Rows[e.RowIndex].Cells["programName"].Value.ToString();
                billNum = dataGridView1.Rows[e.RowIndex].Cells["code"].Value.ToString();
                Reflected();
            }
        }
        void Reflected ( )
        {
            if (bill == "付款申请单" || bill == "收款记录单")
            {
                if (bill== "付款申请单")
                {
                    FormPaymentTabie PaymentTabie = new FormPaymentTabie(billNum);
                    PaymentTabie.ShowDialog();
                }
                if (bill== "收款记录单")
                {
                    FormReceiptRecordtable ReceiptRecordtable = new FormReceiptRecordtable(billNum);
                    ReceiptRecordtable.ShowDialog();
                }
            }
            else {
                if (bill.Equals("销售申请单"))
                    path = "FishClient.FormSalesRequisition";
                if (bill.Equals("预售申请单"))
                    path = "FishClient.FormPresaleRequisition";
                if (bill.Equals("鱼粉预售合同"))
                    path = "FishClient.FormPresaleRContract";
                if (bill.Equals("现货销售合同"))
                    path = "FishClient.FormSalesRContract";
                if (bill.Equals("提货单"))
                    path = "FishClient.FormBilloflading";
                if (bill.Equals("磅单"))
                    path = "FishClient.FormOnepound";
                if (bill.Equals("货物反馈单"))
                    path = "FishClient.FormCargoFeedbackSheet";
                if (bill.Equals("公司问题反馈单"))
                    path = "FishClient.FormTheproblemsheet";
                Assembly asm = Assembly.GetExecutingAssembly();
                Form doc = (Form)asm.CreateInstance(path);
                Megres.oddNum = billNum;
                doc.Show();
            }
        }

        private void OpenForm ( )
        {
            if ( OpenFormEvent != null )
            {
                OpenFormEvent ( this ,new AnnouncementRemindEventArgs ( this . modelList ) );
            }
        }

        /// <summary>
        /// 设置窗口显示位置（右下角）
        /// </summary>
        public void SetPosition ( )
        {
            Point p = new Point ( Screen . PrimaryScreen . WorkingArea . Width - this . Width - 5 ,Screen . PrimaryScreen . WorkingArea . Height - this . Height );
            this . PointToScreen ( p );
            this . Location = p;
        }

        private void FormRemind_FormClosing ( object sender ,FormClosingEventArgs e )
        {
            this . Location = new Point ( -1000 ,0 );
            e . Cancel = true;
        }

        /// <summary>
        /// 添加 窗口不获得焦点 参数。
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_NOACTIVATE = 0x08000000;
                CreateParams cp = base . CreateParams;
                //cp.Style |= 0x40000000;
                cp . ExStyle |= WS_EX_NOACTIVATE;
                return cp;
                //return base.CreateParams;
            }
        }

        protected override bool ShowWithoutActivation
        {
            get
            {
                return true;
            }
        }

    }
}
