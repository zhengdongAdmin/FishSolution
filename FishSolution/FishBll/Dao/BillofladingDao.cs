using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace FishBll.Dao
{
    public class BillofladingDao
    {
        public BillofladingDao() { }
        public int Add(FishEntity.BillofladingEntity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into t_billoflading(Numbering,code,Issuingtime,contactsunit,ContactsunitId,warehouse,species,specification,ferryname,listname,cornerno,Ton,packagenumber,Remarks,ShipNotice,Storagecosts,createtime,createman,modifytime,modifyman,codeContract,Recipient,SerialNumber )");
            strSql.Append("values(@Numbering,@code,@Issuingtime,@contactsunit,@ContactsunitId,@warehouse,@species,@specification,@ferryname,@listname,@cornerno,@Ton,@packagenumber,@Remarks,@ShipNotice,@Storagecosts,@createtime,@createman,@modifytime,@modifyman,@codeContract,@Recipient,@SerialNumber );select last_insert_id();");
            MySqlParameter[] parameters = {
                new MySqlParameter("@code",MySqlDbType.VarChar,45),
                new MySqlParameter("@Issuingtime",MySqlDbType.Timestamp),
                new MySqlParameter("@contactsunit",MySqlDbType.VarChar,100),
                new MySqlParameter("@warehouse",MySqlDbType.VarChar,100),
                new MySqlParameter("@species",MySqlDbType.VarChar,45),
                new MySqlParameter("@specification",MySqlDbType.VarChar,45),
                new MySqlParameter("@ferryname",MySqlDbType.VarChar,45),
                new MySqlParameter("@listname",MySqlDbType.VarChar,45),
                new MySqlParameter("@Ton",MySqlDbType.VarChar,45),
                new MySqlParameter("@packagenumber",MySqlDbType.VarChar,45),
                new MySqlParameter("@Remarks",MySqlDbType.VarChar,500),
                new MySqlParameter("@ShipNotice",MySqlDbType.VarChar,200),
                new MySqlParameter("@Storagecosts",MySqlDbType.VarChar,45),
                new MySqlParameter("@createtime",MySqlDbType.Timestamp),
                new MySqlParameter("@createman",MySqlDbType.VarChar,45),
                new MySqlParameter("@modifytime",MySqlDbType.Timestamp),
                new MySqlParameter("@modifyman",MySqlDbType.VarChar,45),
                new MySqlParameter("@codeContract",MySqlDbType.VarChar,200),
                new MySqlParameter("@Recipient",MySqlDbType.VarChar,445),
                new MySqlParameter("@cornerno",MySqlDbType.VarChar,45),
                new MySqlParameter("@ContactsunitId",MySqlDbType.VarChar,100),
                new MySqlParameter("@SerialNumber",MySqlDbType.VarBinary,100),
                new MySqlParameter("@Numbering",MySqlDbType.VarChar,45)
            };
            parameters[0].Value = model.Code;
            parameters[1].Value = model.Issuingtime;
            parameters[2].Value = model.Contactsunit;
            parameters[3].Value = model.Warehouse;
            parameters[4].Value = model.Species;
            parameters[5].Value = model.Specification;
            parameters[6].Value = model.Ferryname;
            parameters[7].Value = model.Listname;
            parameters[8].Value = model.Ton;
            parameters[9].Value = model.Packagenumber;
            parameters[10].Value = model.Remarks;
            parameters[11].Value = model.ShipNotice;
            parameters[12].Value = model.Storagecosts;
            parameters[13].Value = model.Createtime;
            parameters[14].Value = model.Createman;
            parameters[15].Value = model.Modifytime;
            parameters[16].Value = model.Modifyman;
            parameters [ 17 ] . Value = model . codeContract;
            parameters[18].Value = model.Recipient;
            parameters[19].Value = model.Cornerno;
            parameters[20].Value = model.ContactsunitId;
            parameters[21].Value = model.SerialNumber;
            parameters[22].Value = model.Numbering;
            int id = MySqlHelper.ExecuteSqlReturnId(strSql.ToString(), parameters); //MySqlHelper.ExecuteSql(strSql.ToString(), parameters);
            return id;
        }
        public bool Exists(string code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from t_billoflading");
            strSql.Append(" where code=@code ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@code", MySqlDbType.VarChar,45)};
            parameters[0].Value = code;

            return MySqlHelper.Exists(strSql.ToString(), parameters);
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
            strSql.Append("select count(*) from t_billoflading");
            strSql.Append(" where code=@code and createman=@createman");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@code", MySqlDbType.VarChar,45),
                    new MySqlParameter("@createman", MySqlDbType.VarChar,45)
            };
            parameters[0].Value = code;
            parameters[1].Value = createman;
            return MySqlHelper.Exists(strSql.ToString(), parameters);
        }

        public bool Update(FishEntity.BillofladingEntity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update t_billoflading set ");
            strSql.Append("Issuingtime = @Issuingtime,");
            strSql.Append("codeContract = @codeContract,");
            strSql.Append("contactsunit = @contactsunit,");
            strSql.Append("ContactsunitId = @ContactsunitId,");
            strSql.Append("warehouse = @warehouse,");
            strSql.Append("species = @species,");
            strSql.Append("specification = @specification,");
            strSql.Append("cornerno = @cornerno,");
            strSql.Append("ferryname = @ferryname,");
            strSql.Append("listname = @listname,");
            strSql.Append("Ton = @Ton,");
            strSql.Append("packagenumber = @packagenumber,");
            strSql.Append("Remarks = @Remarks,");
            strSql.Append("SerialNumber=@SerialNumber,");
            strSql.Append(" ShipNotice = @ShipNotice,");
            strSql.Append("modifyman = @modifyman,");
            strSql . Append ("Storagecosts = @Storagecosts,");
            strSql.Append("Recipient=@Recipient  ");
            strSql .Append(" where id = @id");
            MySqlParameter[] parameters = {
                new MySqlParameter("@Issuingtime",MySqlDbType.DateTime),
                new MySqlParameter("@codeContract",MySqlDbType.VarChar,200),
                new MySqlParameter("@contactsunit",MySqlDbType.VarChar,100),
                new MySqlParameter("@warehouse",MySqlDbType.VarChar,100),
                new MySqlParameter("@species",MySqlDbType.VarChar,45),
                new MySqlParameter("@specification",MySqlDbType.VarChar,45),
                new MySqlParameter("@cornerno",MySqlDbType.VarChar,45),
                new MySqlParameter("@ferryname",MySqlDbType.VarChar,45),
                new MySqlParameter("@listname",MySqlDbType.VarChar,45),
                new MySqlParameter("@Ton",MySqlDbType.VarChar,45),
                new MySqlParameter("@packagenumber",MySqlDbType.VarChar,45),
                new MySqlParameter("@Remarks",MySqlDbType.VarChar,500),
                new MySqlParameter("@ShipNotice",MySqlDbType.VarChar,200),
                new MySqlParameter("@modifytime",MySqlDbType.Timestamp),
                new MySqlParameter("@modifyman",MySqlDbType.VarChar,45),
                new MySqlParameter("@Storagecosts",MySqlDbType.VarChar,45),
                new MySqlParameter("@Recipient",MySqlDbType.VarChar,445),
                new MySqlParameter("@ContactsunitId",MySqlDbType.VarChar,100),
                new MySqlParameter("@id",MySqlDbType.Int32,11),
                new MySqlParameter("@SerialNumber",MySqlDbType.VarChar,100)
            };
            parameters[0].Value = model.Issuingtime;
            parameters[1].Value = model.codeContract;
            parameters[2].Value = model.Contactsunit;
            parameters[3].Value = model.Warehouse;
            parameters[4].Value = model.Species;
            parameters[5].Value = model.Specification;
            parameters[6].Value = model.Cornerno;
            parameters[7].Value = model.Ferryname;
            parameters[8].Value = model.Listname;
            parameters[9].Value = model.Ton;
            parameters[10].Value = model.Packagenumber;
            parameters[11].Value = model.Remarks;
            parameters[12].Value = model.ShipNotice;
            parameters[13].Value = model.Modifytime;
            parameters[14].Value = model.Modifyman;
            parameters[15].Value = model.Storagecosts;
            parameters[16].Value = model.Recipient;
            parameters[17].Value = model.ContactsunitId;
            parameters [18].Value = model.Id;
            parameters[19].Value = model.SerialNumber;

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
    }
}
