using MySql . Data . MySqlClient;
using System;
using System . Collections . Generic;
using System . Data;
using System . Text;

namespace FishBll . Dao
{
    public class PurchaseApplicationDao
    {
        /// <summary>
        /// 得到申请单编号
        /// </summary>
        /// <returns></returns>
        public string getCodeNum ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT MAX(codeNum) codeNum FROM t_purchaseApplication" );

            DataSet ds = MySqlHelper . Query ( strSql . ToString ( ) );
            DataTable dt = ds . Tables [ 0 ];
            if ( dt != null && dt . Rows . Count > 0 )
            {
                string codeNum = dt . Rows [ 0 ] [ "codeNum" ] . ToString ( );
                if ( string . IsNullOrEmpty ( codeNum ) )
                    return System . DateTime . Now . Year + "C0001001";
                else
                {
                    if ( codeNum . Substring ( 0 ,4 ) . Equals ( DateTime . Now . Year ) )
                    {
                        if ( Convert . ToInt32 ( codeNum . Substring ( 10 ,1 ) ) == 0 )
                            return codeNum . Substring ( 0 ,8 ) + ( Convert . ToInt32 ( codeNum . Substring ( 9 ,4 ) ) + 1000 );
                        else
                            return codeNum . Substring ( 0 ,8 ) + ( Convert . ToInt32 ( codeNum . Substring ( 9 ,4 ) ) + 100 );
                    }
                    else
                        return System . DateTime . Now . Year + "C0001001";
                }
            }
            else
                return System . DateTime . Now . Year + "C0001001";
        }

