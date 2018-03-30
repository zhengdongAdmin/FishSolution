﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FishBll.Bll
{
    public class UserRoleBll
    {
            private readonly Dao.UserRoleDao dal = new Dao.UserRoleDao();
            public UserRoleBll()
            { }
            #region  BasicMethod
            /// <summary>
            /// 是否存在该记录
            /// </summary>
            public bool Exists(int id)
            {
                return dal.Exists(id);
            }

            /// <summary>
            /// 增加一条数据
            /// </summary>
            public bool Add(FishEntity.UserRoleEntity model)
            {
                return dal.Add(model);
            }

            /// <summary>
            /// 更新一条数据
            /// </summary>
            public bool Update(FishEntity.UserRoleEntity model)
            {
                return dal.Update(model);
            }

            /// <summary>
            /// 删除一条数据
            /// </summary>
            public bool Delete(int id)
            {

                return dal.Delete(id);
            }
            /// <summary>
            /// 删除一条数据
            /// </summary>
            public bool DeleteList(string idlist)
            {
                return dal.DeleteList(idlist);
            }

            public bool DeleteByUserId(int userid)
            {
                return dal.DeleteByUserId(userid);
            }

            /// <summary>
            /// 得到一个对象实体
            /// </summary>
            public FishEntity.UserRoleEntity GetModel(int id)
            {

                return dal.GetModel(id);
            }


            /// <summary>
            /// 获得数据列表
            /// </summary>
            public DataSet GetList(string strWhere)
            {
                return dal.GetList(strWhere);
            }
            /// <summary>
            /// 获得数据列表
            /// </summary>
            public List<FishEntity.UserRoleEntity> GetModelList(string strWhere)
            {
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            /// <summary>
            /// 获得数据列表
            /// </summary>
            public List<FishEntity.UserRoleEntity> DataTableToList(DataTable dt)
            {
                List<FishEntity.UserRoleEntity> modelList = new List<FishEntity.UserRoleEntity>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    FishEntity.UserRoleEntity model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = dal.DataRowToModel(dt.Rows[n]);
                        if (model != null)
                        {
                            modelList.Add(model);
                        }
                    }
                }
                return modelList;
            }

            /// <summary>
            /// 获得数据列表
            /// </summary>
            public DataSet GetAllList()
            {
                return GetList("");
            }

            /// <summary>
            /// 分页获取数据列表
            /// </summary>
            public int GetRecordCount(string strWhere)
            {
                return dal.GetRecordCount(strWhere);
            }
            /// <summary>
            /// 分页获取数据列表
            /// </summary>
            public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
            {
                return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
            }
            /// <summary>
            /// 分页获取数据列表
            /// </summary>
            //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
            //{
            //return dal.GetList(PageSize,PageIndex,strWhere);
            //}

            #endregion  BasicMethod
            #region  ExtensionMethod

            #endregion  ExtensionMethod
        
    }
}
