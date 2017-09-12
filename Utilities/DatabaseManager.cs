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
            DataTable dt = new DataTable();
            try {
                con.Open();
                da.Fill(dt);
            }
            catch (Exception e)
            {
                Validations.ShowError("נוצרה שגיאה בחיבור למסד נתונים\n" + e);
            }
            con.Close();
            return dt;
        }

        //Method to add or update or remove recrod to / from database table.
        public static void ADURecord(SQLQuery queryStatement)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = con;
                    comm.CommandText = queryStatement.ToString();
                    try
                    {
                        con.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Validations.ShowError(e.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }  
        }
    }
}
