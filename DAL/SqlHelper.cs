using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class SqlHelper
    {

        public static string globeSqlConnString = @"Database='dreamsmart';Data Source='localhost';User Id='root';Password='123456';charset='utf8'";

        public MySqlConnection _conn = null;

        public MySqlCommand _comm = null;

        public MySqlDataReader _reader = null;

        public MySqlDataAdapter _adapter = null;

        public SqlHelper(string connstring)
        {
            _conn = new MySqlConnection(connstring);
            _comm = new MySqlCommand("", _conn);
            _adapter = new MySqlDataAdapter("", _conn);
        }

        public void OpenConn()
        {
            _conn.Open();
        }
      
        public void CloseConn()
        {
            _conn.Close();
        }

    }
}
