using System;
using System . Windows . Forms;

namespace FishClient
{
    //table:t_purchaseApplication

    public partial class FormPurchaseApplication :FormMenuBase
    {
        FishEntity.PurchaseApplicationEntity _model=null;
        FishBll.Bll.PurchaseApplicationBll _bll=null;
        bool result=false;string state=string.Empty; decimal outResult = 0M;
        string strWhere=string.Empty;

        public FormPurchaseApplication ( )
        {
            InitializeComponent ( );

            _model = new FishEntity . PurchaseApplicationEntity ( );
            _bll = new FishBll . Bll . PurchaseApplicationBll ( );

            this . txtprice . LostFocus += txtprice_LostFocus;
            this . txtpriceMY . LostFocus += txtpriceMY_LostFocus;
        }

        private void FormPurchaseApplication_Load ( object sender ,EventArgs e )
        {
            InitDataUtil . BindComboBoxData ( txtvarieties ,FishEntity . Constant . Goods ,true );
            InitDataUtil . BindComboBoxData ( txtquaSpe ,FishEntity . Constant . Specification ,true );
            InitDataUtil . BindComboBoxData ( txtconutry ,FishEntity . Constant . CountryType ,true );
            InitDataUtil . BindComboBoxData ( txtbrand ,FishEntity . Constant . Brand ,true );
        }

        #region Main
        public override int Query ( )
        {
            UIForms . PurchaseApplicationCondition form = new UIForms . PurchaseApplicationCondition ( );
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                strWhere = form . getStrWhere;
                _model = _bll . getModel ( strWhere );
                if ( _model == null )
                {
                    MessageBox . Show ( "请重新查询" );
                    return 0;
                }
                setValue ( );
            }

