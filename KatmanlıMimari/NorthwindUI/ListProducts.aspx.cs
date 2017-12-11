using NorthwindBLL_BusiessLogicLayer_.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindUI
{
    public partial class ListProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductManagementBLL pmBll = new ProductManagementBLL();
            grdProducts.DataSource = pmBll.ListProduct();
            grdProducts.DataBind();
        }
    }
}