using NorthwindBLL_BusiessLogicLayer_.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindUI
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                /*----Dropdown list for category id and supplier id----*/
                SupplierManagement _supplierManagement = new SupplierManagement();
                CategoryManagement _categoryManagement = new CategoryManagement();
                ddlSupplier.DataSource = _supplierManagement.ListSuppliers().Tables[0];
                ddlSupplier.DataTextField = "SupplierID";
                ddlSupplier.DataBind();

                ddlCategory.DataSource = _categoryManagement.ListCategory().Tables[0];
                ddlCategory.DataTextField = "CategoryID";
                ddlCategory.DataBind();
            }
        }
        ProductManagementBLL _productManagementBLL = new ProductManagementBLL();


        protected void btnNewProduct_Click(object sender, EventArgs e)
        {
            int effectedRowCount = 0;


            int inputPrice = 0;
            if (!int.TryParse(txtQuantity.Text, out inputPrice))
            {
                ltlState.Text = "Doğru türde veri giriniz (TamSayı)";
            }
            else
            {
                _productManagementBLL.AddProduct(txtProductName.Text, Convert.ToInt32(ddlSupplier.SelectedValue), Convert.ToInt32(ddlCategory.SelectedValue), txtQuantity.Text, Convert.ToBoolean(txtDiscontinued.Text), out effectedRowCount);
                ltlState.Text = string.Format("<h1>{0} satır etkilendi.</h1>", effectedRowCount.ToString());
            }

        }
    }
}