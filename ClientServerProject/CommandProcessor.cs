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

        public CommandProcessor()
        {
            cmd.Parameters.Add("@fname", MySqlDbType.String);
            cmd.Parameters.Add("@lname", MySqlDbType.String);
            cmd.Parameters.Add("@addr", MySqlDbType.String);
            cmd.Parameters.Add("@phone", MySqlDbType.String);
            cmd.Parameters.Add("@email", MySqlDbType.String);
            cmd.Parameters.Add("@dob", MySqlDbType.String);
            cmd.Parameters.Add("@gender", MySqlDbType.String);

            cmd.Parameters.Add("@cruise", MySqlDbType.String);
            cmd.Parameters.Add("@tvlr", MySqlDbType.String);
            cmd.Parameters.Add("@room", MySqlDbType.String);
        }

        public void insertRec(string query,List<string> values)
        {
            connection = dbc.connect(connection);
            fillCMD(query, connection);
            if (values.Count == 7)
            {
                cmd.Parameters["@fname"].Value = values[0];
                cmd.Parameters["@lname"].Value = values[1];
                cmd.Parameters["@addr"].Value = values[2];
                cmd.Parameters["@phone"].Value = values[3];
                cmd.Parameters["@email"].Value = values[4];
                cmd.Parameters["@dob"].Value = values[5];
                cmd.Parameters["@gender"].Value = values[6];
            }else if(values.Count == 3)
            {
                cmd.Parameters["@cruise"].Value = values[0];
                cmd.Parameters["@tvlr"].Value = values[1];
                cmd.Parameters["@room"].Value = values[2];
            }
            cmd.ExecuteNonQuery();
            connection.Close();
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
