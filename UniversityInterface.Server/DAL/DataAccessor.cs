using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityInterface.Server.Models;

namespace DAL {
    public abstract class DataAccessor {
        private String connection_string;
        private String table_name;
        public DataAccessor(String connection_string, String table_name) {
            this.connection_string = connection_string;
            this.table_name = table_name;

        }

        public List<List<String>> getData(List<String> fields) {
            Console.WriteLine(connection_string);
            List<User> users = new List<User>();

            List<List<String>> result = new List<List<String>>();
            using (var connection = new SqlConnection(connection_string))
            {
                connection.Open();

                var cmd = new SqlCommand("SELECT * FROM " + table_name, connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    List<String> record = new List<String>();
                    foreach (String field in fields) {
                        record.Add(reader[field].ToString());
                    }
                    result.Add(record);
                }
            }
            return result;

        }
    }
}
