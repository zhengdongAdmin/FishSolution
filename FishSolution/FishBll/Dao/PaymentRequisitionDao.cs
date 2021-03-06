﻿using MySql . Data . MySqlClient;
using System;
using System . Collections . Generic;
using System . Data;
using System . Text;

namespace FishBll . Dao
{
    public class PaymentRequisitionDao
    {
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public FishEntity .PaymentRequisitionEntity getList ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ("SELECT createman,modifyman,Numbering,code,applyDepartId,applyDepart,applyDate,applyCode,contacts,ContactsId,backDeposit,price,weight,applyMoney,paymentType,paymentMethod,paymentMethodOther,invoiceType,paymentDate,remark,unit,PurchasingUnit,PurchasingUnitId,acountNum,purchasecode FROM t_paymentrequisition ");
            strSql . Append ( "where 1=1" + strWhere );

            DataSet ds = MySqlHelper . Query ( strSql . ToString ( ) );

            if ( ds . Tables [ 0 ] != null && ds . Tables [ 0 ] . Rows . Count > 0 )
                return getModel ( ds . Tables [ 0 ] . Rows [ 0 ] );
            else
                return null;
        }
        public FishEntity.SalesRequisitionEntity getXSSQD(string getname)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.Numbering,code,demand,demandId,DemandContact,DemandContactId,Purchasecontractnumber,Purchasingunits,PurchasingunitsId,a.accountnumber,Bank,UnitPrice from t_salesorder a left join t_purchaserequisition b on a.Numbering=b.Numbering  ");
            strSql.Append("where a.Numbering= '" + getname+"'");
            DataSet ds = MySqlHelper.Query(strSql.ToString());
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                FishEntity.SalesRequisitionEntity model = new FishEntity.SalesRequisitionEntity();
                DataRow row = ds.Tables[0].Rows[0];
                if (row["Numbering"]!=null)
                {
                    model.Numbering = row["Numbering"].ToString();
                }
                if (row["code"] != null)
                {
                    model.code = row["code"].ToString();
                }
                if (row["demand"] != null)
                {
                    model.demand = row["demand"].ToString();
                }
                if (row["demandId"] != null)
                {
                    model.demandId = row["demandId"].ToString();
                }
                if (row["DemandContact"] != null)
                {
                    model.DemandContact = row["DemandContact"].ToString();
                }
                if (row["DemandContactId"] != null)
                {
                    model.DemandContactId = row["DemandContactId"].ToString();
                }
                if (row["Purchasecontractnumber"] != null)
                {
                    model.Purchasecontractnumber = row["Purchasecontractnumber"].ToString();
                }
                if (row["Purchasingunits"] != null)
                {
                    model.Purchasingunits = row["Purchasingunits"].ToString();
                }
                if (row["PurchasingunitsId"] != null)
                {
                    model.PurchasingunitsId = row["PurchasingunitsId"].ToString();
                }
                if (row["accountnumber"] != null)
                {
                    model.accountnumber = row["accountnumber"].ToString();
                }
                if (row["Bank"] != null)//
                {
                    model.Bank = row["Bank"].ToString();
                }
                if (row["UnitPrice"]!=null)
                {
                    model.UnitPrice = row["UnitPrice"].ToString();
                }
                return model;
            }
            else {
                return null;
            }
        }
        public DataTable getTable(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_paymentrequisition ");
            strSql.Append("where " + strWhere);

            DataSet ds = MySqlHelper.Query(strSql.ToString());

            return ds.Tables[0];
        }
        public FishEntity .PaymentRequisitionEntity getModel ( DataRow row )
        {
            FishEntity .PaymentRequisitionEntity model = new FishEntity .PaymentRequisitionEntity( );

            if ( row != null )
            {
                if (row["Numbering"]!=null)
                {
                    model.Numbering = row["Numbering"].ToString();
                }
                if (row["modifyman"]!=null)
                {
                    model.modifyMan = row["modifyman"].ToString();
                }
                if (row["createman"] != null)
                {
                    model.createMan = row["createman"].ToString();
                }
                if ( row [ "code" ] != null )
                    model . code = row [ "code" ] . ToString ( );
                if ( row [ "applyDepartId" ] != null )
                    model . applyDepartId = row [ "applyDepartId" ] . ToString ( );
                if ( row [ "applyDepart" ] != null )
                    model . applyDepart = row [ "applyDepart" ] . ToString ( );
                if ( row [ "applyDate" ] != null && row[ "applyDate" ] .ToString()!="")
                    model . applyDate = DateTime . Parse ( row [ "applyDate" ] . ToString ( ) );
                if ( row [ "applyCode" ] != null )
                    model . applyCode = row [ "applyCode" ] . ToString ( );
                if (row["purchasecode"]!=null)
                {
                    model.Purchasecode = row["purchasecode"].ToString();                }
                if ( row [ "unit" ] != null )
                    model . unit = row [ "unit" ] . ToString ( );
                if (row["PurchasingUnit"]!=null)
                {
                    model.PurchasingUnit = row["PurchasingUnit"].ToString();
                }
                if (row["PurchasingUnitId"]!=null)
                {
                    model.PurchasingUnitId = row["PurchasingUnitId"].ToString();
                }
                if ( row [ "contacts" ] != null )
                    model . contacts = row [ "contacts" ] . ToString ( );
                if (row["ContactsId"]!=null)
                {
                    model.ContactsId = row["ContactsId"].ToString();
                }
                if ( row [ "backDeposit" ] != null )
                    model . backDeposit = row [ "backDeposit" ] . ToString ( );
                if ( row [ "price" ] != null && row [ "price" ] . ToString ( ) != "" )
                    model . price = decimal . Parse ( row [ "price" ] . ToString ( ) );
                if ( row [ "weight" ] != null && row [ "weight" ] . ToString ( ) != "" )
                    model . weight = decimal . Parse ( row [ "weight" ] . ToString ( ) );
                if ( row [ "applyMoney" ] != null && row [ "applyMoney" ] . ToString ( ) != "" )
                    model . applyMoney = decimal . Parse ( row [ "applyMoney" ] . ToString ( ) );
                if ( row [ "paymentType" ] != null )
                    model . paymentType = row [ "paymentType" ] . ToString ( );
                if ( row [ "paymentMethod" ] != null )
                    model . paymentMethod = row [ "paymentMethod" ] . ToString ( );
                if ( row [ "paymentMethodOther" ] != null )
                    model . paymentMethodOther = row [ "paymentMethodOther" ] . ToString ( );
                if ( row [ "invoiceType" ] != null )
                    model . invoiceType = row [ "invoiceType" ] . ToString ( );
                if ( row [ "paymentDate" ] != null && row [ "paymentDate" ] . ToString ( ) != "" )
                    model . paymentDate = DateTime . Parse ( row [ "paymentDate" ] . ToString ( ) );
                if ( row [ "remark" ] != null )
                    model . remark = row [ "remark" ] . ToString ( );
                if ( row [ "acountNum" ] != null )
                    model . AcountNum = row [ "acountNum" ] . ToString ( );
            }

            return model;
        }

        public DateTime getTime ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "select NOW() t" );

            DataSet ds = MySqlHelper . Query ( strSql . ToString ( ) );
            if ( ds . Tables [ 0 ] != null && ds . Tables [ 0 ] . Rows . Count > 0 )
            {
                if ( string . IsNullOrEmpty ( ds . Tables [ 0 ] . Rows [ 0 ] [ "t" ] . ToString ( ) ) )
                    return DateTime . Now;
                else
                    return Convert . ToDateTime ( ds . Tables [ 0 ] . Rows [ 0 ] [ "t" ] . ToString ( ) );
            }
            else
                return DateTime . Now;
        }

        /// <summary>
        /// 获取合同单号
        /// </summary>
        /// <returns></returns>
        public string getCode ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT max(code) code FROM t_paymentrequisition" );

            DataSet ds = MySqlHelper . Query ( strSql . ToString ( ) );

            if ( ds . Tables [ 0 ] != null && ds . Tables [ 0 ] . Rows . Count > 0 )
            {
                if ( string . IsNullOrEmpty ( ds . Tables [ 0 ] . Rows [ 0 ] [ "code" ] . ToString ( ) ) )
                    return getTime ( ) . ToString ( "yyyyMMdd" ) + "001";
                else
                {
                    if ( ds . Tables [ 0 ] . Rows [ 0 ] [ "code" ] . ToString ( ) . Substring ( 0 ,8 ) == getTime ( ) . ToString ( "yyyyMMdd" ) )
                        return ( Convert . ToInt64 ( ds . Tables [ 0 ] . Rows [ 0 ] [ "code" ] . ToString ( ) ) + 1 ) . ToString ( );
                    else
                        return getTime ( ) . ToString ( "yyyyMMdd" ) + "001";
                }
            }
            else
                return getTime ( ) . ToString ( "yyyyMMdd" ) + "001";

        }

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool Delete ( string code )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "DELETE FROM t_paymentrequisition " );
            strSql . Append ( "WHERE code=@code" );
            MySqlParameter [ ] parameter = {
                new MySqlParameter("@code",MySqlDbType.VarChar,45)
            };
            parameter [ 0 ] . Value = code;

            int row = MySqlHelper . ExecuteSql ( strSql . ToString ( ) ,parameter );
            if ( row > 0 )
                return true;
            else
                return false;
        }

        /// <summary>
        /// 增加一条记录
        /// </summary>
        /// <param name="_list"></param>
        /// <returns></returns>
        public bool Add ( FishEntity . PaymentRequisitionEntity _list )
        {
            _list . createTime = _list . modifyTime = getTime ( );
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO t_paymentrequisition (" );
            strSql . Append ("Numbering,code,applyDepartId,applyDepart,applyDate,applyCode,contacts,ContactsId,backDeposit,price,weight,applyMoney,paymentType,paymentMethod,paymentMethodOther,invoiceType,paymentDate,remark,unit,acountNum,createTime,createMan,modifyTime,modifyMan,purchasecode,PurchasingUnit,PurchasingUnitId) ");
            strSql . Append ( "VALUES (" );
            strSql . Append ("@Numbering,@code,@applyDepartId,@applyDepart,@applyDate,@applyCode,@contacts,@ContactsId,@backDeposit,@price,@weight,@applyMoney,@paymentType,@paymentMethod,@paymentMethodOther,@invoiceType,@paymentDate,@remark,@unit,@acountNum,@createTime,@createMan,@modifyTime,@modifyMan,@purchasecode,@PurchasingUnit,@PurchasingUnitId)");
            MySqlParameter [ ] parameter = {
                new MySqlParameter("@code",MySqlDbType.VarChar,45),
                new MySqlParameter("@applyDepartId",MySqlDbType.VarChar,45),
                new MySqlParameter("@applyDepart",MySqlDbType.VarChar,45),
                new MySqlParameter("@applyDate",MySqlDbType.Date),
                new MySqlParameter("@applyCode",MySqlDbType.VarChar,200),
                new MySqlParameter("@contacts",MySqlDbType.VarChar,45),
                new MySqlParameter("@backDeposit",MySqlDbType.VarChar,45),
                new MySqlParameter("@price",MySqlDbType.Decimal,45),
                new MySqlParameter("@weight",MySqlDbType.Decimal,45),
                new MySqlParameter("@applyMoney",MySqlDbType.Decimal,45),
                new MySqlParameter("@paymentType",MySqlDbType.VarChar,45),
                new MySqlParameter("@paymentMethod",MySqlDbType.VarChar,45),
                new MySqlParameter("@paymentMethodOther",MySqlDbType.VarChar,45),
                new MySqlParameter("@invoiceType",MySqlDbType.VarChar,45),
                new MySqlParameter("@paymentDate",MySqlDbType.Date),
                new MySqlParameter("@remark",MySqlDbType.VarChar,45),
                new MySqlParameter("@unit",MySqlDbType.VarChar,45),
                new MySqlParameter("@acountNum",MySqlDbType.VarChar,45),
                new MySqlParameter("@createTime",MySqlDbType.DateTime),
                new MySqlParameter("@createMan",MySqlDbType.VarChar,45),
                new MySqlParameter("@modifyTime",MySqlDbType.DateTime),
                new MySqlParameter("@modifyMan",MySqlDbType.VarChar,45),
                new MySqlParameter("@purchasecode",MySqlDbType.VarChar,45),
                new MySqlParameter("@PurchasingUnit",MySqlDbType.VarChar,45),
                new MySqlParameter("@PurchasingUnitId",MySqlDbType.VarChar,45),
                new MySqlParameter("@ContactsId",MySqlDbType.VarChar,45),
                new MySqlParameter("@Numbering",MySqlDbType.VarChar,45)
            };
            parameter [ 0 ] . Value = _list . code;
            parameter [ 1 ] . Value = _list . applyDepartId;
            parameter [ 2 ] . Value = _list . applyDepart;
            parameter [ 3 ] . Value = _list . applyDate;
            parameter [ 4 ] . Value = _list . applyCode;
            parameter [ 5 ] . Value = _list . contacts;
            parameter [ 6 ] . Value = _list . backDeposit;
            parameter [ 7 ] . Value = _list . price;
            parameter [ 8 ] . Value = _list . weight;
            parameter [ 9 ] . Value = _list . applyMoney;
            parameter [ 10 ] . Value = _list . paymentType;
            parameter [ 11 ] . Value = _list . paymentMethod;
            parameter [ 12 ] . Value = _list . paymentMethodOther;
            parameter [ 13 ] . Value = _list . invoiceType;
            parameter [ 14 ] . Value = _list . paymentDate;
            parameter [ 15 ] . Value = _list . remark;
            parameter [ 16 ] . Value = _list . unit;
            parameter [ 17 ] . Value = _list . AcountNum;
            parameter [ 18 ] . Value = _list . createTime;
            parameter [ 19 ] . Value = _list . createMan;
            parameter [ 20 ] . Value = _list . modifyTime;
            parameter [ 21 ] . Value = _list . modifyMan;
            parameter[22].Value = _list.Purchasecode;
            parameter[23].Value = _list.PurchasingUnit;
            parameter[24].Value = _list.PurchasingUnitId;
            parameter[25].Value = _list.ContactsId;
            parameter[26].Value = _list.Numbering;

            int row = MySqlHelper . ExecuteSql ( strSql . ToString ( ) ,parameter );
            if ( row > 0 )
                return true;
            else
                return false;
        }

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool Exists ( string code )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT COUNT(1) FROM t_paymentrequisition " );
            strSql . Append ( "where code=@code" );
            MySqlParameter [ ] parameter = {
                new MySqlParameter("@code",MySqlDbType.VarChar,45)
            };
            parameter [ 0 ] . Value = code;

            return MySqlHelper . Exists ( strSql . ToString ( ) ,parameter );
        }
        /// <summary>
        /// 是否所属
        /// </summary>
        /// <param name="code"></param>
        /// <param name="createman"></param>
        /// <returns></returns>
        public bool ExistsUpdate(string code,string createman)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM t_paymentrequisition ");
            strSql.Append("where code=@code and createman=@createman");
            MySqlParameter[] parameter = {
                new MySqlParameter("@code",MySqlDbType.VarChar,45),
                new MySqlParameter("@createman",MySqlDbType.VarChar,45)
            };
            parameter[0].Value = code;
            parameter[1].Value = createman;
            return MySqlHelper.Exists(strSql.ToString(), parameter);
        }
        /// <summary>
        /// 编辑一条记录
        /// </summary>
        /// <param name="_list"></param>
        /// <returns></returns>
        public bool Edit ( FishEntity . PaymentRequisitionEntity _list )
        {
            _list . createTime = _list . modifyTime = getTime ( );
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE t_paymentrequisition SET " );
            strSql . Append ( "applyDepartId=@applyDepartId," );
            strSql . Append ( "applyDepart=@applyDepart," );
            strSql . Append ( "applyDate=@applyDate," );
            strSql . Append ( "applyCode=@applyCode," );
            strSql . Append ( "unit=@unit," );
            strSql . Append ( "acountNum=@acountNum," );
            strSql . Append ( "contacts=@contacts," );
            strSql . Append ( "backDeposit=@backDeposit," );
            strSql . Append ( "price=@price," );
            strSql . Append ( "weight=@weight," );
            strSql . Append ( "applyMoney=@applyMoney," );
            strSql . Append ( "paymentType=@paymentType," );
            strSql . Append ( "paymentMethod=@paymentMethod," );
            strSql . Append ( "paymentMethodOther=@paymentMethodOther," );
            strSql . Append ( "invoiceType=@invoiceType," );
            strSql . Append ( "paymentDate=@paymentDate," );
            strSql . Append ( "remark=@remark," );
            strSql . Append ( "modifyTime=@modifyTime," );
            strSql . Append ( "modifyMan=@modifyMan," );
            strSql.Append("purchasecode=@purchasecode, ");
            strSql.Append("PurchasingUnit=@PurchasingUnit,");
            strSql.Append("PurchasingUnitId=@PurchasingUnitId,");
            strSql.Append("ContactsId=@ContactsId ");
            strSql . Append ( "WHERE code=@code" );
            MySqlParameter [ ] parameter = {
                new MySqlParameter("@code",MySqlDbType.VarChar,45),
                new MySqlParameter("@applyDepartId",MySqlDbType.VarChar,45),
                new MySqlParameter("@applyDepart",MySqlDbType.VarChar,45),
                new MySqlParameter("@applyDate",MySqlDbType.Date),
                new MySqlParameter("@applyCode",MySqlDbType.VarChar,200),
                new MySqlParameter("@unit",MySqlDbType.VarChar,45),
                new MySqlParameter("@acountNum",MySqlDbType.VarChar,45),
                new MySqlParameter("@contacts",MySqlDbType.VarChar,45),
                new MySqlParameter("@backDeposit",MySqlDbType.VarChar,45),
                new MySqlParameter("@price",MySqlDbType.Decimal,45),
                new MySqlParameter("@weight",MySqlDbType.Decimal,45),
                new MySqlParameter("@applyMoney",MySqlDbType.Decimal,45),
                new MySqlParameter("@paymentType",MySqlDbType.VarChar,45),
                new MySqlParameter("@paymentMethod",MySqlDbType.VarChar,45),
                new MySqlParameter("@paymentMethodOther",MySqlDbType.VarChar,45),
                new MySqlParameter("@invoiceType",MySqlDbType.VarChar,45),
                new MySqlParameter("@paymentDate",MySqlDbType.Date),
                new MySqlParameter("@remark",MySqlDbType.VarChar,45),
                new MySqlParameter("@modifyTime",MySqlDbType.DateTime),
                new MySqlParameter("@modifyMan",MySqlDbType.VarChar,45),
                new MySqlParameter("@purchasecode",MySqlDbType.VarChar,45),
                new MySqlParameter("@PurchasingUnit",MySqlDbType.VarChar,45),
                new MySqlParameter("@PurchasingUnitId",MySqlDbType.VarChar,45),
                new MySqlParameter("@ContactsId",MySqlDbType.VarChar,45)

            };
            parameter [ 0 ] . Value = _list . code;
            parameter [ 1 ] . Value = _list . applyDepartId;
            parameter [ 2 ] . Value = _list . applyDepart;
            parameter [ 3 ] . Value = _list . applyDate;
            parameter [ 4 ] . Value = _list . applyCode;
            parameter [ 5 ] . Value = _list . unit;
            parameter [ 6 ] . Value = _list . AcountNum;
            parameter [ 7 ] . Value = _list . contacts;
            parameter [ 8 ] . Value = _list . backDeposit;
            parameter [ 9 ] . Value = _list . price;
            parameter [ 10 ] . Value = _list . weight;
            parameter [ 11 ] . Value = _list . applyMoney;
            parameter [ 12 ] . Value = _list . paymentType;
            parameter [ 13 ] . Value = _list . paymentMethod;
            parameter [ 14 ] . Value = _list . paymentMethodOther;
            parameter [ 15 ] . Value = _list . invoiceType;
            parameter [ 16 ] . Value = _list . paymentDate;
            parameter [ 17 ] . Value = _list . remark;
            parameter [ 18 ] . Value = _list . modifyTime;
            parameter [ 19 ] . Value = _list . modifyMan;
            parameter[20].Value = _list.Purchasecode;
            parameter[21].Value = _list.PurchasingUnit;
            parameter[22].Value = _list.PurchasingUnitId;
            parameter[23].Value = _list.ContactsId;

            int row = MySqlHelper . ExecuteSql ( strSql . ToString ( ) ,parameter );
            if ( row > 0 )
                return true;
            else
                return false;
        }


        /// <summary>
        /// 获取申请部门
        /// </summary>
        /// <returns></returns>
        public DataTable getDepart ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "select roleid,rolename from t_role" );

            return MySqlHelper . Query ( strSql . ToString ( ) ) . Tables [ 0 ];
        }

    }
}
