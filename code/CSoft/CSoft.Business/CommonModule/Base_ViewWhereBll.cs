//=====================================================================================
// All Rights Reserved , Copyright @ CSoft 2014
// Software Developers @ CSoft 2014
//=====================================================================================

using CSoft.DataAccess;
using CSoft.Entity;
using CSoft.Repository;
using CSoft.Utilities;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace CSoft.Business
{
    /// <summary>
    /// ��ͼ��ѯ������
    /// <author>
    ///		<name>she</name>
    ///		<date>2014.09.04 10:10</date>
    /// </author>
    /// </summary>
    public class Base_ViewWhereBll : RepositoryFactory<Base_ViewWhere>
    {
        /// <summary>
        /// ����ģ��Id��ȡ��ͼ��ѯ�����б�
        /// </summary>
        /// <param name="ModuleId"></param>
        /// <returns></returns>
        public List<Base_ViewWhere> GetViewWhereList(string ModuleId)
        {
            StringBuilder WhereSql = new StringBuilder();
            List<DbParameter> parameter = new List<DbParameter>();
            WhereSql.Append(" AND ModuleId = @ModuleId");
            parameter.Add(DbFactory.CreateDbParameter("@ModuleId", ModuleId));
            return Repository().FindList(WhereSql.ToString(), parameter.ToArray());
        }
    }
}