using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FishBll.Bll
{
    public class DeliveredManagementBll
    {
        FishBll.Dao.DeliveredManagementDao dal = new Dao.DeliveredManagementDao();
        public DeliveredManagementBll() { }
        public bool Exists(string strWhere)
        {
            return dal.Exists(strWhere);
        }
        public FishEntity.DeliveredManagementEntity getList(string strWhere)
        {
            return dal.getList(strWhere);
        }
        public bool Add(FishEntity.DeliveredManagementEntity _list)
        {
            return dal.Add(_list);
        }
        public bool Update(FishEntity.DeliveredManagementEntity _list)
        {
            return dal.Update(_list);
        }
    }
}
