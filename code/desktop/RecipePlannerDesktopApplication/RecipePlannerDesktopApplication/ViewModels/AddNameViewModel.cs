using MySqlConnector;
using RecipePlannerDesktopApplication.Connections;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipePlannerDesktopApplication.ViewModels
{
    public class AddNameViewModel
    {
        /// <summary>
        ///     Adds a name.
        /// </summary>
        /// <param name="name"></param>
        public void AddName(string name)
        {
            using (MySqlConnection sqlConn = new MySqlConnection(Connection.ConnectionString))
            {
                sqlConn.Open();

                string query = "insert into names values(@Name);";
                var command = new MySqlCommand(query, sqlConn);

                command.Parameters.AddWithValue("@Name", name);

                command.ExecuteNonQuery();
            }
        }
    }
}
