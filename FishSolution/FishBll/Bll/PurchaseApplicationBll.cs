using System;
using System . Collections . Generic;
using System . Data;
using System . Text;

namespace FishBll . Bll
{
  public  class PurchaseApplicationBll
    {
        private readonly  Dao.PurchaseApplicationDao dal;
        public PurchaseApplicationBll ( )
        {
            dal = new Dao . PurchaseApplicationDao ( );
        }

        /// <summary>
        /// 得到申请单编号
        /// </summary>
        /// <returns></returns>
        public string getCodeNum ( )
        {
            return dal . getCodeNum ( );
        }

        /// <summary>
        /// 是否被引用
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool ExistsCodeNumContract ( int idx )
        {
            return dal . ExistsCodeNumContract ( idx );
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete ( int idx )
        {
            return dal . Delete ( idx );
        }


        /// <summary>
        /// 新怎数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add ( FishEntity . PurchaseApplicationEntity model )
        {
            return dal . Add ( model );
        }


        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Edit ( FishEntity . PurchaseApplicationEntity model )
        {
            return dal . Edit ( model );
        }


        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public FishEntity . PurchaseApplicationEntity getModel ( string strWhere )
        {
            return dal . getModel ( strWhere );
        }

        /// <summary>
        /// 获取编号
        /// </summary>
        /// <returns></returns>
        public DataTable getCodeNumData ( )
        {
            return dal . getCodeNumData ( );
        }

        }
}
