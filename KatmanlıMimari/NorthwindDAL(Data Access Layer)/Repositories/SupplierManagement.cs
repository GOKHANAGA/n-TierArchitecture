using NorthwindDAL_Data_Access_Layer_.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL_Data_Access_Layer_.Repositories
{
    public class SupplierManagement
    {
        SqlConnection conn = Baglanti.MyConnection;
        public DataSet ListSupplier()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Suppliers", conn);
            SqlDataAdapter dA = new SqlDataAdapter(cmd);
            DataSet dS = new DataSet();
            dA.Fill(dS);
            return dS;
        }
    }
}
