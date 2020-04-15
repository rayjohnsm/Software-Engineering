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
    public partial class User_Management : DevExpress.XtraEditors.XtraForm
    {
        Mysqlcon dao = new Mysqlcon();
        public User_Management()
        {
            InitializeComponent();
            sqlDataSource1.Fill();
        } 
        private void gridControl1_Click(object sender, EventArgs e)
        {
            tbid.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "user_id").ToString();
            fname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "user_fname").ToString();
            mname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "user_mname").ToString();
            lname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "user_lname").ToString();
            bdate.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "user_bdate").ToString();
            userrole.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "user_role").ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbE.Checked)
            {
                fname.ReadOnly = false;
                mname.ReadOnly = false;
                lname.ReadOnly = false;
                bdate.Enabled = true;
                userrole.Enabled = true;
                update.Enabled = true;
                delete.Enabled = true;
                disable.Enabled = true;
            }
            else {
                fname.ReadOnly = true;
                mname.ReadOnly = true;
                lname.ReadOnly = true;
                bdate.Enabled = false;
                userrole.Enabled = false;
                update.Enabled = false;
                delete.Enabled = false;
                disable.Enabled = false;
            
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            dao.deleteUser(tbid.Text);
            MessageBox.Show("Deleted Successfully");
            this.Close();
        }
    }
}