using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientServerProject
{
    class CommandProcessor
    {
        DBConnect dbc = new DBConnect();
        MySqlConnection connection;
        MySqlCommand cmd = new MySqlCommand();

        public void insertRec(string query,List<string> values)
        {
            dbc.connect(connection);
            fillCMD(query, connection);
            if (values.Count == 7)
            {
                cmd.Parameters.AddWithValue("@fname", values[0]);
                cmd.Parameters.AddWithValue("@lname", values[1]);
                cmd.Parameters.AddWithValue("@addr", values[2]);
                cmd.Parameters.AddWithValue("@phone", values[3]);
                cmd.Parameters.AddWithValue("@email", values[4]);
                cmd.Parameters.AddWithValue("@dob", values[5]);
                cmd.Parameters.AddWithValue("@gender", values[6]);
            }else if(values.Count == 3)
            {
                cmd.Parameters.AddWithValue("@cruise", values[0]);
                cmd.Parameters.AddWithValue("@tvlr", values[1]);
                cmd.Parameters.AddWithValue("@room", values[2]);
            }
            cmd.ExecuteNonQuery();
        }
        public void updateRec(string query, MySqlConnection c)
        {
            connection = c;
            fillCMD(query, connection);
            cmd.ExecuteNonQuery();
        }
        public void fillCMD(string s, MySqlConnection c)
        {
            cmd.CommandText = s;
            cmd.Connection = c;
        }
    }
}
