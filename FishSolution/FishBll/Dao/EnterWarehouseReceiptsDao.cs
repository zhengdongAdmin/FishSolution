using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace FishBll.Dao
{
    public class EnterWarehouseReceiptsDao
    {
        public bool Exists(string code)//
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from t_enterwarehousereceipts");
            strSql.Append(" where code=@code ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@code", MySqlDbType.VarChar,45)};
            parameters[0].Value = code;

            return MySqlHelper.Exists(strSql.ToString(), parameters);
        }
        public int Add(FishEntity.EnterWarehouseReceipts model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into t_enterwarehousereceipts(");
            strSql.Append("code,Requester,Shipname,tonnage,tName,Billnumber,NumberOfPieces,Unpackingdate,actualnumber,StorageLocation,position,Remarks,createtime,createman,modifytime,modifyman,TO1,TEL1,ANTI1,FAX1,ContractNo,Zhuangjiao)");
            strSql.Append("values(");
            strSql.Append("@code,@Requester,@Shipname,@tonnage,@tName,@Billnumber,@NumberOfPieces,@Unpackingdate,@actualnumber,@StorageLocation,@position,@Remarks,@createtime,@createman,@modifytime,@modifyman,@TO1,@TEL1,@ANTI1,@FAX1,@ContractNo,@Zhuangjiao);");
            strSql.Append("select last_insert_id();");
            MySqlParameter[] parameters = {
                new MySqlParameter("@code",MySqlDbType.VarChar,45),
                new MySqlParameter("@Requester",MySqlDbType.VarChar,45),
                new MySqlParameter("@Shipname",MySqlDbType.VarChar,45),
                new MySqlParameter("@tonnage",MySqlDbType.Decimal,45),
                new MySqlParameter("@tName",MySqlDbType.VarChar,45),
                new MySqlParameter("@Billnumber",MySqlDbType.VarChar,45),
                new MySqlParameter("@NumberOfPieces",MySqlDbType.Decimal,45),
                new MySqlParameter("@Unpackingdate",MySqlDbType.DateTime),
                new MySqlParameter("@actualnumber",MySqlDbType.Decimal,45),
                new MySqlParameter("@StorageLocation",MySqlDbType.VarChar,45),
                new MySqlParameter("@position",MySqlDbType.VarChar,200),
                new MySqlParameter("@Remarks",MySqlDbType.VarChar,100),
                new MySqlParameter("@createtime",MySqlDbType.Timestamp),
                new MySqlParameter("@createman",MySqlDbType.VarChar,45),
                new MySqlParameter("@modifytime",MySqlDbType.Timestamp),
                new MySqlParameter("@modifyman",MySqlDbType.VarChar,45),
                new MySqlParameter("@TO1",MySqlDbType.VarChar,45),
                new MySqlParameter("@TEL1",MySqlDbType.VarChar,45),
                new MySqlParameter("@ANTI1",MySqlDbType.VarChar,45),
                new MySqlParameter("@FAX1",MySqlDbType.VarChar,45),
                new MySqlParameter("@ContractNo",MySqlDbType.VarChar,45),
                new MySqlParameter("@Zhuangjiao",MySqlDbType.VarChar,45)
            };
            parameters[0].Value = model.Code;
            parameters[1].Value = model.Requester;
            parameters[2].Value = model.Shipname;
            parameters[3].Value = model.Tonnage;
            parameters[4].Value = model.TName;
            parameters[5].Value = model.Billnumber;
            parameters[6].Value = model.NumberOfPieces;
            parameters[7].Value = model.Unpackingdate;
            parameters[8].Value = model.Actualnumber;
            parameters[9].Value = model.StorageLocation;
            parameters[10].Value = model.Position;
            parameters[11].Value = model.Remarks;
            parameters[12].Value = model.Createtime;
            parameters[13].Value = model.Createman;
            parameters[14].Value = model.Modifytime;
            parameters[15].Value = model.Modifyman;
            parameters[16].Value = model.TO;
            parameters[17].Value = model.TEL;
            parameters[18].Value = model.ANTI;
            parameters[19].Value = model.FAX;
            parameters[20].Value = model.ContractNo;
            parameters[21].Value = model.Zhuangjiao;
            int id = MySqlHelper.ExecuteSqlReturnId(strSql.ToString(), parameters); //MySqlHelper.ExecuteSql(strSql.ToString(), parameters);
            return id;
        }
        public bool Update(FishEntity.EnterWarehouseReceipts model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update t_enterwarehousereceipts set ");
            strSql.Append("code = @code,");
            strSql.Append("Requester = @Requester,");
            strSql.Append("Shipname = @Shipname,");
            strSql.Append("tonnage = @tonnage,");
            strSql.Append("tName = @tName,");
            strSql.Append("Billnumber = @Billnumber,");
            strSql.Append("NumberOfPieces = @NumberOfPieces,");
            strSql.Append("Unpackingdate = @Unpackingdate,");
            strSql.Append("actualnumber = @actualnumber,");
            strSql.Append("StorageLocation = @StorageLocation,");
            strSql.Append("position = @position,");
            strSql.Append("Remarks = @Remarks,");
            strSql.Append("modifytime = @modifytime,");
            strSql.Append("modifyman = @modifyman,");
            strSql.Append("TO1 = @TO1,");
            strSql.Append("TEL1 = @TEL1,");
            strSql.Append("ANTI1 = @ANTI1,");
            strSql.Append("FAX1 = @FAX1, ");
            strSql.Append("ContractNo=@ContractNo, ");
            strSql.Append("Zhuangjiao=@Zhuangjiao ");
            strSql.Append("where id = @id");
            MySqlParameter[] parameters = {
                new MySqlParameter("@code",MySqlDbType.VarChar,45),
                new MySqlParameter("@Requester",MySqlDbType.VarChar,45),
                new MySqlParameter("@Shipname",MySqlDbType.VarChar,45),
                new MySqlParameter("@tonnage",MySqlDbType.Decimal,45),
                new MySqlParameter("@tName",MySqlDbType.VarChar,45),
                new MySqlParameter("@Billnumber",MySqlDbType.VarChar,45),
                new MySqlParameter("@NumberOfPieces",MySqlDbType.Decimal,45),
                new MySqlParameter("@Unpackingdate",MySqlDbType.DateTime),
                new MySqlParameter("@actualnumber",MySqlDbType.Decimal,45),
                new MySqlParameter("@StorageLocation",MySqlDbType.VarChar,45),
                new MySqlParameter("@position",MySqlDbType.VarChar,200),
                new MySqlParameter("@Remarks",MySqlDbType.VarChar,100),
                new MySqlParameter("@modifytime",MySqlDbType.Timestamp),
                new MySqlParameter("@modifyman",MySqlDbType.VarChar,45),
                new MySqlParameter("@TO1",MySqlDbType.VarChar,45),
                new MySqlParameter("@TEL1",MySqlDbType.VarChar,45),
                new MySqlParameter("@ANTI1",MySqlDbType.VarChar,45),
                new MySqlParameter("@FAX1",MySqlDbType.VarChar,45),
                new MySqlParameter("@id",MySqlDbType.VarChar,11),
                new MySqlParameter("@ContractNo",MySqlDbType.VarChar,45),
                new MySqlParameter("@Zhuangjiao",MySqlDbType.VarChar,45)
            };
            parameters[0].Value = model.Code;
            parameters[1].Value = model.Requester;
            parameters[2].Value = model.Shipname;
            parameters[3].Value = model.Tonnage;
            parameters[4].Value = model.TName;
            parameters[5].Value = model.Billnumber;
            parameters[6].Value = model.NumberOfPieces;
            parameters[7].Value = model.Unpackingdate;
            parameters[8].Value = model.Actualnumber;
            parameters[9].Value = model.StorageLocation;
            parameters[10].Value = model.Position;
            parameters[11].Value = model.Remarks;
            parameters[12].Value = model.Modifytime;
            parameters[13].Value = model.Modifyman;
            parameters[14].Value = model.TO;
            parameters[15].Value = model.TEL;
            parameters[16].Value = model.ANTI;
            parameters[17].Value = model.FAX;
            parameters[18].Value = model.Id;
            parameters[19].Value = model.ContractNo;
            parameters[20].Value = model.Zhuangjiao;
            int rows = MySqlHelper.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<FishEntity.EnterWarehouseReceipts> GetModelListVo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_enterwarehousereceipts ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            DataSet ds = MySqlHelper.Query(strSql.ToString());
            List<FishEntity.EnterWarehouseReceipts> modelList = new List<FishEntity.EnterWarehouseReceipts>();
            int rowsCount = ds.Tables[0].Rows.Count;
            FishEntity.EnterWarehouseReceipts model;
            for (int n = 0; n < rowsCount; n++)
            {
                DataRow row = ds.Tables[0].Rows[n];
                model = new FishEntity.EnterWarehouseReceipts();
                if (row["id"].ToString()!="")
                {
                    model.Id = int.Parse(row["id"].ToString());
                }
                if (row["code"] != null && row["code"].ToString() != "")
                {
                    model.Code = row["code"].ToString();
                }
                if (row["Requester"].ToString()!=""&&row["Requester"]!=null)
                {
                    model.Requester = row["Requester"].ToString();
                }
                if (row["Shipname"]!=null&&row["Shipname"].ToString()!="")
                {
                    model.Shipname = row["Shipname"].ToString();
                }
                if (row["tonnage"]!=null&&row["tonnage"].ToString()!="")
                {
                    model.Tonnage = decimal.Parse(row["tonnage"].ToString());
                }
                if (row["tName"]!=null&&row["tName"].ToString()!="")
                {
                    model.TName = row["tName"].ToString();
                }
                if (row["Billnumber"]!=null&&row["Billnumber"].ToString()!="")
                {
                    model.Billnumber = row["Billnumber"].ToString();
                }
                if (row["NumberOfPieces"]!=null&&row["NumberOfPieces"].ToString()!="")
                {
                    model.NumberOfPieces = decimal.Parse(row["NumberOfPieces"].ToString());
                }
                if (row["Unpackingdate"]!=null&&row["Unpackingdate"].ToString()!="")
                {
                    model.Unpackingdate = DateTime.Parse(row["Unpackingdate"].ToString());
                }
                if (row["actualnumber"]!=null&&row["actualnumber"].ToString()!="")
                {
                    model.Actualnumber = decimal.Parse(row["actualnumber"].ToString());
                }
                if (row["StorageLocation"]!=null&&row["StorageLocation"].ToString()!="")
                {
                    model.StorageLocation = row["StorageLocation"].ToString();
                }
                if (row["position"]!=null&&row["position"].ToString()!="")
                {
                    model.Position = row["position"].ToString();
                }
                if (row["Remarks"]!=null&&row["Remarks"].ToString()!="")
                {
                    model.Remarks = row["Remarks"].ToString();
                }
                if (row["TO1"]!=null&&row["TO1"].ToString()!="")
                {
                    model.TO = row["TO1"].ToString();
                }
                if (row["TEL1"]!=null&&row["TEL1"].ToString()!="")
                {
                    model.TEL = row["TEL1"].ToString();
                }
                if (row["ANTI1"]!=null&&row["ANTI1"].ToString()!="")
                {
                    model.ANTI = row["ANTI1"].ToString();
                }
                if (row["FAX1"]!=null&&row["FAX1"].ToString()!="")
                {
                    model.FAX = row["FAX1"].ToString();
                }
                if (row["ContractNo"]!=null)
                {
                    model.ContractNo = row["ContractNo"].ToString();
                }
                if (row["Zhuangjiao"]!=null)
                {
                    model.Zhuangjiao = row["Zhuangjiao"].ToString();
                }
                modelList.Add(model);
            }
                return modelList;
        }
    }
}
