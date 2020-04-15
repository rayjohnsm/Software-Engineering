using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AISO_System
{
    public partial class newUser : DevExpress.XtraEditors.XtraForm
    {
        Mysqlcon con = new Mysqlcon();
        string add;
        public newUser(string added)
        {
            add = added;
            InitializeComponent();
        }
        
        int signin = DateTime.Now.Year;
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (fname.Text != "")
            {
                if (mname.Text != "")
                {
                    if (lname.Text != "")
                    {
                        int byear = bdate.Value.Year;
                        if ((signin - byear) >= 18)
                        {
                            if (userrole.Text != "----")
                            {
                                if (cbUA.Checked)
                                {
                                    try
                                    {
                                        con.AddUser(fname.Text, lname.Text, mname.Text, bdate.Text, userrole.Text, passwd.Text, add);
                                        reset();
                                        MessageBox.Show("User Added Successfully!!");
                                        this.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }else {
                                    MessageBox.Show("Be sure to checked the Agreement");
                                }
                            }else{
                                MessageBox.Show("Please Select User Role");
                           }
                        }else{
                            MessageBox.Show("Be sure you are 18 above");
                        }
                    }else{
                        MessageBox.Show("Please don't leave Lastname Blank");
                    }
                }else{
                    MessageBox.Show("Please don't leave Middlename Blank");
                }
            }else{
                MessageBox.Show("Please don't leave Firstname Blank");
            }
        }
        public void reset() {
            fname.ResetText();
            lname.ResetText();
            mname.ResetText();
            bdate.ResetText();
            userrole.ResetText();
            cbUA.Checked = false;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}