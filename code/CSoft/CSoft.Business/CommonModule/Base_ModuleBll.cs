//=====================================================================================
// All Rights Reserved , Copyright @ CSoft 2014
// Software Developers @ CSoft 2014
//=====================================================================================

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
    /// ƒ£øÈ…Ë÷√
    /// <author>
    ///		<name>she</name>
    ///		<date>2014.06.22 19:35</date>
    /// </author>
    /// </summary>
    public class Base_ModuleBll : RepositoryFactory<Base_Module>
    {
        public List<Base_Module> GetList()
        {
            return this.Repository().FindList("ORDER BY ParentId ASC,SortCode ASC");
        }
    }
}