            return base . Query ( );
        }
        public override int Add ( )
        {
            controlClear ( );
            txtCodeNum . Text = _bll . getCodeNum ( );
            state = "add";

            return base . Add ( );
        }
        public override int Delete ( )
        {
            _model . id = txtCodeNum . Tag == null ? 0 : Convert . ToInt32 ( txtCodeNum . Tag );
            if ( _bll . ExistsCodeNumContract ( _model . id ) )
            {
                MessageBox . Show ( "改采购申请单已经被采购合同引用,不允许删除" );
                return 0;
            }
            result = _bll . Delete ( _model . id );
            if ( result )
            {
                MessageBox . Show ( "成功删除" );
                controlClear ( );
            }
            else
                MessageBox . Show ( "删除失败,请重试" );

            return base . Delete ( );
        }
        public override int Modify ( )
        {
            state = "edit";

            return base . Modify ( );
        }
        public override void Save ( )
        {
            errorProvider1 . Clear ( );
            if ( string . IsNullOrEmpty ( txtCodeNum . Text ) )
            {
                errorProvider1 . SetError ( txtCodeNum ,"不可为空" );
                return;
            }
            if ( string . IsNullOrEmpty ( txtfishId . Text ) )
            {
                errorProvider1 . SetError ( txtfishId ,"不可为空" );
                return;
            }
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( txtbondPro . Text ) && decimal . TryParse ( txtbondPro . Text ,out outResult ) == false )
            {
                errorProvider1 . SetError ( txtbondPro ,"请重新填写" );
                return;
            }
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( txtheight . Text ) && decimal . TryParse ( txtheight . Text ,out outResult ) == false )
            {
                errorProvider1 . SetError ( txtheight ,"请重新填写" );
                return;
            }
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( txtprice . Text ) && decimal . TryParse ( txtprice . Text ,out outResult ) == false )
            {
                errorProvider1 . SetError ( txtprice ,"请重新填写" );
                return;
            }
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( txtrebate . Text ) && decimal . TryParse ( txtrebate . Text ,out outResult ) == false )
            {
                errorProvider1 . SetError ( txtrebate ,"请重新填写" );
                return;
            }
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( txtpriceMY . Text ) && decimal . TryParse ( txtpriceMY . Text ,out outResult ) == false )
            {
                errorProvider1 . SetError ( txtpriceMY ,"请重新填写" );
                return;
            }
            getValue ( );
            if ( state . Equals ( "add" ) )
                _model . id = _bll . Add ( _model );
            else
                _model . id = _bll . Edit ( _model );
            if ( _model . id > 0 )
            {
                MessageBox . Show ( "保存成功" );
                if ( state . Equals ( "add" ) )
                    txtCodeNum . Tag = _model . id;
            }
            else
                MessageBox . Show ( "保存失败" );

            base . Save ( );
        }
        public override void Review ( )
        {


            base . Review ( );
        }
        public override void Previous ( )
        {
            QueryOne ( "<" ,"order by id asc limit 1" );

            base . Previous ( );
        }
        public override void Next ( )
        {
            QueryOne ( ">" ,"order by id asc limit 1" );

            base . Next ( );
        }
        #endregion

        #region Method
        void controlClear ( )
        {
            txtbillNum . Text = txtbondPro . Text = txtbrand . Text = txtbuyer . Text = txtbuyerAbb . Text = txtbuyerUser . Text = txtCodeNum . Text = txtcodeNumContract . Text = txtconDAS . Text = txtconFFA . Text = txtconHF . Text = txtconLAS . Text = txtconProtein . Text = txtconS . Text = txtconSF . Text = txtconSHY . Text = txtconSJ . Text = txtconTVN . Text = txtconutry . Text = txtconZA . Text = txtconZF . Text = txtdeliveryAdd . Text = txtdeliveryLast . Text = txtfishId . Text = txtheight . Text = txtMoney . Text = txtMoneyMJ . Text = txtprice . Text = txtpriceMY . Text = txtproName . Text = txtquaSpe . Text = txtrebate . Text = txtSGSDB . Text = txtSGSFFA . Text = txtSGSHF . Text = txtSGSS . Text = txtSGSSF . Text = txtSGSSHY . Text = txtSGSSJ . Text = txtSGSTVN . Text = txtSGSZA . Text = txtSGSZF . Text = txtshipName . Text = txtsignAdd . Text = txtsupplier . Text = txtsupplierAbb . Text = txtsupplierUser . Text = txtvarieties . Text = textRemarkOf . Text = string . Empty;
            datearriveDate . Value = datedeliveryDate . Value = dateshipDate . Value = datesignDate . Value = DateTime . Now;
        }
        void getValue()
        {
            _model . codeNum = txtCodeNum . Text;
            _model . codeNumContract  = txtcodeNumContract . Text;
            _model . supplier = txtsupplier . Text;
            _model . supplierAbb = txtsupplierAbb . Text;
            _model . supplierUser = txtsupplierUser . Text;
            _model . buyer = txtbuyer . Text;
            _model . buyerAbb = txtbuyerAbb . Text;
            _model . buyerUser = txtbuyerUser . Text;
            _model . signDate = datesignDate . Value;
            _model . signAdd = txtsignAdd . Text;
            _model . proName = txtproName . Text;
            _model . bondPro = string . IsNullOrEmpty ( txtbondPro . Text ) == true ? 0 : Convert . ToDecimal ( txtbondPro . Text );
            _model . varieties = txtvarieties . Text;
            _model . quaSpe = txtquaSpe . Text;
            _model . height = string . IsNullOrEmpty ( txtheight . Text ) == true ? 0 : Convert . ToDecimal ( txtheight . Text );
            _model . price = string . IsNullOrEmpty ( txtprice . Text ) == true ? 0 : Convert . ToDecimal ( txtprice . Text );
            _model . rebate = string . IsNullOrEmpty ( txtrebate . Text ) == true ? 0 : Convert . ToDecimal ( txtrebate . Text );
            _model . priceMY = string . IsNullOrEmpty ( txtpriceMY . Text ) == true ? 0 : Convert . ToDecimal ( txtpriceMY . Text );
            _model . conutry = txtconutry . Text;
            _model . brand = txtbrand . Text;
            _model . shipName = txtshipName . Text;
            _model . billNum = txtbillNum . Text;
            _model . shipDate = dateshipDate . Value;
            _model . arriveDate = datearriveDate . Value;
            _model . deliveryDate = datedeliveryDate . Value;
            _model . SGSDB = txtSGSDB . Text;
            _model . SGSTVN = txtSGSTVN . Text;
            _model . SGSZA = txtSGSZA . Text;
            _model . SGSFFA = txtSGSFFA . Text;
            _model . SGSZF = txtSGSZF . Text;
            _model . SGSSF = txtSGSSF . Text;
            _model . SGSSHY = txtSGSSHY . Text;
            _model . SGSS = txtSGSS . Text;
            _model . SGSSJ = txtSGSSJ . Text;
            _model . SGSHF = txtSGSHF . Text;
            _model . deliveryAdd = txtdeliveryAdd . Text;
            if ( string . IsNullOrEmpty ( txtdeliveryLast . Text ) )
                _model . deliveryLast = null;
            else
                _model . deliveryLast = Convert . ToDateTime ( txtdeliveryLast . Text );
            _model . fishId = txtfishId . Text;
            _model . conProtein = txtconProtein . Text;
            _model . conTVN = txtconTVN . Text;
            _model . conZA = txtconZA . Text;
            _model . conFFA = txtconFFA . Text;
            _model . conZF = txtconZF . Text;
            _model . conSF = txtconSF . Text;
            _model . conSHY = txtconSHY . Text;
            _model . conS = txtconS . Text;
            _model . conSJ = txtconSJ . Text;
            _model . conHF = txtconHF . Text;
            _model . conLAS = txtconLAS . Text;
            _model . conDAS = txtconDAS . Text;
            _model . remark = textRemarkOf . Text;
        }
        void setValue ( )
        {
            txtCodeNum . Text = _model . codeNum;
            txtcodeNumContract . Text = _model . codeNumContract;
            txtsupplier . Text = _model . supplier;
            txtsupplierAbb . Text = _model . supplierAbb;
            txtsupplierUser . Text = _model . supplierUser;
            txtbuyer . Text = _model . buyer;
            txtbuyerAbb . Text = _model . buyerAbb;
            txtbuyerUser . Text = _model . buyerUser;
            datesignDate . Value = Convert . ToDateTime ( _model . signDate );
            txtsignAdd . Text = _model . signAdd;
            txtproName . Text = _model . proName;
            txtbondPro . Text = Convert . ToDecimal ( _model . bondPro ) . ToString ( "f3" );
            txtvarieties . Text = _model . varieties;
            txtquaSpe . Text = _model . quaSpe;
            txtheight . Text = Convert . ToDecimal ( _model . height ) . ToString ( "f2" );
            txtprice . Text = Convert . ToDecimal ( _model . price ) . ToString ( "f2" );
            txtrebate . Text = Convert . ToDecimal ( _model . rebate ) . ToString ( "f2" );
            txtpriceMY . Text = Convert . ToDecimal ( _model . priceMY ) . ToString ( "f2" );
            txtconutry . Text = _model . conutry;
            txtbrand . Text = _model . brand;
            txtshipName . Text = _model . shipName;
            txtbillNum . Text = _model . billNum;
            dateshipDate . Value = Convert . ToDateTime ( _model . shipDate );
            datearriveDate . Value = Convert . ToDateTime ( _model . arriveDate );
            datedeliveryDate . Value = Convert . ToDateTime ( _model . deliveryDate );
            txtSGSDB . Text = _model . SGSDB;
            txtSGSTVN . Text = _model . SGSTVN;
            txtSGSZA . Text = _model . SGSZA;
            txtSGSFFA . Text = _model . SGSFFA;
            txtSGSZF . Text = _model . SGSZF;
            txtSGSSF . Text = _model . SGSSF;
            txtSGSSHY . Text = _model . SGSSHY;
            txtSGSS . Text = _model . SGSS;
            txtSGSSJ . Text = _model . SGSSJ;
            txtSGSHF . Text = _model . SGSHF;
            txtdeliveryAdd . Text = _model . deliveryAdd;
            if ( _model . deliveryLast < DateTime . MinValue || _model . deliveryLast > DateTime . MaxValue )
                txtdeliveryLast . Text = string . Empty;
            else
                txtdeliveryLast . Text = _model . deliveryLast . ToString ( );
            txtfishId . Text = _model . fishId;
            txtconProtein . Text = _model . conProtein;
            txtconTVN . Text = _model . conTVN;
            txtconZA . Text = _model . conZA;
            txtconFFA . Text = _model . conFFA;
            txtconZF . Text = _model . conZF;
            txtconSF . Text = _model . conSF;
            txtconSHY . Text = _model . conSHY;
            txtconS . Text = _model . conS;
            txtconSJ . Text = _model . conSJ;
            txtconHF . Text = _model . conHF;
            txtconLAS . Text = _model . conLAS;
            txtconDAS . Text = _model . conDAS;
            textRemarkOf . Text = _model . remark;
        }
        void calcuMonry ( )
        {
            txtMoney . Text = Math . Round ( Convert . ToDecimal ( txtheight . Text ) * Convert . ToDecimal ( txtprice . Text ) ,2 ) . ToString ( );
        }
        void calcuMonryMJ ( )
        {
            txtMoneyMJ . Text = Math . Round ( Convert . ToDecimal ( txtheight . Text ) * Convert . ToDecimal ( txtpriceMY . Text ) ,2 ) . ToString ( );
        }
        void QueryOne ( string operate ,string orderBy )
        {
            string whereEx = string . Empty;
            if ( string . IsNullOrEmpty ( strWhere ) )
                whereEx = "1=1";
            else
                whereEx = strWhere;
            if ( _model != null )
                whereEx = whereEx + " AND codeNum " + operate + orderBy;

            _model = _bll . getModel ( whereEx );
            if ( _model == null )
            {
                MessageBox . Show ( "已经没有记录了" );
                return;
            }
            setValue ( );
        }
        #endregion

        #region Event
        //供方 需方
        private void txtsupplier_DoubleClick ( object sender ,EventArgs e )
        {
            FormCompanyList form = new FormCompanyList ( );
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                _model = form . getModel;
                txtsupplier . Text = _model . supplier;
                txtsupplierAbb . Text = _model . supplierAbb;
                txtsupplierUser . Text = _model . supplierUser;
                txtbuyer . Text = _model . buyer;
                txtbuyerAbb . Text = _model . buyerAbb;
                txtbuyerUser . Text = _model . buyerUser;
            }
        }
        //鱼粉ID
        private void txtfishId_MouseClick ( object sender ,MouseEventArgs e )
        {
            FormFish form = new FormFish ( );
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                FishEntity . ProductEntity _fish = form . getEntity;
                txtfishId . Text = _fish . code;
                txtvarieties . Text = _fish . name;
                txtquaSpe . Text = _fish . specification;
                txtconutry . Text = _fish . nature;
                txtbrand . Text = _fish . brand;
                txtSGSDB . Text = _fish . sgs_protein . ToString ( );
                txtSGSTVN . Text = _fish . sgs_tvn . ToString ( );
                txtSGSZA . Text = _fish . sgs_amine . ToString ( );
                txtSGSFFA . Text = _fish . sgs_ffa . ToString ( );
                txtSGSZF . Text = _fish . sgs_fat . ToString ( );
                txtSGSSF . Text = _fish . sgs_water . ToString ( );
                txtSGSSHY . Text = _fish . sgs_sandsalt . ToString ( );
                txtSGSS . Text = _fish . sgs_sand . ToString ( );
                txtSGSSJ . Text = _fish . domestic_sour . ToString ( );
                txtSGSHF . Text = _fish . sgs_graypart . ToString ( );
            }
        }
        private void txtheight_LostFocus ( object sender ,EventArgs e )
        {
            errorProvider1 . Clear ( );
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( txtheight . Text ) && decimal . TryParse ( txtheight . Text ,out outResult ) == false )
            {
                errorProvider1 . SetError ( txtheight ,"请重新输入" );
                txtheight . Text = string . Empty;
                return;
            }
            calcuMonry ( );
            calcuMonryMJ ( );
        }
        private void txtprice_LostFocus ( object sender ,EventArgs e )
        {
            errorProvider1 . Clear ( );
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( txtprice . Text ) && decimal . TryParse ( txtprice . Text ,out outResult ) == false )
            {
                errorProvider1 . SetError ( txtprice ,"请重新输入" );
                txtprice . Text = string . Empty;
                return;
            }
            calcuMonry ( );
        }
        private void txtpriceMY_LostFocus ( object sender ,EventArgs e )
        {
            errorProvider1 . Clear ( );
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( txtpriceMY . Text ) && decimal . TryParse ( txtpriceMY . Text ,out outResult ) == false )
            {
                errorProvider1 . SetError ( txtpriceMY ,"请重新输入" );
                txtpriceMY . Text = string . Empty;
                return;
            }
            calcuMonryMJ ( );
        }
        #endregion

    }
}
