using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBLL_BusiessLogicLayer_.Repositories
{
    public class SupplierManagement
    {
        NorthwindDAL_Data_Access_Layer_.Repositories.SupplierManagement _supplierManagement = new NorthwindDAL_Data_Access_Layer_.Repositories.SupplierManagement();
        public DataSet ListSuppliers()
        {
            return _supplierManagement.ListSupplier();
        }
    }
}
