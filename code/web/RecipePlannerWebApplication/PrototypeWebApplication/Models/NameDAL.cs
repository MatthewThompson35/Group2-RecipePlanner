namespace PrototypeWebApplication.Models
{
    using MySql.Data.MySqlClient;

    public class NameDAL
    {

        public List<String> getAllNames()
        {
            using var connection = new MySqlConnection(Connection.ConnectionString);
            connection.Open();
            var query = "Select * from names;";
            using var command = new MySqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            var names = new List<String>();
            while (reader.Read())
            {
                names.Add(reader.GetString(0));

            }

            return names;
        }
    }
}
