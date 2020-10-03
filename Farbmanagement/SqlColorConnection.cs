using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Farbmanagement
{
    public class SqlColorConnection
    {

        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        
        public SqlColorConnection()
        {
            server = "rdbms.strato.de";
            database = "Mitarbeiter";
            uid = "U4296652";
            password = "TNRH_2020!";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);

        }
        public void GetLackierStufen()
        {
            connection.Open();

        }

    }
}
