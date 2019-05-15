using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class TestConnectionRepository
    {

        public bool IsSqlConnectionOk()
        {
            using (SqlConnection connection = new SqlConnection(Route.CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine($"Exception occured: \n {ex}");
                    return false;
                }
            }
        }
    }
}
