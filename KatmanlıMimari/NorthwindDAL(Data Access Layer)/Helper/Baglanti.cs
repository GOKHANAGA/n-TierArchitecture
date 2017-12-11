using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL_Data_Access_Layer_.Helper
{
    public static class Baglanti
    {
        private static string _baglantiCumlecigi = "Server=.;Database=NORTHWND;Integrated Security=true";

        public static string BaglantiCumlecigi
        {
            get { return Baglanti._baglantiCumlecigi; }
        }

        private static SqlConnection _myConnection;

        public static SqlConnection MyConnection
        {
            get
            {
                if (_myConnection == null)
                {
                    _myConnection = new SqlConnection(Baglanti.BaglantiCumlecigi);
                }
                return _myConnection;
            }
        }

    }
}
