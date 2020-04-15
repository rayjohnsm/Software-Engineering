namespace AISO_System
{
    partial class Lock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lock));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblstat = new System.Windows.Forms.Label();
            this.labelcon = new System.Windows.Forms.Label();
            this.lnkExit = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblInputStatus = new System.Windows.Forms.Label();
            this.btnshow = new DevExpress.XtraEditors.SimpleButton();
            this.textpassw = new DevExpress.XtraEditors.TextEdit();
            this.textid = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textpassw.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identification Number *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password *";
            // 
            // lblstat
            // 
            this.lblstat.AutoSize = true;
            this.lblstat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstat.ForeColor = System.Drawing.Color.Red;
            this.lblstat.Location = new System.Drawing.Point(99, 220);
            this.lblstat.Name = "lblstat";
            this.lblstat.Size = new System.Drawing.Size(123, 16);
            this.lblstat.TabIndex = 6;
            this.lblstat.Text = "Invalid Password!";
            // 
            // labelcon
            // 
            this.labelcon.AutoSize = true;
            this.labelcon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcon.ForeColor = System.Drawing.Color.Red;
            this.labelcon.Location = new System.Drawing.Point(14, 284);
            this.labelcon.Name = "labelcon";
            this.labelcon.Size = new System.Drawing.Size(108, 14);
            this.labelcon.TabIndex = 8;
            this.labelcon.Text = "No Connection !!!!";
            // 
            // lnkExit
            // 
            this.lnkExit.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkExit.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lnkExit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lnkExit.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lnkExit.Location = new System.Drawing.Point(238, 336);
            this.lnkExit.Name = "lnkExit";
            this.lnkExit.Size = new System.Drawing.Size(73, 15);
            this.lnkExit.TabIndex = 200;
            this.lnkExit.Text = "Exit Program";
            this.lnkExit.Click += new System.EventHandler(this.lnkExit_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblInputStatus);
            this.panelControl1.Controls.Add(this.btnshow);
            this.panelControl1.Controls.Add(this.textpassw);
            this.panelControl1.Controls.Add(this.textid);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Location = new System.Drawing.Point(1, 128);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(324, 138);
            this.panelControl1.TabIndex = 202;
            // 
            // lblInputStatus
            // 
            this.lblInputStatus.AutoSize = true;
            this.lblInputStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputStatus.ForeColor = System.Drawing.Color.Red;
            this.lblInputStatus.Location = new System.Drawing.Point(118, 108);
            this.lblInputStatus.Name = "lblInputStatus";
            this.lblInputStatus.Size = new System.Drawing.Size(112, 14);
            this.lblInputStatus.TabIndex = 204;
            this.lblInputStatus.Text = "Invalid Credentials!!";
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(278, 80);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(32, 23);
            this.btnshow.TabIndex = 8;
            this.btnshow.Text = "H";
            this.btnshow.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textpassw
            // 
            this.textpassw.Location = new System.Drawing.Point(16, 82);
            this.textpassw.Name = "textpassw";
            this.textpassw.Size = new System.Drawing.Size(262, 20);
            this.textpassw.TabIndex = 7;
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(16, 42);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(294, 20);
            this.textid.TabIndex = 6;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(17, 301);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(294, 29);
            this.simpleButton2.TabIndex = 203;
            this.simpleButton2.Text = "LOGIN";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(225, 284);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 14);
            this.labelControl1.TabIndex = 204;
            this.labelControl1.Text = "Fix Connection";
            this.labelControl1.UseMnemonic = false;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::AISO_System.Properties.Resources.barcodescanning;
            this.pictureEdit1.Location = new System.Drawing.Point(1, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(324, 128);
            this.pictureEdit1.TabIndex = 7;
            // 
            // Lock
            // 
            this.AcceptButton = this.simpleButton2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(330, 363);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.lnkExit);
            this.Controls.Add(this.labelcon);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lblstat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.Name = "Lock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lock";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textpassw.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblstat;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label labelcon;
        private DevExpress.XtraEditors.LabelControl lnkExit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnshow;
        private DevExpress.XtraEditors.TextEdit textpassw;
        private DevExpress.XtraEditors.TextEdit textid;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label lblInputStatus;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}