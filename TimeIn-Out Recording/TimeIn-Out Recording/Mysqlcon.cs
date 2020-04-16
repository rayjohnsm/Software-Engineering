using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace TimeIn_Out_Recording
{
    public class Mysqlcon
    {
        public MySqlConnection getConnection()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;database=bisu_time_stamp;uid=root;pwd=03231979"))
            {
                try
                {
                    con.Open();
                    return con;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
