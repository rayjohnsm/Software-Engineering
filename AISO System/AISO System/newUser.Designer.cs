namespace AISO_System
{
    partial class newUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbUA = new System.Windows.Forms.CheckBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.passwd = new System.Windows.Forms.TextBox();
            this.bdate = new System.Windows.Forms.DateTimePicker();
            this.lname = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userrole = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.Controls.Add(this.cbUA);
            this.panelControl1.Controls.Add(this.clearbtn);
            this.panelControl1.Controls.Add(this.passwd);
            this.panelControl1.Controls.Add(this.bdate);
            this.panelControl1.Controls.Add(this.lname);
            this.panelControl1.Controls.Add(this.mname);
            this.panelControl1.Controls.Add(this.fname);
            this.panelControl1.Controls.Add(this.textBox1);
            this.panelControl1.Controls.Add(this.userrole);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.addbtn);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(312, 318);
            this.panelControl1.TabIndex = 1;
            // 
            // cbUA
            // 
            this.cbUA.AutoSize = true;
            this.cbUA.Location = new System.Drawing.Point(27, 254);
            this.cbUA.Name = "cbUA";
            this.cbUA.Size = new System.Drawing.Size(104, 17);
            this.cbUA.TabIndex = 18;
            this.cbUA.Text = "User Agreement";
            this.cbUA.UseVisualStyleBackColor = true;
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.White;
            this.clearbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.Black;
            this.clearbtn.Image = global::AISO_System.Properties.Resources.Cancel_16x16;
            this.clearbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearbtn.Location = new System.Drawing.Point(185, 277);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearbtn.Size = new System.Drawing.Size(115, 30);
            this.clearbtn.TabIndex = 17;
            this.clearbtn.Text = "Clear / Discard";
            this.clearbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // passwd
            // 
            this.passwd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwd.Location = new System.Drawing.Point(98, 217);
            this.passwd.Name = "passwd";
            this.passwd.ReadOnly = true;
            this.passwd.Size = new System.Drawing.Size(164, 21);
            this.passwd.TabIndex = 16;
            this.passwd.Text = "Password";
            // 
            // bdate
            // 
            this.bdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdate.Location = new System.Drawing.Point(76, 156);
            this.bdate.MaxDate = new System.DateTime(2200, 1, 1, 0, 0, 0, 0);
            this.bdate.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(186, 22);
            this.bdate.TabIndex = 15;
            this.bdate.Value = new System.DateTime(2020, 4, 3, 10, 42, 20, 0);
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(76, 123);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(186, 21);
            this.lname.TabIndex = 14;
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(76, 93);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(186, 21);
            this.mname.TabIndex = 13;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(76, 65);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(186, 21);
            this.fname.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(76, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(186, 21);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Auto Generated...";
            // 
            // userrole
            // 
            this.userrole.FormattingEnabled = true;
            this.userrole.Items.AddRange(new object[] {
            "----",
            "Administrator",
            "Encoder",
            "Cashier"});
            this.userrole.Location = new System.Drawing.Point(75, 186);
            this.userrole.Name = "userrole";
            this.userrole.Size = new System.Drawing.Size(187, 21);
            this.userrole.TabIndex = 10;
            this.userrole.Text = "----";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "User Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "User Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Birthdate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Middle Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add User Form";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.White;
            this.addbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.Black;
            this.addbtn.Image = global::AISO_System.Properties.Resources.Add_16x16;
            this.addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbtn.Location = new System.Drawing.Point(27, 277);
            this.addbtn.Name = "addbtn";
            this.addbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addbtn.Size = new System.Drawing.Size(88, 30);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "Add User";
            this.addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // newUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 318);
            this.Controls.Add(this.panelControl1);
            this.Name = "newUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User Form";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DateTimePicker bdate;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox userrole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.CheckBox cbUA;
        private System.Windows.Forms.Button clearbtn;
    }
}