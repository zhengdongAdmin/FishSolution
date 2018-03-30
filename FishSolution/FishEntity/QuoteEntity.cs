using System;
using System.Collections.Generic;
using System.Text;

namespace FishEntity
{
     public class QuoteEntity
    {
         public QuoteEntity()
		{}
		#region Model
		private int _id;
        private int _no = 1;
		private int _companyid;
        private string _companycode;
        private string _company;
		private int _customerid;
        private string _customercode;
        private string _customer;
		private int _productid;
		private decimal _quotedollars=0.000M;
        private decimal _quotermb = 0;
        private decimal _rate;
        private decimal _weight = 0;
        private int _quantity = 0;
		private DateTime? _quotedate;
		private DateTime? _quotetime;
		private string _quoteman;
		private string _createman;
        private DateTime _createtime = DateTime.Now;
		private string _modifyman;
        private DateTime _modifytime = DateTime.Now;
		private int _isdelete=0;
       
		/// <summary>
		/// auto_increment
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
        public int no
        {
            get { return _no; }
            set { _no = value; }
        }
		/// <summary>
		/// 
		/// </summary>
		public int companyid
		{
			set{ _companyid=value;}
			get{return _companyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int customerid
		{
			set{ _customerid=value;}
			get{return _customerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int productid
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal quotedollars
		{
			set{ _quotedollars=value;}
			get{return _quotedollars;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? quotedate
		{
			set{ _quotedate=value;}
			get{return _quotedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? quotetime
		{
			set{ _quotetime=value;}
			get{return _quotetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string quoteman
		{
			set{ _quoteman=value;}
			get{return _quoteman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string createman
		{
			set{ _createman=value;}
			get{return _createman;}
		}
		/// <summary>
		/// on update CURRENT_TIMESTAMP
		/// </summary>
		public DateTime createtime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string modifyman
		{
			set{ _modifyman=value;}
			get{return _modifyman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime modifytime
		{
			set{ _modifytime=value;}
			get{return _modifytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int isdelete
		{
			set{ _isdelete=value;}
			get{return _isdelete;}
		}
         /// <summary>
         /// 
         /// </summary>
        public string companycode
        {
            get { return _companycode; }
            set { _companycode = value; }
        }
         /// <summary>
         /// 
         /// </summary>
        public string customercode
        {
            get { return _customercode; }
            set { _customercode = value; }
        }

        public string customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public string company
        {
            get { return _company; }
            set { _company = value; }
        }

        public decimal weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public int quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public decimal quotermb
        {
            get { return _quotermb; }
            set { _quotermb = value; }
        }

        public decimal rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

		#endregion Model

    }
}
