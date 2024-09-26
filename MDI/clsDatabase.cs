using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI
{
    internal class clsDatabase
    {
        public static SqlConnection con;
        public static bool OpenConnection()
        {
            try 
            { 
                con= new SqlConnection(@"Server=ADMIN-PC\SQLEXPRESS;Database=HangHoa;Integrated Security = SSPI;");
                con.Open();
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool CloseConnection() {
            try 
            { 
                con.Close();
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
