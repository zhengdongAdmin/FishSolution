using System;
using System . Collections . Generic;
using System . Text;

namespace FishEntity
{
    public class PurchaseApplicationEntity
    {
        public PurchaseApplicationEntity ( )
        {

        }
        #region Model
        private int _id;
        private string _codenum;
        private string _codenumcontract;
        private string _supplier;
        private string _supplierabb;
        private string _supplieruser;
        private string _buyer;
        private string _buyerabb;
        private string _buyeruser;
        private DateTime? _signdate;
        private string _signadd;
        private string _proname;
        private decimal? _bondpro;
        private string _varieties;
        private string _quaspe;
        private decimal? _height;
        private decimal? _price;
        private decimal? _rebate;
        private decimal? _pricemy;
        private string _conutry;
        private string _brand;
        private string _shipname;
        private string _billnum;
        private DateTime? _shipdate;
        private DateTime? _arrivedate;
        private DateTime? _deliverydate;
        private string _sgsdb;
        private string _sgstvn;
        private string _sgsza;
        private string _sgszf;
        private string _sgsffa;
        private string _sgssf;
        private string _sgsshy;
        private string _sgss;
        private string _sgssj;
        private string _sgshf;
        private string _deliveryadd;
        private DateTime? _deliverylast;
        private string _fishid;
        private string _conprotein;
        private string _contvn;
        private string _conza;
        private string _conffa;
        private string _conzf;
        private string _consf;
        private string _conshy;
        private string _cons;
        private string _consj;
        private string _conhf;
        private string _conlas;
        private string _condas;
        private string _remark;
        private string _createuser;
        private DateTime? _createdate;
        private string _modifyuser;
        private DateTime? _modifydate;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int id
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }
        /// <summary>
        /// 采购编号
        /// </summary>
        public string codeNum
        {
            set
            {
                _codenum = value;
            }
            get
            {
                return _codenum;
            }
        }
        /// <summary>
        /// 采购合同编号
        /// </summary>
        public string codeNumContract
        {
            set
            {
                _codenumcontract = value;
            }
            get
            {
                return _codenumcontract;
            }
        }
        /// <summary>
        /// 供方
        /// </summary>
        public string supplier
        {
            set
            {
                _supplier = value;
            }
            get
            {
                return _supplier;
            }
        }
        /// <summary>
        /// 供方简称
        /// </summary>
        public string supplierAbb
        {
            set
            {
                _supplierabb = value;
            }
            get
            {
                return _supplierabb;
            }
        }
        /// <summary>
        /// 供方联系人
        /// </summary>
        public string supplierUser
        {
            set
            {
                _supplieruser = value;
            }
            get
            {
                return _supplieruser;
            }
        }
        /// <summary>
        /// 需方
        /// </summary>
        public string buyer
        {
            set
            {
                _buyer = value;
            }
            get
            {
                return _buyer;
            }
        }
        /// <summary>
        /// 需方简称
        /// </summary>
        public string buyerAbb
        {
            set
            {
                _buyerabb = value;
            }
            get
            {
                return _buyerabb;
            }
        }
        /// <summary>
        /// 需方联系人
        /// </summary>
        public string buyerUser
        {
            set
            {
                _buyeruser = value;
            }
            get
            {
                return _buyeruser;
            }
        }
        /// <summary>
        /// 签约日期
        /// </summary>
        public DateTime? signDate
        {
            set
            {
                _signdate = value;
            }
            get
            {
                return _signdate;
            }
        }
        /// <summary>
        /// 签约地点
        /// </summary>
        public string signAdd
        {
            set
            {
                _signadd = value;
            }
            get
            {
                return _signadd;
            }
        }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string proName
        {
            set
            {
                _proname = value;
            }
            get
            {
                return _proname;
            }
        }
        /// <summary>
        /// 保证金比例
        /// </summary>
        public decimal? bondPro
        {
            set
            {
                _bondpro = value;
            }
            get
            {
                return _bondpro;
            }
        }
        /// <summary>
        /// 品种
        /// </summary>
        public string varieties
        {
            set
            {
                _varieties = value;
            }
            get
            {
                return _varieties;
            }
        }
        /// <summary>
        /// 品质规格
        /// </summary>
        public string quaSpe
        {
            set
            {
                _quaspe = value;
            }
            get
            {
                return _quaspe;
            }
        }
        /// <summary>
        /// 重量
        /// </summary>
        public decimal? height
        {
            set
            {
                _height = value;
            }
            get
            {
                return _height;
            }
        }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal? price
        {
            set
            {
                _price = value;
            }
            get
            {
                return _price;
            }
        }
        /// <summary>
        /// 回扣
        /// </summary>
        public decimal? rebate
        {
            set
            {
                _rebate = value;
            }
            get
            {
                return _rebate;
            }
        }
        /// <summary>
        /// 美元单价
        /// </summary>
        public decimal? priceMY
        {
            set
            {
                _pricemy = value;
            }
            get
            {
                return _pricemy;
            }
        }
        /// <summary>
        /// 国别
        /// </summary>
        public string conutry
        {
            set
            {
                _conutry = value;
            }
            get
            {
                return _conutry;
            }
        }
        /// <summary>
        /// 品牌
        /// </summary>
        public string brand
        {
            set
            {
                _brand = value;
            }
            get
            {
                return _brand;
            }
        }
        /// <summary>
        /// 船名
        /// </summary>
        public string shipName
        {
            set
            {
                _shipname = value;
            }
            get
            {
                return _shipname;
            }
        }
        /// <summary>
        /// 提单号
        /// </summary>
        public string billNum
        {
            set
            {
                _billnum = value;
            }
            get
            {
                return _billnum;
            }
        }
        /// <summary>
        /// 裝船时间
        /// </summary>
        public DateTime? shipDate
        {
            set
            {
                _shipdate = value;
            }
            get
            {
                return _shipdate;
            }
        }
        /// <summary>
        /// 预计到港时间
        /// </summary>
        public DateTime? arriveDate
        {
            set
            {
                _arrivedate = value;
            }
            get
            {
                return _arrivedate;
            }
        }
        /// <summary>
        /// 交货时间
        /// </summary>
        public DateTime? deliveryDate
        {
            set
            {
                _deliverydate = value;
            }
            get
            {
                return _deliverydate;
            }
        }
        /// <summary>
        /// SGS蛋白
        /// </summary>
        public string SGSDB
        {
            set
            {
                _sgsdb = value;
            }
            get
            {
                return _sgsdb;
            }
        }
        /// <summary>
        /// SGSTVN
        /// </summary>
        public string SGSTVN
        {
            set
            {
                _sgstvn = value;
            }
            get
            {
                return _sgstvn;
            }
        }
        /// <summary>
        /// SGS组胺
        /// </summary>
        public string SGSZA
        {
            set
            {
                _sgsza = value;
            }
            get
            {
                return _sgsza;
            }
        }
        /// <summary>
        /// SGS脂肪
        /// </summary>
        public string SGSZF
        {
            set
            {
                _sgszf = value;
            }
            get
            {
                return _sgszf;
            }
        }
        /// <summary>
        /// SGSFFA
        /// </summary>
        public string SGSFFA
        {
            set
            {
                _sgsffa = value;
            }
            get
            {
                return _sgsffa;
            }
        }
        /// <summary>
        /// SGS水分
        /// </summary>
        public string SGSSF
        {
            set
            {
                _sgssf = value;
            }
            get
            {
                return _sgssf;
            }
        }
        /// <summary>
        /// SGS沙和盐
        /// </summary>
        public string SGSSHY
        {
            set
            {
                _sgsshy = value;
            }
            get
            {
                return _sgsshy;
            }
        }
        /// <summary>
        /// SGS沙
        /// </summary>
        public string SGSS
        {
            set
            {
                _sgss = value;
            }
            get
            {
                return _sgss;
            }
        }
        /// <summary>
        /// SGS酸价
        /// </summary>
        public string SGSSJ
        {
            set
            {
                _sgssj = value;
            }
            get
            {
                return _sgssj;
            }
        }
        /// <summary>
        /// SGS灰分
        /// </summary>
        public string SGSHF
        {
            set
            {
                _sgshf = value;
            }
            get
            {
                return _sgshf;
            }
        }
        /// <summary>
        /// 交货地点
        /// </summary>
        public string deliveryAdd
        {
            set
            {
                _deliveryadd = value;
            }
            get
            {
                return _deliveryadd;
            }
        }
        /// <summary>
        /// 最后交货期限
        /// </summary>
        public DateTime? deliveryLast
        {
            set
            {
                _deliverylast = value;
            }
            get
            {
                return _deliverylast;
            }
        }
        /// <summary>
        /// 鱼粉ID
        /// </summary>
        public string fishId
        {
            set
            {
                _fishid = value;
            }
            get
            {
                return _fishid;
            }
        }
        /// <summary>
        /// 合同蛋白
        /// </summary>
        public string conProtein
        {
            set
            {
                _conprotein = value;
            }
            get
            {
                return _conprotein;
            }
        }
        /// <summary>
        /// 合同TVN
        /// </summary>
        public string conTVN
        {
            set
            {
                _contvn = value;
            }
            get
            {
                return _contvn;
            }
        }
        /// <summary>
        /// 合同组胺
        /// </summary>
        public string conZA
        {
            set
            {
                _conza = value;
            }
            get
            {
                return _conza;
            }
        }
        /// <summary>
        /// 合同FFA
        /// </summary>
        public string conFFA
        {
            set
            {
                _conffa = value;
            }
            get
            {
                return _conffa;
            }
        }
        /// <summary>
        /// 合同脂肪
        /// </summary>
        public string conZF
        {
            set
            {
                _conzf = value;
            }
            get
            {
                return _conzf;
            }
        }
        /// <summary>
        /// 合同水分
        /// </summary>
        public string conSF
        {
            set
            {
                _consf = value;
            }
            get
            {
                return _consf;
            }
        }
        /// <summary>
        /// 合同沙和盐
        /// </summary>
        public string conSHY
        {
            set
            {
                _conshy = value;
            }
            get
            {
                return _conshy;
            }
        }
        /// <summary>
        /// 合同沙
        /// </summary>
        public string conS
        {
            set
            {
                _cons = value;
            }
            get
            {
                return _cons;
            }
        }
        /// <summary>
        /// 合同酸价
        /// </summary>
        public string conSJ
        {
            set
            {
                _consj = value;
            }
            get
            {
                return _consj;
            }
        }
        /// <summary>
        /// 合同灰分
        /// </summary>
        public string conHF
        {
            set
            {
                _conhf = value;
            }
            get
            {
                return _conhf;
            }
        }
        /// <summary>
        /// 合同赖氨酸
        /// </summary>
        public string conLAS
        {
            set
            {
                _conlas = value;
            }
            get
            {
                return _conlas;
            }
        }
        /// <summary>
        /// 合同蛋氨酸
        /// </summary>
        public string conDAS
        {
            set
            {
                _condas = value;
            }
            get
            {
                return _condas;
            }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string remark
        {
            set
            {
                _remark = value;
            }
            get
            {
                return _remark;
            }
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public string createUser
        {
            set
            {
                _createuser = value;
            }
            get
            {
                return _createuser;
            }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? createDate
        {
            set
            {
                _createdate = value;
            }
            get
            {
                return _createdate;
            }
        }
        /// <summary>
        /// 修改人
        /// </summary>
        public string modifyUser
        {
            set
            {
                _modifyuser = value;
            }
            get
            {
                return _modifyuser;
            }
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? modifyDate
        {
            set
            {
                _modifydate = value;
            }
            get
            {
                return _modifydate;
            }
        }
        #endregion Model
    }
}