        /// <summary>
        /// 是否被引用
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool ExistsCodeNumContract ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT codeNumContract FROM t_purchaseapplication WHERE id={0} " ,idx );
            DataSet ds = MySqlHelper . Query ( strSql . ToString ( ) );
            DataTable dt = ds . Tables [ 0 ];
            if ( dt != null && dt . Rows . Count > 0 )
                return string . IsNullOrEmpty ( dt . Rows [ 0 ] [ "codeNumContract" ] . ToString ( ) ) == true ? false : true;
            else
                return false;
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "delete from t_purchaseapplication " );
            strSql . Append ( " where id=@id" );
            MySqlParameter [ ] parameters = {
                    new MySqlParameter("@id", MySqlDbType.Int32)
            };
            parameters [ 0 ] . Value = idx;

            int rows = MySqlHelper . ExecuteSql ( strSql . ToString ( ) ,parameters );
            if ( rows > 0 )
                return true;
            else
                return false;
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add ( FishEntity . PurchaseApplicationEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "insert into t_purchaseapplication(" );
            strSql . Append ( "codeNum,codeNumContract,supplier,supplierAbb,supplierUser,buyer,buyerAbb,buyerUser,signDate,signAdd,proName,bondPro,varieties,quaSpe,height,price,priceMY,conutry,brand,shipName,billNum,shipDate,arriveDate,deliveryDate,SGSDB,SGSTVN,SGSZA,SGSZF,SGSSF,SGSSHY,SGSS,SGSSJ,SGSHF,deliveryAdd,deliveryLast,fishId,conProtein,conTVN,conZA,conFFA,conZF,conSF,conSHY,conS,conSJ,conHF,conLAS,conDAS,remark)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@codeNum,@codeNumContract,@supplier,@supplierAbb,@supplierUser,@buyer,@buyerAbb,@buyerUser,@signDate,@signAdd,@proName,@bondPro,@varieties,@quaSpe,@height,@price,@priceMY,@conutry,@brand,@shipName,@billNum,@shipDate,@arriveDate,@deliveryDate,@SGSDB,@SGSTVN,@SGSZA,@SGSZF,@SGSSF,@SGSSHY,@SGSS,@SGSSJ,@SGSHF,@deliveryAdd,@deliveryLast,@fishId,@conProtein,@conTVN,@conZA,@conFFA,@conZF,@conSF,@conSHY,@conS,@conSJ,@conHF,@conLAS,@conDAS,@remark);select last_insert_id();" );
            MySqlParameter [ ] parameters = {
                    new MySqlParameter("@codeNum", MySqlDbType.VarChar,30),
                    new MySqlParameter("@codeNumContract", MySqlDbType.VarChar,30),
                    new MySqlParameter("@supplier", MySqlDbType.VarChar,50),
                    new MySqlParameter("@supplierAbb", MySqlDbType.VarChar,50),
                    new MySqlParameter("@supplierUser", MySqlDbType.VarChar,50),
                    new MySqlParameter("@buyer", MySqlDbType.VarChar,50),
                    new MySqlParameter("@buyerAbb", MySqlDbType.VarChar,50),
                    new MySqlParameter("@buyerUser", MySqlDbType.VarChar,50),
                    new MySqlParameter("@signDate", MySqlDbType.DateTime),
                    new MySqlParameter("@signAdd", MySqlDbType.VarChar,100),
                    new MySqlParameter("@proName", MySqlDbType.VarChar,100),
                    new MySqlParameter("@bondPro", MySqlDbType.Decimal,18),
                    new MySqlParameter("@varieties", MySqlDbType.VarChar,50),
                    new MySqlParameter("@quaSpe", MySqlDbType.VarChar,50),
                    new MySqlParameter("@height", MySqlDbType.Decimal,18),
                    new MySqlParameter("@price", MySqlDbType.Decimal,18),
                    new MySqlParameter("@priceMY", MySqlDbType.Decimal,18),
                    new MySqlParameter("@conutry", MySqlDbType.VarChar,30),
                    new MySqlParameter("@brand", MySqlDbType.VarChar,30),
                    new MySqlParameter("@shipName", MySqlDbType.VarChar,50),
                    new MySqlParameter("@billNum", MySqlDbType.VarChar,50),
                    new MySqlParameter("@shipDate", MySqlDbType.DateTime),
                    new MySqlParameter("@arriveDate", MySqlDbType.DateTime),
                    new MySqlParameter("@deliveryDate", MySqlDbType.DateTime),
                    new MySqlParameter("@SGSDB", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSTVN", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSZA", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSZF", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSSF", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSSHY", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSS", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSSJ", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSHF", MySqlDbType.VarChar,50),
                    new MySqlParameter("@deliveryAdd", MySqlDbType.VarChar,50),
                    new MySqlParameter("@deliveryLast", MySqlDbType.DateTime),
                    new MySqlParameter("@fishId", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conProtein", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conTVN", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conZA", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conFFA", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conZF", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conSF", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conSHY", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conS", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conSJ", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conHF", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conLAS", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conDAS", MySqlDbType.VarChar,50),
                    new MySqlParameter("@remark", MySqlDbType.VarChar,255)
            };
            parameters [ 0 ] . Value = model . codeNum;
            parameters [ 1 ] . Value = model . codeNumContract;
            parameters [ 2 ] . Value = model . supplier;
            parameters [ 3 ] . Value = model . supplierAbb;
            parameters [ 4 ] . Value = model . supplierUser;
            parameters [ 5 ] . Value = model . buyer;
            parameters [ 6 ] . Value = model . buyerAbb;
            parameters [ 7 ] . Value = model . buyerUser;
            parameters [ 8 ] . Value = model . signDate;
            parameters [ 9 ] . Value = model . signAdd;
            parameters [ 10 ] . Value = model . proName;
            parameters [ 11 ] . Value = model . bondPro;
            parameters [ 12 ] . Value = model . varieties;
            parameters [ 13 ] . Value = model . quaSpe;
            parameters [ 14 ] . Value = model . height;
            parameters [ 15 ] . Value = model . price;
            parameters [ 16 ] . Value = model . priceMY;
            parameters [ 17 ] . Value = model . conutry;
            parameters [ 18 ] . Value = model . brand;
            parameters [ 19 ] . Value = model . shipName;
            parameters [ 20 ] . Value = model . billNum;
            parameters [ 21 ] . Value = model . shipDate;
            parameters [ 22 ] . Value = model . arriveDate;
            parameters [ 23 ] . Value = model . deliveryDate;
            parameters [ 24 ] . Value = model . SGSDB;
            parameters [ 25 ] . Value = model . SGSTVN;
            parameters [ 26 ] . Value = model . SGSZA;
            parameters [ 27 ] . Value = model . SGSZF;
            parameters [ 28 ] . Value = model . SGSSF;
            parameters [ 29 ] . Value = model . SGSSHY;
            parameters [ 30 ] . Value = model . SGSS;
            parameters [ 31 ] . Value = model . SGSSJ;
            parameters [ 32 ] . Value = model . SGSHF;
            parameters [ 33 ] . Value = model . deliveryAdd;
            parameters [ 34 ] . Value = model . deliveryLast;
            parameters [ 35 ] . Value = model . fishId;
            parameters [ 36 ] . Value = model . conProtein;
            parameters [ 37 ] . Value = model . conTVN;
            parameters [ 38 ] . Value = model . conZA;
            parameters [ 39 ] . Value = model . conFFA;
            parameters [ 40 ] . Value = model . conZF;
            parameters [ 41 ] . Value = model . conSF;
            parameters [ 42 ] . Value = model . conSHY;
            parameters [ 43 ] . Value = model . conS;
            parameters [ 44 ] . Value = model . conSJ;
            parameters [ 45 ] . Value = model . conHF;
            parameters [ 46 ] . Value = model . conLAS;
            parameters [ 47 ] . Value = model . conDAS;
            parameters [ 48 ] . Value = model . remark;

            return MySqlHelper . ExecuteSqlReturnId ( strSql . ToString ( ) ,parameters );
        }

        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Edit ( FishEntity . PurchaseApplicationEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "update t_purchaseapplication set " );
            strSql . Append ( "codeNum=@codeNum," );
            strSql . Append ( "codeNumContract=@codeNumContract," );
            strSql . Append ( "supplier=@supplier," );
            strSql . Append ( "supplierAbb=@supplierAbb," );
            strSql . Append ( "supplierUser=@supplierUser," );
            strSql . Append ( "buyer=@buyer," );
            strSql . Append ( "buyerAbb=@buyerAbb," );
            strSql . Append ( "buyerUser=@buyerUser," );
            strSql . Append ( "signDate=@signDate," );
            strSql . Append ( "signAdd=@signAdd," );
            strSql . Append ( "proName=@proName," );
            strSql . Append ( "bondPro=@bondPro," );
            strSql . Append ( "varieties=@varieties," );
            strSql . Append ( "quaSpe=@quaSpe," );
            strSql . Append ( "height=@height," );
            strSql . Append ( "price=@price," );
            strSql . Append ( "priceMY=@priceMY," );
            strSql . Append ( "conutry=@conutry," );
            strSql . Append ( "brand=@brand," );
            strSql . Append ( "shipName=@shipName," );
            strSql . Append ( "billNum=@billNum," );
            strSql . Append ( "shipDate=@shipDate," );
            strSql . Append ( "arriveDate=@arriveDate," );
            strSql . Append ( "deliveryDate=@deliveryDate," );
            strSql . Append ( "SGSDB=@SGSDB," );
            strSql . Append ( "SGSTVN=@SGSTVN," );
            strSql . Append ( "SGSZA=@SGSZA," );
            strSql . Append ( "SGSZF=@SGSZF," );
            strSql . Append ( "SGSSF=@SGSSF," );
            strSql . Append ( "SGSSHY=@SGSSHY," );
            strSql . Append ( "SGSS=@SGSS," );
            strSql . Append ( "SGSSJ=@SGSSJ," );
            strSql . Append ( "SGSHF=@SGSHF," );
            strSql . Append ( "deliveryAdd=@deliveryAdd," );
            strSql . Append ( "deliveryLast=@deliveryLast," );
            strSql . Append ( "fishId=@fishId," );
            strSql . Append ( "conProtein=@conProtein," );
            strSql . Append ( "conTVN=@conTVN," );
            strSql . Append ( "conZA=@conZA," );
            strSql . Append ( "conFFA=@conFFA," );
            strSql . Append ( "conZF=@conZF," );
            strSql . Append ( "conSF=@conSF," );
            strSql . Append ( "conSHY=@conSHY," );
            strSql . Append ( "conS=@conS," );
            strSql . Append ( "conSJ=@conSJ," );
            strSql . Append ( "conHF=@conHF," );
            strSql . Append ( "conLAS=@conLAS," );
            strSql . Append ( "conDAS=@conDAS," );
            strSql . Append ( "remark=@remark " );
            strSql . Append ( " where id=@id" );
            MySqlParameter [ ] parameters = {
                    new MySqlParameter("@codeNum", MySqlDbType.VarChar,30),
                    new MySqlParameter("@codeNumContract", MySqlDbType.VarChar,30),
                    new MySqlParameter("@supplier", MySqlDbType.VarChar,50),
                    new MySqlParameter("@supplierAbb", MySqlDbType.VarChar,50),
                    new MySqlParameter("@supplierUser", MySqlDbType.VarChar,50),
                    new MySqlParameter("@buyer", MySqlDbType.VarChar,50),
                    new MySqlParameter("@buyerAbb", MySqlDbType.VarChar,50),
                    new MySqlParameter("@buyerUser", MySqlDbType.VarChar,50),
                    new MySqlParameter("@signDate", MySqlDbType.DateTime),
                    new MySqlParameter("@signAdd", MySqlDbType.VarChar,100),
                    new MySqlParameter("@proName", MySqlDbType.VarChar,100),
                    new MySqlParameter("@bondPro", MySqlDbType.Decimal,18),
                    new MySqlParameter("@varieties", MySqlDbType.VarChar,50),
                    new MySqlParameter("@quaSpe", MySqlDbType.VarChar,50),
                    new MySqlParameter("@height", MySqlDbType.Decimal,18),
                    new MySqlParameter("@price", MySqlDbType.Decimal,18),
                    new MySqlParameter("@priceMY", MySqlDbType.Decimal,18),
                    new MySqlParameter("@conutry", MySqlDbType.VarChar,30),
                    new MySqlParameter("@brand", MySqlDbType.VarChar,30),
                    new MySqlParameter("@shipName", MySqlDbType.VarChar,50),
                    new MySqlParameter("@billNum", MySqlDbType.VarChar,50),
                    new MySqlParameter("@shipDate", MySqlDbType.DateTime),
                    new MySqlParameter("@arriveDate", MySqlDbType.DateTime),
                    new MySqlParameter("@deliveryDate", MySqlDbType.DateTime),
                    new MySqlParameter("@SGSDB", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSTVN", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSZA", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSZF", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSSF", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSSHY", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSS", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSSJ", MySqlDbType.VarChar,50),
                    new MySqlParameter("@SGSHF", MySqlDbType.VarChar,50),
                    new MySqlParameter("@deliveryAdd", MySqlDbType.VarChar,50),
                    new MySqlParameter("@deliveryLast", MySqlDbType.DateTime),
                    new MySqlParameter("@fishId", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conProtein", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conTVN", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conZA", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conFFA", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conZF", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conSF", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conSHY", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conS", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conSJ", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conHF", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conLAS", MySqlDbType.VarChar,50),
                    new MySqlParameter("@conDAS", MySqlDbType.VarChar,50),
                    new MySqlParameter("@remark", MySqlDbType.VarChar,255),
                    new MySqlParameter("@id", MySqlDbType.Int32,11)
            };
            parameters [ 0 ] . Value = model . codeNum;
            parameters [ 1 ] . Value = model . codeNumContract;
            parameters [ 2 ] . Value = model . supplier;
            parameters [ 3 ] . Value = model . supplierAbb;
            parameters [ 4 ] . Value = model . supplierUser;
            parameters [ 5 ] . Value = model . buyer;
            parameters [ 6 ] . Value = model . buyerAbb;
            parameters [ 7 ] . Value = model . buyerUser;
            parameters [ 8 ] . Value = model . signDate;
            parameters [ 9 ] . Value = model . signAdd;
            parameters [ 10 ] . Value = model . proName;
            parameters [ 11 ] . Value = model . bondPro;
            parameters [ 12 ] . Value = model . varieties;
            parameters [ 13 ] . Value = model . quaSpe;
            parameters [ 14 ] . Value = model . height;
            parameters [ 15 ] . Value = model . price;
            parameters [ 16 ] . Value = model . priceMY;
            parameters [ 17 ] . Value = model . conutry;
            parameters [ 18 ] . Value = model . brand;
            parameters [ 19 ] . Value = model . shipName;
            parameters [ 20 ] . Value = model . billNum;
            parameters [ 21 ] . Value = model . shipDate;
            parameters [ 22 ] . Value = model . arriveDate;
            parameters [ 23 ] . Value = model . deliveryDate;
            parameters [ 24 ] . Value = model . SGSDB;
            parameters [ 25 ] . Value = model . SGSTVN;
            parameters [ 26 ] . Value = model . SGSZA;
            parameters [ 27 ] . Value = model . SGSZF;
            parameters [ 28 ] . Value = model . SGSSF;
            parameters [ 29 ] . Value = model . SGSSHY;
            parameters [ 30 ] . Value = model . SGSS;
            parameters [ 31 ] . Value = model . SGSSJ;
            parameters [ 32 ] . Value = model . SGSHF;
            parameters [ 33 ] . Value = model . deliveryAdd;
            parameters [ 34 ] . Value = model . deliveryLast;
            parameters [ 35 ] . Value = model . fishId;
            parameters [ 36 ] . Value = model . conProtein;
            parameters [ 37 ] . Value = model . conTVN;
            parameters [ 38 ] . Value = model . conZA;
            parameters [ 39 ] . Value = model . conFFA;
            parameters [ 40 ] . Value = model . conZF;
            parameters [ 41 ] . Value = model . conSF;
            parameters [ 42 ] . Value = model . conSHY;
            parameters [ 43 ] . Value = model . conS;
            parameters [ 44 ] . Value = model . conSJ;
            parameters [ 45 ] . Value = model . conHF;
            parameters [ 46 ] . Value = model . conLAS;
            parameters [ 47 ] . Value = model . conDAS;
            parameters [ 48 ] . Value = model . remark;
            parameters [ 49 ] . Value = model . id;

            return MySqlHelper . ExecuteSql ( strSql . ToString ( ) ,parameters );
        }

        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public FishEntity . PurchaseApplicationEntity getModel ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT id,codeNum,codeNumContract,supplier,supplierAbb,supplierUser,buyer,buyerAbb,buyerUser,signDate,signAdd,proName,bondPro,varieties,quaSpe,height,price,priceMY,conutry,brand,shipName,billNum,shipDate,arriveDate,deliveryDate,SGSDB,SGSTVN,SGSZA,SGSZF,SGSSF,SGSSHY,SGSS,SGSSJ,SGSHF,deliveryAdd,deliveryLast,fishId,conProtein,conTVN,conZA,conFFA,conZF,conSF,conSHY,conS,conSJ,conHF,conLAS,conDAS,remark FROM t_purchaseapplication WHERE {0}" ,strWhere );

            DataSet ds = MySqlHelper . Query ( strSql . ToString ( ) );
            DataTable dt = ds . Tables [ 0 ];
            if ( dt != null && dt . Rows . Count > 0 )
                return getModel ( dt . Rows [ 0 ] );
            else
                return null;
        }

        private FishEntity . PurchaseApplicationEntity getModel ( DataRow row )
        {
            FishEntity . PurchaseApplicationEntity  model = new FishEntity . PurchaseApplicationEntity  ( );
            if ( row != null )
            {
                if ( row [ "id" ] != null && row [ "id" ] . ToString ( ) != "" )
                {
                    model . id = int . Parse ( row [ "id" ] . ToString ( ) );
                }
                if ( row [ "codeNum" ] != null )
                {
                    model . codeNum = row [ "codeNum" ] . ToString ( );
                }
                if ( row [ "codeNumContract" ] != null )
                {
                    model . codeNumContract = row [ "codeNumContract" ] . ToString ( );
                }
                if ( row [ "supplier" ] != null )
                {
                    model . supplier = row [ "supplier" ] . ToString ( );
                }
                if ( row [ "supplierAbb" ] != null )
                {
                    model . supplierAbb = row [ "supplierAbb" ] . ToString ( );
                }
                if ( row [ "supplierUser" ] != null )
                {
                    model . supplierUser = row [ "supplierUser" ] . ToString ( );
                }
                if ( row [ "buyer" ] != null )
                {
                    model . buyer = row [ "buyer" ] . ToString ( );
                }
                if ( row [ "buyerAbb" ] != null )
                {
                    model . buyerAbb = row [ "buyerAbb" ] . ToString ( );
                }
                if ( row [ "buyerUser" ] != null )
                {
                    model . buyerUser = row [ "buyerUser" ] . ToString ( );
                }
                if ( row [ "signDate" ] != null && row [ "signDate" ] . ToString ( ) != "" )
                {
                    model . signDate = DateTime . Parse ( row [ "signDate" ] . ToString ( ) );
                }
                if ( row [ "signAdd" ] != null )
                {
                    model . signAdd = row [ "signAdd" ] . ToString ( );
                }
                if ( row [ "proName" ] != null )
                {
                    model . proName = row [ "proName" ] . ToString ( );
                }
                if ( row [ "bondPro" ] != null && row [ "bondPro" ] . ToString ( ) != "" )
                {
                    model . bondPro = decimal . Parse ( row [ "bondPro" ] . ToString ( ) );
                }
                if ( row [ "varieties" ] != null )
                {
                    model . varieties = row [ "varieties" ] . ToString ( );
                }
                if ( row [ "quaSpe" ] != null )
                {
                    model . quaSpe = row [ "quaSpe" ] . ToString ( );
                }
                if ( row [ "height" ] != null && row [ "height" ] . ToString ( ) != "" )
                {
                    model . height = decimal . Parse ( row [ "height" ] . ToString ( ) );
                }
                if ( row [ "price" ] != null && row [ "price" ] . ToString ( ) != "" )
                {
                    model . price = decimal . Parse ( row [ "price" ] . ToString ( ) );
                }
                if ( row [ "priceMY" ] != null && row [ "priceMY" ] . ToString ( ) != "" )
                {
                    model . priceMY = decimal . Parse ( row [ "priceMY" ] . ToString ( ) );
                }
                if ( row [ "conutry" ] != null )
                {
                    model . conutry = row [ "conutry" ] . ToString ( );
                }
                if ( row [ "brand" ] != null )
                {
                    model . brand = row [ "brand" ] . ToString ( );
                }
                if ( row [ "shipName" ] != null )
                {
                    model . shipName = row [ "shipName" ] . ToString ( );
                }
                if ( row [ "billNum" ] != null )
                {
                    model . billNum = row [ "billNum" ] . ToString ( );
                }
                if ( row [ "shipDate" ] != null && row [ "shipDate" ] . ToString ( ) != "" )
                {
                    model . shipDate = DateTime . Parse ( row [ "shipDate" ] . ToString ( ) );
                }
                if ( row [ "arriveDate" ] != null && row [ "arriveDate" ] . ToString ( ) != "" )
                {
                    model . arriveDate = DateTime . Parse ( row [ "arriveDate" ] . ToString ( ) );
                }
                if ( row [ "deliveryDate" ] != null && row [ "deliveryDate" ] . ToString ( ) != "" )
                {
                    model . deliveryDate = DateTime . Parse ( row [ "deliveryDate" ] . ToString ( ) );
                }
                if ( row [ "SGSDB" ] != null )
                {
                    model . SGSDB = row [ "SGSDB" ] . ToString ( );
                }
                if ( row [ "SGSTVN" ] != null )
                {
                    model . SGSTVN = row [ "SGSTVN" ] . ToString ( );
                }
                if ( row [ "SGSZA" ] != null )
                {
                    model . SGSZA = row [ "SGSZA" ] . ToString ( );
                }
                if ( row [ "SGSZF" ] != null )
                {
                    model . SGSZF = row [ "SGSZF" ] . ToString ( );
                }
                if ( row [ "SGSSF" ] != null )
                {
                    model . SGSSF = row [ "SGSSF" ] . ToString ( );
                }
                if ( row [ "SGSSHY" ] != null )
                {
                    model . SGSSHY = row [ "SGSSHY" ] . ToString ( );
                }
                if ( row [ "SGSS" ] != null )
                {
                    model . SGSS = row [ "SGSS" ] . ToString ( );
                }
                if ( row [ "SGSSJ" ] != null )
                {
                    model . SGSSJ = row [ "SGSSJ" ] . ToString ( );
                }
                if ( row [ "SGSHF" ] != null )
                {
                    model . SGSHF = row [ "SGSHF" ] . ToString ( );
                }
                if ( row [ "deliveryAdd" ] != null )
                {
                    model . deliveryAdd = row [ "deliveryAdd" ] . ToString ( );
                }
                if ( row [ "deliveryLast" ] != null && row [ "deliveryLast" ] . ToString ( ) != "" )
                {
                    model . deliveryLast = DateTime . Parse ( row [ "deliveryLast" ] . ToString ( ) );
                }
                if ( row [ "fishId" ] != null )
                {
                    model . fishId = row [ "fishId" ] . ToString ( );
                }
                if ( row [ "conProtein" ] != null )
                {
                    model . conProtein = row [ "conProtein" ] . ToString ( );
                }
                if ( row [ "conTVN" ] != null )
                {
                    model . conTVN = row [ "conTVN" ] . ToString ( );
                }
                if ( row [ "conZA" ] != null )
                {
                    model . conZA = row [ "conZA" ] . ToString ( );
                }
                if ( row [ "conFFA" ] != null )
                {
                    model . conFFA = row [ "conFFA" ] . ToString ( );
                }
                if ( row [ "conZF" ] != null )
                {
                    model . conZF = row [ "conZF" ] . ToString ( );
                }
                if ( row [ "conSF" ] != null )
                {
                    model . conSF = row [ "conSF" ] . ToString ( );
                }
                if ( row [ "conSHY" ] != null )
                {
                    model . conSHY = row [ "conSHY" ] . ToString ( );
                }
                if ( row [ "conS" ] != null )
                {
                    model . conS = row [ "conS" ] . ToString ( );
                }
                if ( row [ "conSJ" ] != null )
                {
                    model . conSJ = row [ "conSJ" ] . ToString ( );
                }
                if ( row [ "conHF" ] != null )
                {
                    model . conHF = row [ "conHF" ] . ToString ( );
                }
                if ( row [ "conLAS" ] != null )
                {
                    model . conLAS = row [ "conLAS" ] . ToString ( );
                }
                if ( row [ "conDAS" ] != null )
                {
                    model . conDAS = row [ "conDAS" ] . ToString ( );
                }
                if ( row [ "remark" ] != null )
                {
                    model . remark = row [ "remark" ] . ToString ( );
                }
            }
            return model;
        }

        /// <summary>
        /// 获取编号
        /// </summary>
        /// <returns></returns>
        public DataTable getCodeNumData ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT codeNum FROM t_purchaseapplication ORDER BY codeNum" );

            return MySqlHelper . Query ( strSql . ToString ( ) ) . Tables [ 0 ];
        }

    }
}
