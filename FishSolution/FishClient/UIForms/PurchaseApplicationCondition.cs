using System;
using System . Collections . Generic;
using System . ComponentModel;
using System . Data;
using System . Drawing;
using System . Text;
using System . Windows . Forms;

namespace FishClient . UIForms
{
    public partial class PurchaseApplicationCondition :FormBase
    {
        FishBll.Bll.PurchaseApplicationBll _bll=null;
        string strWhere="1=1";

        public PurchaseApplicationCondition ( )
        {
            InitializeComponent ( );
            _bll = new FishBll . Bll . PurchaseApplicationBll ( );
        }

        public string getStrWhere
        {
            get
            {
                return strWhere;
            }
        }

        private void btnCancel_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = DialogResult . Cancel;
        }

        private void btnSure_Click ( object sender ,EventArgs e )
        {
            if ( !string . IsNullOrEmpty ( cmbCodNum . Text ) )
                strWhere = " codeNum='" + cmbCodNum . Text + "'";
            else
                strWhere = " 1=1";

            this . DialogResult = DialogResult . OK;
        }

        private void PurchaseApplicationCondition_Load ( object sender ,EventArgs e )
        {
            cmbCodNum . DataSource = _bll . getCodeNumData ( );
            cmbCodNum . DisplayMember = "codeNum";
        }

    }
}
