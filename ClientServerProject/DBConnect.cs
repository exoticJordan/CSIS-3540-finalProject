using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientServerProject
{
    class DBConnect
    {
        string HOST = "ec2-54-226-9-216.compute-1.amazonaws.com";
        string DB = "f2016_s1_user20";
        string UID = "f2016_s1_user20";
        string PASSWD = "f2016_s1_user20";

        public DBConnect()
        {
        }

        public override string ToString()
        {
            string connectionString;

            connectionString = "SERVER=" + HOST + ";DATABASE=" +
            DB + ";" + "UID=" + UID + ";" + "PASSWORD=" + PASSWD + ";";

            return connectionString;
        }

        public void fillCMD(string s, MySqlConnection c)
        {
          //  cmd.CommandText = s;
           // cmd.Connection = c;
        }
    }
}
