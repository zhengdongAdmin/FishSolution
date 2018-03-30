using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text;


namespace FishBll.Dao
{
    public class DeliveredManagementDao
    {
        public DeliveredManagementDao() { }
        public bool Exists(string strWhere)
        {
            StringBuilder Strsql = new StringBuilder();
            Strsql.Append(" select count(*) from t_deliveredmanagement ");
            return MySqlHelper.Exists(Strsql.ToString());
        }
        public DateTime getDate()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT now() t");

            DataSet da = MySqlHelper.Query(strSql.ToString());

            return Convert.ToDateTime(da.Tables[0].Rows[0]["t"].ToString());
        }
        public bool Update(FishEntity.DeliveredManagementEntity _list)
        {
            StringBuilder Strsql = new StringBuilder();
            _list.modifytime = getDate();
            Strsql.Append("update t_deliveredmanagement set ");
            Strsql.Append("cmbTJxssqd=@cmbTJxssqd,");
            Strsql.Append("txtTJxssqd=@txtTJxssqd,");
            Strsql.Append("cmbSGxssqd=@cmbSGxssqd,");
            Strsql.Append("txtSGxssqd=@txtSGxssqd,");
            Strsql.Append("cmbTJxsht=@cmbTJxsht,");
            Strsql.Append("txtTJxsht=@txtTJxsht,");
            Strsql.Append("cmbSGxsht=@cmbSGxsht,");
            Strsql.Append("txtSGxsht=@txtSGxsht,");
            Strsql.Append("cmbTJfksqd=@cmbTJfksqd,");
            Strsql.Append("txtTJfksqd=@txtTJfksqd,");
            Strsql.Append("cmbSGfksqd=@cmbSGfksqd,");
            Strsql.Append("txtSGfksqd=@txtSGfksqd,");
            Strsql.Append("cmbTJbd=@cmbTJbd,");
            Strsql.Append("txtTJbd=@txtTJbd,");
            Strsql.Append("cmbSGbd=@cmbSGbd,");
            Strsql.Append("txtSGbd=@txtSGbd,");
            Strsql.Append("cmbTJhwfkd=@cmbTJhwfkd,");
            Strsql.Append("txtTJhwfkd=@txtTJhwfkd,");
            Strsql.Append("cmbSGhwfkd=@cmbSGhwfkd,");
            Strsql.Append("txtSGhwfkd=@txtSGhwfkd,");
            Strsql.Append("cmbTJgswtfkd=@cmbTJgswtfkd,");
            Strsql.Append("txtTJgswtfkd=@txtTJgswtfkd,");
            Strsql.Append("cmbSGgswtfkd=@cmbSGgswtfkd,");
            Strsql.Append("txtSGgswtfkd=@txtSGgswtfkd,");
            Strsql.Append("cmbTJskjld=@cmbTJskjld,");
            Strsql.Append("txtTJskjld=@txtTJskjld,");
            Strsql.Append("cmbSGskjld=@cmbSGskjld,");
            Strsql.Append("txtSGskjld=@txtSGskjld,");
            Strsql.Append("modifyman=@modifyman,");
            Strsql.Append("modifytime=@modifytime ");
            Strsql.Append("where id=@id");
            MySqlParameter[] parameter = {
                new MySqlParameter("@cmbTJxssqd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtTJxssqd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbSGxssqd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtSGxssqd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbTJxsht",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtTJxsht",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbSGxsht",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtSGxsht",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbTJfksqd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtTJfksqd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbSGfksqd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtSGfksqd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbTJbd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtTJbd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbSGbd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtSGbd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbTJhwfkd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtTJhwfkd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbSGhwfkd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtSGhwfkd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbTJgswtfkd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtTJgswtfkd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbSGgswtfkd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtSGgswtfkd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbTJskjld",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtTJskjld",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbSGskjld",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtSGskjld",MySqlDbType.VarChar,200),
                new MySqlParameter("@modifyman",MySqlDbType.VarChar,45),
                new MySqlParameter("@modifytime",MySqlDbType.DateTime),
                new MySqlParameter("@id",MySqlDbType.Int32,11),
            };
            parameter[0].Value = _list.cmbTJxssqd;
            parameter[1].Value = _list.txtTJxssqd;
            parameter[2].Value = _list.cmbSGxssqd;
            parameter[3].Value = _list.txtSGxssqd;
            parameter[4].Value = _list.cmbTJxsht;
            parameter[5].Value = _list.txtTJxsht;
            parameter[6].Value = _list.cmbSGxsht;
            parameter[7].Value = _list.txtSGxsht;
            parameter[8].Value = _list.cmbTJfksqd;
            parameter[9].Value = _list.txtTJfksqd;
            parameter[10].Value = _list.cmbSGfksqd;
            parameter[11].Value = _list.txtSGfksqd;
            parameter[12].Value = _list.cmbTJbd;
            parameter[13].Value = _list.txtTJbd;
            parameter[14].Value = _list.cmbSGbd;
            parameter[15].Value = _list.txtSGbd;            
            parameter[16].Value = _list.cmbTJhwfkd;
            parameter[17].Value = _list.txtTJhwfkd;
            parameter[18].Value = _list.cmbSGhwfkd;
            parameter[19].Value = _list.txtSGhwfkd;
            parameter[20].Value = _list.cmbTJgswtfkd;
            parameter[21].Value = _list.txtTJgswtfkd;
            parameter[22].Value = _list.cmbSGgswtfkd;
            parameter[23].Value = _list.txtSGgswtfkd;            
            parameter[24].Value = _list.cmbTJskjld;
            parameter[25].Value = _list.txtTJskjld;
            parameter[26].Value = _list.cmbSGskjld;
            parameter[27].Value = _list.txtSGskjld;
            parameter[28].Value = _list.modifyman;
            parameter[29].Value = _list.modifytime;
            parameter[30].Value = _list.id;
            int row = MySqlHelper.ExecuteSql(Strsql.ToString(), parameter);
            if (row > 0)
                return true;
            else
                return false;
        }
        public bool Add(FishEntity.DeliveredManagementEntity _list)
        {
            StringBuilder Strsql = new StringBuilder();
            _list.createtime = _list.modifytime = getDate();
            Strsql.Append("insert into t_deliveredmanagement(cmbTJxssqd,txtTJxssqd,cmbSGxssqd,txtSGxssqd,cmbTJxsht,txtTJxsht,cmbSGxsht,txtSGxsht,cmbTJfksqd,txtTJfksqd,cmbSGfksqd,txtSGfksqd,cmbTJbd,txtTJbd,cmbSGbd,txtSGbd,cmbTJhwfkd,txtTJhwfkd,cmbSGhwfkd,txtSGhwfkd,cmbTJgswtfkd,txtTJgswtfkd,cmbSGgswtfkd,txtSGgswtfkd,cmbTJskjld,txtTJskjld,cmbSGskjld,txtSGskjld,createman,createtime,modifyman,modifytime)values");
            Strsql.Append("(@cmbTJxssqd,@txtTJxssqd,@cmbSGxssqd,@txtSGxssqd,@cmbTJxsht,@txtTJxsht,@cmbSGxsht,@txtSGxsht,@cmbTJfksqd,@txtTJfksqd,@cmbSGfksqd,@txtSGfksqd,@cmbTJbd,@txtTJbd,@cmbSGbd,@txtSGbd,@cmbTJhwfkd,@txtTJhwfkd,@cmbSGhwfkd,@txtSGhwfkd,@cmbTJgswtfkd,@txtTJgswtfkd,@cmbSGgswtfkd,@txtSGgswtfkd,@cmbTJskjld,@txtTJskjld,@cmbSGskjld,@txtSGskjld,@createman,@createtime,@modifyman,@modifytime)");
            MySqlParameter[] parameter = {
                new MySqlParameter("@cmbTJxssqd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtTJxssqd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbSGxssqd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtSGxssqd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbTJxsht",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtTJxsht",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbSGxsht",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtSGxsht",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbTJfksqd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtTJfksqd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbSGfksqd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtSGfksqd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbTJbd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtTJbd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbSGbd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtSGbd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbTJhwfkd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtTJhwfkd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbSGhwfkd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtSGhwfkd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbTJgswtfkd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtTJgswtfkd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbSGgswtfkd",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtSGgswtfkd",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbTJskjld",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtTJskjld",MySqlDbType.VarChar,200),
                new MySqlParameter("@cmbSGskjld",MySqlDbType.VarChar,45),
                new MySqlParameter("@txtSGskjld",MySqlDbType.VarChar,200),
                new MySqlParameter("@createman",MySqlDbType.VarChar,45),
                new MySqlParameter("@createtime",MySqlDbType.DateTime),
                new MySqlParameter("@modifyman",MySqlDbType.VarChar,45),
                new MySqlParameter("@modifytime",MySqlDbType.DateTime)
            };
            parameter[0].Value = _list.cmbTJxssqd;
            parameter[1].Value = _list.txtTJxssqd;
            parameter[2].Value = _list.cmbSGxssqd;
            parameter[3].Value = _list.txtSGxssqd;
            parameter[4].Value = _list.cmbTJxsht;
            parameter[5].Value = _list.txtTJxsht;
            parameter[6].Value = _list.cmbSGxsht;
            parameter[7].Value = _list.txtSGxsht;
            parameter[8].Value = _list.cmbTJfksqd;
            parameter[9].Value = _list.txtTJfksqd;
            parameter[10].Value = _list.cmbSGfksqd;
            parameter[11].Value = _list.txtSGfksqd;
            parameter[12].Value = _list.cmbTJbd;
            parameter[13].Value = _list.txtTJbd;
            parameter[14].Value = _list.cmbSGbd;
            parameter[15].Value = _list.txtSGbd;
            parameter[16].Value = _list.cmbTJhwfkd;
            parameter[17].Value = _list.txtTJhwfkd;
            parameter[18].Value = _list.cmbSGhwfkd;
            parameter[19].Value = _list.txtSGhwfkd;
            parameter[20].Value = _list.cmbTJgswtfkd;
            parameter[21].Value = _list.txtTJgswtfkd;
            parameter[22].Value = _list.cmbSGgswtfkd;
            parameter[23].Value = _list.txtSGgswtfkd;
            parameter[24].Value = _list.cmbTJskjld;
            parameter[25].Value = _list.txtTJskjld;
            parameter[26].Value = _list.cmbSGskjld;
            parameter[27].Value = _list.txtSGskjld;
            parameter[28].Value = _list.createman;
            parameter[29].Value = _list.createtime;
            parameter[30].Value = _list.modifyman;
            parameter[31].Value = _list.modifytime;

            int row = MySqlHelper.ExecuteSql(Strsql.ToString(), parameter);
            if (row > 0)
                return true;
            else
                return false;
        }
        public FishEntity.DeliveredManagementEntity getList(string strWhere)
        {
            StringBuilder Strsql = new StringBuilder();
            Strsql.Append(" select * from t_deliveredmanagement ");
            DataSet ds = MySqlHelper.Query(Strsql.ToString());
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                return GetDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }
        public FishEntity.DeliveredManagementEntity GetDataRow(DataRow row)
        {
            FishEntity.DeliveredManagementEntity model = new FishEntity.DeliveredManagementEntity();
            if (row != null)
            {
                if (row["id"]!=null&&row["id"].ToString()!="")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["cmbTJxssqd"]!=null)
                {
                    model.cmbTJxssqd = row["cmbTJxssqd"].ToString();
                }
                if (row["txtTJxssqd"] != null)
                {
                    model.txtTJxssqd = row["txtTJxssqd"].ToString();
                }
                if (row["cmbSGxssqd"] != null)
                {
                    model.cmbSGxssqd = row["cmbSGxssqd"].ToString();
                }
                if (row["txtSGxssqd"] != null)
                {
                    model.txtSGxssqd = row["txtSGxssqd"].ToString();
                }
                if (row["cmbTJxsht"] != null)
                {
                    model.cmbTJxsht = row["cmbTJxsht"].ToString();
                }
                if (row["txtTJxsht"] != null)
                {
                    model.txtTJxsht = row["txtTJxsht"].ToString();
                }
                if (row["cmbSGxsht"] != null)
                {
                    model.cmbSGxsht = row["cmbSGxsht"].ToString();
                }
                if (row["txtSGxsht"] != null)
                {
                    model.txtSGxsht = row["txtSGxsht"].ToString();
                }
                if (row["cmbTJfksqd"] != null)
                {
                    model.cmbTJfksqd = row["cmbTJfksqd"].ToString();
                }
                if (row["txtTJfksqd"] != null)
                {
                    model.txtTJfksqd = row["txtTJfksqd"].ToString();
                }
                if (row["cmbSGfksqd"] != null)
                {
                    model.cmbSGfksqd = row["cmbSGfksqd"].ToString();
                }
                if (row["txtSGfksqd"] != null)
                {
                    model.txtSGfksqd = row["txtSGfksqd"].ToString();
                }
                if (row["cmbTJbd"] != null)
                {
                    model.cmbTJbd = row["cmbTJbd"].ToString();
                }
                if (row["txtTJbd"] != null)
                {
                    model.txtTJbd = row["txtTJbd"].ToString();
                }
                if (row["cmbSGbd"] != null)
                {
                    model.cmbSGbd = row["cmbSGbd"].ToString();
                }
                if (row["txtSGbd"] != null)
                {
                    model.txtSGbd = row["txtSGbd"].ToString();
                }
                if (row["cmbTJhwfkd"] != null)
                {
                    model.cmbTJhwfkd = row["cmbTJhwfkd"].ToString();
                }
                if (row["txtTJhwfkd"] != null)
                {
                    model.txtTJhwfkd = row["txtTJhwfkd"].ToString();
                }
                if (row["cmbSGhwfkd"] != null)
                {
                    model.cmbSGhwfkd = row["cmbSGhwfkd"].ToString();
                }
                if (row["txtSGhwfkd"] != null)
                {
                    model.txtSGhwfkd = row["txtSGhwfkd"].ToString();
                }
                if (row["cmbTJgswtfkd"] != null)
                {
                    model.cmbTJgswtfkd = row["cmbTJgswtfkd"].ToString();
                }
                if (row["txtTJgswtfkd"] != null)
                {
                    model.txtTJgswtfkd = row["txtTJgswtfkd"].ToString();
                }
                if (row["cmbSGgswtfkd"] != null)
                {
                    model.cmbSGgswtfkd = row["cmbSGgswtfkd"].ToString();
                }
                if (row["txtSGgswtfkd"] != null)
                {
                    model.txtSGgswtfkd = row["txtSGgswtfkd"].ToString();
                }
                if (row["cmbTJskjld"] != null)
                {
                    model.cmbTJskjld = row["cmbTJskjld"].ToString();
                }
                if (row["txtTJskjld"] != null)
                {
                    model.txtTJskjld = row["txtTJskjld"].ToString();
                }
                if (row["cmbSGskjld"] != null)
                {
                    model.cmbSGskjld = row["cmbSGskjld"].ToString();
                }
                if (row["txtSGskjld"] != null)
                {
                    model.txtSGskjld = row["txtSGskjld"].ToString();
                }
                if (row["createman"] != null)
                {
                    model.createman = row["createman"].ToString();
                }
                if (row["createtime"] != null)
                {
                    model.createtime =DateTime.Parse(row["createtime"].ToString());
                }
                if (row["modifyman"] != null)
                {
                    model.modifyman = row["modifyman"].ToString();
                }
                if (row["modifytime"] != null)
                {
                    model.modifytime =DateTime.Parse(row["modifytime"].ToString());
                }
            }
            return model ;
        }
    }
}
