using System;
using System.Collections.Generic;
using System.Text;

namespace FishBll.Bll
{
    public class FinishBll
    {
        private readonly Dao.FinishDao dal = new Dao.FinishDao();
        public FinishBll()
        { }
        public List<FishEntity.FinishVo> GetData(string strwhere)
        {
            return dal.GetData(strwhere);
        }
    }

}
