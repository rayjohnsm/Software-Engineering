namespace AISO_System
{
    partial class User_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Management));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.delete = new System.Windows.Forms.Button();
            this.disable = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.cbE = new System.Windows.Forms.CheckBox();
            this.bdate = new System.Windows.Forms.DateTimePicker();
            this.lname = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.userrole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coluser_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_fname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_lname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_mname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_bdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_role = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_passw = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_style = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_whoAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.delete);
            this.panelControl1.Controls.Add(this.disable);
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Controls.Add(this.update);
            this.panelControl1.Controls.Add(this.cbE);
            this.panelControl1.Controls.Add(this.bdate);
            this.panelControl1.Controls.Add(this.lname);
            this.panelControl1.Controls.Add(this.mname);
            this.panelControl1.Controls.Add(this.fname);
            this.panelControl1.Controls.Add(this.tbid);
            this.panelControl1.Controls.Add(this.userrole);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(316, 381);
            this.panelControl1.TabIndex = 1;
            // 
            // delete
            // 
            this.delete.Enabled = false;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Location = new System.Drawing.Point(228, 252);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(50, 48);
            this.delete.TabIndex = 39;
            this.delete.Tag = "Delete User";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // disable
            // 
            this.disable.Enabled = false;
            this.disable.Image = ((System.Drawing.Image)(resources.GetObject("disable.Image")));
            this.disable.Location = new System.Drawing.Point(170, 252);
            this.disable.Name = "disable";
            this.disable.Size = new System.Drawing.Size(53, 48);
            this.disable.TabIndex = 38;
            this.disable.Tag = "Disable User";
            this.disable.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(106, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 48);
            this.button2.TabIndex = 37;
            this.button2.Tag = "Reset Password";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Enabled = false;
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.Location = new System.Drawing.Point(50, 252);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(52, 48);
            this.update.TabIndex = 36;
            this.update.Tag = "";
            this.update.UseVisualStyleBackColor = true;
            // 
            // cbE
            // 
            this.cbE.AutoSize = true;
            this.cbE.Location = new System.Drawing.Point(72, 218);
            this.cbE.Name = "cbE";
            this.cbE.Size = new System.Drawing.Size(191, 17);
            this.cbE.TabIndex = 35;
            this.cbE.Text = "Enable editing to Update user Info";
            this.cbE.UseVisualStyleBackColor = true;
            this.cbE.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bdate
            // 
            this.bdate.Enabled = false;
            this.bdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdate.Location = new System.Drawing.Point(90, 160);
            this.bdate.MaxDate = new System.DateTime(2200, 1, 1, 0, 0, 0, 0);
            this.bdate.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(186, 22);
            this.bdate.TabIndex = 33;
            this.bdate.Value = new System.DateTime(2020, 4, 3, 10, 42, 20, 0);
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(90, 127);
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            this.lname.Size = new System.Drawing.Size(186, 21);
            this.lname.TabIndex = 32;
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(89, 97);
            this.mname.Name = "mname";
            this.mname.ReadOnly = true;
            this.mname.Size = new System.Drawing.Size(186, 21);
            this.mname.TabIndex = 31;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(89, 69);
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Size = new System.Drawing.Size(186, 21);
            this.fname.TabIndex = 30;
            // 
            // tbid
            // 
            this.tbid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbid.Location = new System.Drawing.Point(88, 39);
            this.tbid.Name = "tbid";
            this.tbid.ReadOnly = true;
            this.tbid.Size = new System.Drawing.Size(186, 21);
            this.tbid.TabIndex = 29;
            this.tbid.Text = "Auto Generated...";
            // 
            // userrole
            // 
            this.userrole.Enabled = false;
            this.userrole.FormattingEnabled = true;
            this.userrole.Items.AddRange(new object[] {
            "----",
            "Administrator",
            "Encoder",
            "Cashier"});
            this.userrole.Location = new System.Drawing.Point(90, 190);
            this.userrole.Name = "userrole";
            this.userrole.Size = new System.Drawing.Size(187, 21);
            this.userrole.TabIndex = 28;
            this.userrole.Text = "----";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "User Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Birthdate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Middle Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "User Form";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "CustomSqlQuery";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(324, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(580, 381);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_aisoConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "CustomSqlQuery";
            customSqlQuery1.Sql = "SELECT * FROM `aiso_users`";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coluser_id,
            this.coluser_fname,
            this.coluser_lname,
            this.coluser_mname,
            this.coluser_bdate,
            this.coluser_role,
            this.coluser_passw,
            this.coluser_style,
            this.coluser_whoAdd});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // coluser_id
            // 
            this.coluser_id.Caption = "User ID";
            this.coluser_id.FieldName = "user_id";
            this.coluser_id.Name = "coluser_id";
            this.coluser_id.OptionsColumn.ReadOnly = true;
            this.coluser_id.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.coluser_id.Visible = true;
            this.coluser_id.VisibleIndex = 0;
            this.coluser_id.Width = 84;
            // 
            // coluser_fname
            // 
            this.coluser_fname.Caption = "First Name";
            this.coluser_fname.FieldName = "user_fname";
            this.coluser_fname.Name = "coluser_fname";
            this.coluser_fname.Visible = true;
            this.coluser_fname.VisibleIndex = 1;
            this.coluser_fname.Width = 118;
            // 
            // coluser_lname
            // 
            this.coluser_lname.FieldName = "user_lname";
            this.coluser_lname.Name = "coluser_lname";
            this.coluser_lname.Visible = true;
            this.coluser_lname.VisibleIndex = 2;
            this.coluser_lname.Width = 118;
            // 
            // coluser_mname
            // 
            this.coluser_mname.FieldName = "user_mname";
            this.coluser_mname.Name = "coluser_mname";
            this.coluser_mname.Visible = true;
            this.coluser_mname.VisibleIndex = 3;
            this.coluser_mname.Width = 118;
            // 
            // coluser_bdate
            // 
            this.coluser_bdate.FieldName = "user_bdate";
            this.coluser_bdate.Name = "coluser_bdate";
            // 
            // coluser_role
            // 
            this.coluser_role.Caption = "System Role";
            this.coluser_role.FieldName = "user_role";
            this.coluser_role.Name = "coluser_role";
            this.coluser_role.Visible = true;
            this.coluser_role.VisibleIndex = 4;
            this.coluser_role.Width = 124;
            // 
            // coluser_passw
            // 
            this.coluser_passw.FieldName = "user_passw";
            this.coluser_passw.Name = "coluser_passw";
            // 
            // coluser_style
            // 
            this.coluser_style.FieldName = "user_style";
            this.coluser_style.Name = "coluser_style";
            // 
            // coluser_whoAdd
            // 
            this.coluser_whoAdd.FieldName = "user_whoAdd";
            this.coluser_whoAdd.Name = "coluser_whoAdd";
            // 
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 385);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "User_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Management";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_id;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_fname;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_lname;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_mname;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_bdate;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_role;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_passw;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_style;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_whoAdd;
        private System.Windows.Forms.DateTimePicker bdate;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.ComboBox userrole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbE;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button disable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button update;
    }
}