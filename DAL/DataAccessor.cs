using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public abstract class DataAccessor {
        private String connection_string;
        private String table_name;
        public DataAccessor(String connection_string, String table_name) {
            this.connection_string = connection_string;
            this.table_name = table_name;

        }

        public SqlDataReader getReader() {
            using (var connection = new SqlConnection(connection_string)) {
                connection.Open();

                var cmd = new SqlCommand("SELECT * FROM " + table_name, connection);

                return cmd.ExecuteReader();
            }
        }
    }
}
