using NorthwindDAL_Data_Access_Layer_.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBLL_BusiessLogicLayer_.Repositories
{
    public class ProductManagementBLL
    {
        ProductManagement _productManagement = new ProductManagement();

        public void AddProduct(string productName,int supplierID,int categoryID,string quantityPerUnit,bool discontinued,out int effectedRowCount)
        {
            if (categoryID == 1)
            {
                effectedRowCount = 0;
            }
            else
            {
                //DAL'a gönder;
                _productManagement.AddProduct(productName, supplierID, categoryID, quantityPerUnit, discontinued, out effectedRowCount);
            }
        }

        public DataSet ListProduct()
        {
            return _productManagement.ListProduct();
        }
    }
}
