//GALAN CĂLIN SEBASTIAN, grupa 3123B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LoginSystem
{
    class DB
    {

        MySqlConnection connection = new MySqlConnection("server=localhost;port=3325;username=root;password=;database=proiectpiu");

        public void deschideConexiunea()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void inchideConexiunea()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConexiune()
        {
            return connection;
        }

    }
}
