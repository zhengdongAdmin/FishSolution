﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FishBll.Bll
{
    public class happeningBll
    {
        private readonly FishBll.Dao.happeningDao dal = new Dao.happeningDao();

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<FishEntity . SalesRequisitionBodyEntity> getList ( string Numbering)
        {
            return dal . getList (Numbering);
        }
    }
}
