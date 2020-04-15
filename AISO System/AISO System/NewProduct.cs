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
    public partial class NewProduct : DevExpress.XtraEditors.XtraForm
    {
        Mysqlcon dao = new Mysqlcon();
        public NewProduct()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e){
            if (cbcode.Checked) {
                tbpcode.Enabled = false;
            
            }
            if (tbpcode.Text != ""){

            }else{
                MessageBox.Show("Please don't leave Firstname Blank");
            }
            //dao.AddProduct();
            //SELECT * FROM `aiso_codegen` order by code_id desc limit 1
        }
    }
}