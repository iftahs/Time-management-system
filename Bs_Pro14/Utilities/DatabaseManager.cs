using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Bs_Pro14.Utilities
{
    abstract class DatabaseManager
    {
        static string connectionString = "Server=tcp:iftahserver.database.windows.net,1433; Initial Catalog=Bs_Pro14; Persist Security Info = False; User ID=iftahs; Password=ProjectBS14; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";

        //Connect to database and return DataAdapter.
        public static DataTable Connect(string queryStatement)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(queryStatement, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try {
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("נוצרה שגיאה בחיבור למסד נתונים\n" + e);
            }
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Close Connection to database.
        public static void CloseConnection()
        {
            SqlConnection _con = new SqlConnection(connectionString);
            _con.Close();
        }
    }
}
