using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace AISO_System
{
    public partial class Lock : DevExpress.XtraEditors.XtraForm
    {
        Mysqlcon cons = new Mysqlcon();

        public Lock()
        {
            InitializeComponent();
            lblInputStatus.Hide();
            testConnection();
        }
        private void lnkExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testConnection() {
            try{
                    MySqlConnection con = cons.getConnection();
                    textpassw.Properties.PasswordChar = '●';
                    btnshow.Text = "S";
                    labelcon.Text = "Connection Successful!!";
                    labelcon.ForeColor = System.Drawing.Color.Green;
                    con.Close();
                    simpleButton2.Enabled = true;
                    con.Close();
                }catch{
                    simpleButton2.Enabled = false;
             }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (btnshow.Text.Equals("S"))
            {
                textpassw.Properties.PasswordChar = '\0';
                btnshow.Text = "H";
            }
            else
            {
                textpassw.Properties.PasswordChar = '●';
                btnshow.Text = "S";
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
             try{
                 MySqlDataReader data = null;
                    data = cons.getThatLogin(textid.Text, textpassw.Text);
                    if (data!=null)
                    {
                        MessageBox.Show("Welcome "+data["user_fname"].ToString()+"!!!");
                        this.Hide();
                        MainForm mains = new MainForm(data);
                        mains.ShowDialog();
                    }
                    else
                    {
                        lblInputStatus.Show();
                    }
             }catch (Exception ex){
                 MessageBox.Show(ex.Message);
             }
        }
 
    }
}