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
    public class ProductManagement
    {
        SqlConnection conn = Baglanti.MyConnection;
        public void AddProduct(string productName, int supplierID, int categoryID, string quantityPerUnit, bool discontinued, out int effectedRowCount)
        {
            SqlConnection conn = Baglanti.MyConnection;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,Discontinued) VALUES (@productName,@supplierID,@categoryID,@quantityPerUnit,@discontinued)";

            cmd.Parameters.AddWithValue("@productName", productName);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Parameters.AddWithValue("@categoryID", categoryID);
            cmd.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            cmd.Parameters.AddWithValue("discontinued", discontinued);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            effectedRowCount=cmd.ExecuteNonQuery();
            

            conn.Close();
        }

        public DataSet ListProduct()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", conn);
            SqlDataAdapter dA = new SqlDataAdapter(cmd);
            DataSet dS = new DataSet();
            dA.Fill(dS);
            return dS;
        }
    }
}
