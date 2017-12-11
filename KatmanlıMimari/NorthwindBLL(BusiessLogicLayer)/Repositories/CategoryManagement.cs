using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBLL_BusiessLogicLayer_.Repositories
{
    public class CategoryManagement
    {
       private NorthwindDAL_Data_Access_Layer_.CategoryManagement _categoryManagement = new NorthwindDAL_Data_Access_Layer_.CategoryManagement();

       public DataSet ListCategory()
       {
           return _categoryManagement.ListCategory();
       }
    }
}
