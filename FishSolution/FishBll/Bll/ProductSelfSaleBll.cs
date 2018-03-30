using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FishBll.Bll
{
    public class ProductSelfSaleBll
    {
        protected Dao.ProductSelfSaleDao _dal = new Dao.ProductSelfSaleDao();

        public List<FishEntity.ProductSelfSaleVo> GetSelfSale(string where)
        {
            DataSet dsData = _dal.GetSelfSale(where);
            return DataTableToList(dsData.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FishEntity.ProductSelfSaleVo> DataTableToList(DataTable dt)
        {
            List<FishEntity.ProductSelfSaleVo> modelList = new List<FishEntity.ProductSelfSaleVo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                FishEntity.ProductSelfSaleVo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = _dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }
    }
}
