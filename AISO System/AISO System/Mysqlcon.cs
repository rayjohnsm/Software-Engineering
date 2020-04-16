using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace AISO_System
{
    public class Mysqlcon
    {
        public MySqlConnection getConnection()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;database=aiso;uid=aiso;pwd=aiso123"))
            {
                try
                {
                    con.Open();
                    return con;
                }
                catch {
                    return null;
                }
            }
        }
        public MySqlDataReader getThatLogin(string id, string passw){
            using (getConnection()){
                try{
                    MySqlConnection con = getConnection();
                    String querry = "SELECT *  FROM `aiso_users` WHERE `user_id` = "+id+" AND `user_passw` = '"+passw+"'";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(querry, con);
                    MySqlDataReader read = null;
                    read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        return read;
                    }else {
                        return null;
                    }
                    
                }catch(Exception ex){
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public void InsertLogs(string id)
        {
            using (getConnection())
            {
                try
                {
                    MySqlConnection con = getConnection();
                    String querry = "INSERT INTO `aiso`.`aiso_users_logs` (`user_id`, `user_log_inDate`) VALUES ('"+id+"', now())";
                    MySqlCommand cmd = new MySqlCommand(querry, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    getConnection().Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void InsertLogOut(string id)
        {
            using (getConnection())
            {
                try
                {
                    MySqlConnection con = getConnection();
                    String querry = "UPDATE `aiso`.`aiso_users_logs` SET `user_log_outDate` = 'now()' WHERE `aiso_users_logs`.`user_log_id` ="+id+";";
                    MySqlCommand cmd = new MySqlCommand(querry, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    getConnection().Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void UpdateMyStyle(string Style, string id)
        {
            using (getConnection())
            {
                try
                {
                    MySqlConnection con = getConnection();
                    String querry = "UPDATE `aiso`.`aiso_users` SET `user_style` = '"+Style+"' WHERE `aiso_users`.`user_id` ="+id+";";
                    MySqlCommand cmd = new MySqlCommand(querry, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void AddUser(string fname, string mname, string lname, string bdate, string user_role, string pass,string added )
        {
            using (getConnection())
            {
                try
                {
                    MySqlConnection con = getConnection();
                    String querry = "INSERT INTO `aiso`.`aiso_users` (`user_fname`, `user_lname`, `user_mname`, `user_bdate`, `user_role`, `user_passw`, `user_style`, `user_whoAdd`) VALUES ('" + fname + "', '" + lname + "', '" + mname + "', '" + bdate + "', '" + user_role + "', '" + pass + "', 'DevExpress Style', '" + added + "');";
                    MySqlCommand cmd = new MySqlCommand(querry, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    getConnection().Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public MySqlDataReader getAllUser(){
                try{
                    String querry = "SELECT *  FROM `aiso_users`";
                    MySqlCommand cmd = new MySqlCommand(querry, getConnection());
                    MySqlDataReader read = null;
                    getConnection().Open();
                    read = cmd.ExecuteReader();   
                    return read;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            
        }
        public void deleteUser(string id)
        {
            using (getConnection())
            {
                try
                {
                    MySqlConnection con = getConnection();
                    String querry = "DELETE from aiso_users where user_id="+id+"";
                    MySqlCommand cmd = new MySqlCommand(querry, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void AddProduct(string code, string name, string color, string quan, string size, string price, string whoadded)
        {
            using (getConnection())
            {
                try
                {
                    MySqlConnection con = getConnection();
                    String querry = "INSERT INTO `aiso`.`aiso_products` (`prod_code`, `prod_barcode`, `prod_name`, `prod_color`, `prod_quantity`, `prod_size`, `prod_price`, `prod_whoAdded`) VALUES (NULL, '" + code + "', '" + name + "', '" + color + "', '" + quan + "', '" + size + "', '" + price + "', '" + 132133 + "');";
                    MySqlCommand cmd = new MySqlCommand(querry, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
