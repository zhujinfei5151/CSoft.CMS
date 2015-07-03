//=====================================================================================
// All Rights Reserved , Copyright @ CSoft 2014
// Software Developers @ CSoft 2014
//=====================================================================================

using CSoft.Entity;
using CSoft.Repository;
using CSoft.Utilities;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSoft.Business
{
    /// <summary>
    /// 公司管理
    /// <author>
    ///		<name>she</name>
    ///		<date>2014.08.06 10:59</date>
    /// </author>
    /// </summary>
    public class Base_CompanyBll : RepositoryFactory<Base_Company>
    {
        /// <summary>
        /// 获取公司列表
        /// </summary>
        /// <returns></returns>
        public List<Base_Company> GetList()
        {
            StringBuilder WhereSql = new StringBuilder();
            if (!ManageProvider.Provider.Current().IsSystem)
            {
                WhereSql.Append(" AND ( CompanyId IN ( SELECT ResourceId FROM Base_DataScopePermission WHERE");
                WhereSql.Append(" ObjectId IN ('" + ManageProvider.Provider.Current().ObjectId.Replace(",", "','") + "') ");
                WhereSql.Append(" ) )");
            }
            WhereSql.Append(" ORDER BY SortCode ASC");
            return Repository().FindList(WhereSql.ToString());
        }
    }
}