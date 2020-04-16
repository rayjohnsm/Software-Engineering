using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using MySql.Data.MySqlClient;

namespace AISO_System
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        MySqlDataReader userdata;
        Mysqlcon dao = new Mysqlcon();

        public MainForm(MySqlDataReader data)
        {
                InitializeComponent();
                userdata = data;
                StartTimer();
                FormInitialization();
                dao.InsertLogs(userdata["user_id"].ToString());
        }
        System.Windows.Forms.Timer timer1 = null;
        private void FormInitialization()
        {
            if(userdata != null){
                defaultLookAndFeel.LookAndFeel.SkinName = userdata["user_style"].ToString();
                Properties.Settings.Default.LookAndFeel = userdata["user_style"].ToString();
                Properties.Settings.Default.Save();
                curUser.Caption = "Current User: " + userdata["user_fname"].ToString() + " " + userdata["user_lname"].ToString() + "";
                usertype.Caption = "User Type: " + userdata["user_role"].ToString() + " ";
            }else{
                defaultLookAndFeel.LookAndFeel.SkinName = "DevExpress Style";
                Properties.Settings.Default.LookAndFeel = "DevExpress Style";
                Properties.Settings.Default.Save();
            }  
        }
        private void StartTimer() {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtServerDateTime.Caption = "Server Date & Time: " + DateTime.Now.ToLongDateString() + " | " + DateTime.Now.ToLongTimeString();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            dao.UpdateMyStyle("DevExpress Style",userdata["user_id"].ToString());
            MessageBox.Show("Theme Changed Successfully!!");
            defaultLookAndFeel.LookAndFeel.SkinName = "DevExpress Style";
            Properties.Settings.Default.LookAndFeel = "DevExpress Style";
            Properties.Settings.Default.Save();
        }

        private void NightMode_ItemClick(object sender, ItemClickEventArgs e)
        {
            dao.UpdateMyStyle("DevExpress Dark Style", userdata["user_id"].ToString());
            MessageBox.Show("Theme Changed Successfully!!");
            defaultLookAndFeel.LookAndFeel.SkinName = "DevExpress Dark Style";
            Properties.Settings.Default.LookAndFeel = "DevExpress Dark Style";
            Properties.Settings.Default.Save();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            dao.UpdateMyStyle("Office 2010 Blue", userdata["user_id"].ToString());
            MessageBox.Show("Theme Changed Successfully!!");
            defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            Properties.Settings.Default.LookAndFeel = "Office 2010 Blue";
            Properties.Settings.Default.Save();
        }

        private void barButtonItem2_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            dao.UpdateMyStyle("Office 2010 Black", userdata["user_id"].ToString());
            MessageBox.Show("Theme Changed Successfully!!");
            defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Black";
            Properties.Settings.Default.LookAndFeel = "Office 2010 Black";
            Properties.Settings.Default.Save();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            dao.InsertLogOut(userdata["user_id"].ToString());
            this.Hide();
            Lock logout = new Lock();
            logout.ShowDialog();
        }

        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            newUser adduser = new newUser(userdata["user_id"].ToString());
            adduser.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            User_Management usermanage = new User_Management();
            usermanage.ShowDialog();
            
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserCharts chartuser = new UserCharts();
            chartuser.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewProduct newprod = new NewProduct();
            newprod.ShowDialog();
        }

        private void posNewTransact_ItemClick(object sender, ItemClickEventArgs e)
        {
            New_Transaction newtransact = new New_Transaction();
            newtransact.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Users_Logs logs = new Users_Logs();
            logs.ShowDialog();
        }
    }
}