﻿using MySqlConnector;

namespace PrototypeWebApplication.Models
{
    public class NamesContext
    {
        public string ConnectionString { get; set; }

        public NamesContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Names> GetAllNames()
        {
            List<Names> list = new List<Names>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from names", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Names()
                        {
                            Name = reader["Name"].ToString(),
                        });
                    }
                }
            }
            return list;
        }
    }
}