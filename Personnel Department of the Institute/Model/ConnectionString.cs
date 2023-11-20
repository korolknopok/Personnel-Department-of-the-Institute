using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel_Department_of_the_Institute.Model
{
    public class ConnectionString
    {
        public static string login;

        public static string password;

        public string ConnectionStr
        {
            get
            {
                return new SqlConnectionStringBuilder()
                {
                    DataSource = "LAPTOP-5FC12NDF\\SQLEXPRESS",
                    InitialCatalog = "Personnel_Department_of_the_Institute",
                    UserID = login,
                    Password = password
                }.ConnectionString;
            }
        }
    }
}
