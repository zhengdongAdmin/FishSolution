
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FishClient
{
    public partial class FormSalesRContract :FormMenuBase
    {
        FishEntity.SalesRequisitionEntity setbool = null;
        /// <summary>
        /// 流程状态表刷新
        /// </summary>
        FishBll.Bll.ProcessStateBll _Refreshbll = null;
        string _rolewhere = string.Empty;
        public FormSalesRContract ( )
        {
            InitializeComponent ( );
            menuStrip1.Visible = true;
            dtpSigndate . Enabled = false;
            dataGridView1 . Enabled = false;

            //texCountry . Visible = false;
        }
        public override void Review()
        {
            Review(this.Name, txtNumbering.Text, txtcode.Text);
            if (txtNumbering.Text!="")
            {
                _Refreshbll = new FishBll.Bll.ProcessStateBll();
                _Refreshbll.GetFormSalesRContract(txtNumbering.Text);
            }
            base.Review();
        }
        FishBll.Bll.SalerequisitionBll _bll = new FishBll.Bll.SalerequisitionBll();
        bool result=false;
        bool gnjc=false;
        private void FormSalesRContract_Load(object sender, EventArgs e)
        {
            MenuCode = "M423"; ControlButtomRoles();
            txtNumbering.Text = Megres.oddNum;
            GenerateContect();
            Megres.oddNum = string.Empty;
            if (result == true)
                GenerateBody();
        }
        public override int Query ( )
        {
            FormSalesTables form = new FormSalesTables();
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (form.ShowDialog() != System.Windows.Forms.DialogResult.OK)            
            if (form.fish == null) return 1;
            txtcode.Text = string.Empty;
            txtcode.Text = form.fish.code;
            dataGridView1.Rows.Clear();
            GenerateContect();
            if (result == true)
                GenerateBody();

            return base . Query ( );
        }
        void GenerateContect ( )
        {
            result = _bll . Exist (txtNumbering. Text );
            if ( result == true )
            {
                _rolewhere += " Numbering= '" + txtNumbering.Text+"' ";
                if (FishEntity.Variable.User.roletype.Equals(FishEntity.Constant.Role_SalesMan))
                {
                    _rolewhere += string.Format(" and createman='{0}' ", FishEntity.Variable.User.username);
                }
                FishEntity . SalesRequisitionEntity _list = _bll . GetList (_rolewhere);
                if ( _list == null )
                    return;
                headSetValue ( _list );

            }
            else
                MessageBox . Show ( "编号:" + txtNumbering . Text + "不存在,请核实" );
        }
        void headSetValue ( FishEntity . SalesRequisitionEntity _list )
        {
            txtcode . Text = _list . code;
            txtsupplier . Text = _list . supplier;
            txtsupplier . Tag = _list . supplierId;
            txtdemand . Text = _list . demand;
            txtdemand . Tag = _list . demandId;
            txtSignplace . Text = _list . Signplace;
            if ( _list . Signdate != null )
                dtpSigndate . Value = DateTime . Parse ( _list . Signdate . ToString ( ) );
            if ( _list . rebateBool == true )
            {
                //labrebateBool . Visible = true;
                //texrebate . Visible = true;
                //texrebate . Text = _list . rebate . ToString ( );
            }
            else
            {
                //labrebateBool . Visible = false;
                //texrebate . Visible = false;
            }
            if (_list.Freightbool==true)
            {
                labFreightBool.Visible = true;
                texFreight.Visible = true;
                texFreight.Text = _list.Freight.ToString();
            }
            else
            {
                labFreightBool.Visible = false;
                texFreight.Visible = false;
            }
            if ( _list . PortpriceBool == true )
            {
                labPortpriceBool . Visible = true;
                texPortprice . Visible = true;
                texPortprice . Text = _list . Portprice . ToString ( );
            }
            else
            {
                labPortpriceBool . Visible = false;
                texPortprice . Visible = false;
            }
            if (_list.WithSkinbool == true)
            {
                labWithSkinBool.Visible = true;
                texWithSkin.Visible = true;
                texWithSkin.Text = _list.WithSkin.ToString();
            }
            else {
                labWithSkinBool.Visible = false;
                texWithSkin.Visible = false;
            }
            if (_list.Stockpilebool == true)
            {
                labelStockpilebool.Visible = true;
                texdt.Visible = true;
                labeldty.Visible = true;
                texdt.Text = _list.dt.ToString();
            }
            else {
                labelStockpilebool.Visible = false;
                texdt.Visible = false;
                labeldty.Visible = false;
                texdt.Text = _list.dt.ToString();
            }
            if (_list.Informationbool==true)
            {

            }
            texDeliveryPlace . Text = _list . delivery;
            textransport . Text = _list . transport;
            texDeliveryDeadline . Text = _list . deadline . ToString ( );
            texBanDan . Text = _list . Settlementmethod;
            texOpenbank . Text = _list . Bank;
            texCollectUnit . Text = _list . Receipt;
            texAcountNum . Text = _list . accountnumber . ToString ( );

            gnjc = _list . deIndex;
            setbool = _list;
        }
        void GenerateBody ( )
        {
            FishBll . Bll . happeningBll _happbll = new FishBll . Bll . happeningBll ( );
            List<FishEntity . SalesRequisitionBodyEntity> modelList = _happbll . getList (txtNumbering. Text );
            if ( modelList . Count < 1 )
                return;
            bodySetValue ( modelList );
        }
        DataTable tableOne, tableTwo, tableTre;
        public override int Print()
        {
            if (printOrExport() == false)
                return 0;

            Print(new DataTable[] { tableOne, tableTwo, tableTre }, "\\销售合同.frx");

            return base.Print();
        }
        public override int Export()
        {
            if (printOrExport() == false)
                return 0;

            Export(new DataTable[] { tableOne, tableTwo, tableTre }, "\\销售合同.frx");

            return base.Export();
        }       
        bool printOrExport()
        {
            if (string.IsNullOrEmpty(txtcode.Text))
            {
                MessageBox.Show("合同编号不可为空");
                return false;
            }
            tableOne = _bll.printTableOne(txtcode.Text);
            tableOne.TableName = "TableOne";
            tableTwo = _bll.printTableTwo(txtcode.Text);
            tableTwo.TableName = "TableTwo";
            tableTre = _bll.printTableTre(txtcode.Text);
            tableTre.TableName = "TableTre";

            return true;
        }
        void bodySetValue ( List<FishEntity . SalesRequisitionBodyEntity> modelList )
        {
            int i = 0;

            foreach ( FishEntity . SalesRequisitionBodyEntity list in modelList )
            {
                int idx = dataGridView1 . Rows . Add ( );
                DataGridViewRow row = dataGridView1 . Rows [ idx ];
                row . Cells [ "product_id" ] . Value = list . product_id;
                row . Cells [ "productname" ] . Value = list . productname;
                row . Cells [ "Funit" ] . Value = list . Funit;
                row . Cells [ "Variety" ] . Value = list . Variety;
                row . Cells [ "Quantity" ] . Value = list . Quantity;
                row . Cells [ "unitprice" ] . Value = list . unitprice;
                row . Cells ["Amonut"] . Value = list .Amonut;

                i++;
                if ( i > 1 )
                {
                    UILibrary . PresaleRControlSGS sgs = new UILibrary . PresaleRControlSGS ( );
                    sgs . Location = new System . Drawing . Point ( 0 ,118 * ( i - 1 ) );
                    panel2 . Controls . Add ( sgs );

                    //sgs . Dock = System . Windows . Forms . DockStyle . Top;
                    sgs . Visible = true;
                    sgs . Name = sgs + i . ToString ( );
                    sgs . setSaleValue ( list ,gnjc,setbool );
                }
                else
                {
                    sgs1 . setSaleValue ( list ,gnjc ,setbool);
                }
            }
        }

    }
}
