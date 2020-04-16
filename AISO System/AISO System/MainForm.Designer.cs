namespace AISO_System
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.LogOut = new DevExpress.XtraBars.BarButtonItem();
            this.txtServerDateTime = new DevExpress.XtraBars.BarStaticItem();
            this.posNewTransact = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.devExpress = new DevExpress.XtraBars.BarButtonItem();
            this.NightMode = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.curUser = new DevExpress.XtraBars.BarButtonItem();
            this.usertype = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgPointOfSale = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgInventory = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.LogOut,
            this.txtServerDateTime,
            this.posNewTransact,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barSubItem1,
            this.devExpress,
            this.NightMode,
            this.barButtonItem9,
            this.barButtonItem2,
            this.barButtonItem8,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.curUser,
            this.usertype,
            this.barButtonItem3});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 34;
            this.ribbon.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barSubItem1);
            this.ribbon.PageHeaderItemLinks.Add(this.LogOut);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbon.Size = new System.Drawing.Size(711, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Glyph = global::AISO_System.Properties.Resources.refresh_16x16;
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.LargeGlyph = global::AISO_System.Properties.Resources.refresh_32x32;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // LogOut
            // 
            this.LogOut.Caption = "LogOut";
            this.LogOut.Glyph = ((System.Drawing.Image)(resources.GetObject("LogOut.Glyph")));
            this.LogOut.Id = 4;
            this.LogOut.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("LogOut.LargeGlyph")));
            this.LogOut.Name = "LogOut";
            this.LogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // txtServerDateTime
            // 
            this.txtServerDateTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txtServerDateTime.Caption = "Server Date and Time: date_time";
            this.txtServerDateTime.Glyph = ((System.Drawing.Image)(resources.GetObject("txtServerDateTime.Glyph")));
            this.txtServerDateTime.Id = 5;
            this.txtServerDateTime.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("txtServerDateTime.LargeGlyph")));
            this.txtServerDateTime.Name = "txtServerDateTime";
            this.txtServerDateTime.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // posNewTransact
            // 
            this.posNewTransact.Caption = "New Transaction";
            this.posNewTransact.Glyph = ((System.Drawing.Image)(resources.GetObject("posNewTransact.Glyph")));
            this.posNewTransact.Id = 6;
            this.posNewTransact.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("posNewTransact.LargeGlyph")));
            this.posNewTransact.Name = "posNewTransact";
            this.posNewTransact.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.posNewTransact_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "New Product";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Orders";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 8;
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Frequency of Sales";
            this.barButtonItem6.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.Glyph")));
            this.barButtonItem6.Id = 9;
            this.barButtonItem6.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.LargeGlyph")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "List of Receipt";
            this.barButtonItem7.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.Glyph")));
            this.barButtonItem7.Id = 10;
            this.barButtonItem7.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.LargeGlyph")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Theme";
            this.barSubItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubItem1.Glyph")));
            this.barSubItem1.Id = 17;
            this.barSubItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSubItem1.LargeGlyph")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.devExpress),
            new DevExpress.XtraBars.LinkPersistInfo(this.NightMode),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // devExpress
            // 
            this.devExpress.Caption = "DevExpress Style";
            this.devExpress.Glyph = ((System.Drawing.Image)(resources.GetObject("devExpress.Glyph")));
            this.devExpress.Id = 18;
            this.devExpress.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("devExpress.LargeGlyph")));
            this.devExpress.Name = "devExpress";
            this.devExpress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_1);
            // 
            // NightMode
            // 
            this.NightMode.Caption = "DevExpress Dark Style";
            this.NightMode.Glyph = ((System.Drawing.Image)(resources.GetObject("NightMode.Glyph")));
            this.NightMode.Id = 19;
            this.NightMode.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("NightMode.LargeGlyph")));
            this.NightMode.Name = "NightMode";
            this.NightMode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NightMode_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Office 2010 Blue";
            this.barButtonItem9.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.Glyph")));
            this.barButtonItem9.Id = 20;
            this.barButtonItem9.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.LargeGlyphDisabled")));
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Office 2010 Black";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 21;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_2);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Users Management";
            this.barButtonItem8.Glyph = global::AISO_System.Properties.Resources.usergroup_16x16;
            this.barButtonItem8.Id = 22;
            this.barButtonItem8.LargeGlyph = global::AISO_System.Properties.Resources.usergroup_32x32;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Users Logs";
            this.barButtonItem10.Glyph = global::AISO_System.Properties.Resources.findcustomers_16x16;
            this.barButtonItem10.Id = 23;
            this.barButtonItem10.LargeGlyph = global::AISO_System.Properties.Resources.findcustomers_32x32;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Classification of Users";
            this.barButtonItem11.Glyph = global::AISO_System.Properties.Resources.fullstackedbar_16x16;
            this.barButtonItem11.Id = 24;
            this.barButtonItem11.LargeGlyph = global::AISO_System.Properties.Resources.fullstackedbar_32x32;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Help";
            this.barButtonItem12.Glyph = global::AISO_System.Properties.Resources.index_16x16;
            this.barButtonItem12.Id = 25;
            this.barButtonItem12.LargeGlyph = global::AISO_System.Properties.Resources.index_32x32;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "About";
            this.barButtonItem13.Glyph = global::AISO_System.Properties.Resources.info_16x16;
            this.barButtonItem13.Id = 30;
            this.barButtonItem13.LargeGlyph = global::AISO_System.Properties.Resources.info_32x32;
            this.barButtonItem13.Name = "barButtonItem13";
            this.barButtonItem13.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick);
            // 
            // curUser
            // 
            this.curUser.Caption = "Current User:";
            this.curUser.Glyph = global::AISO_System.Properties.Resources.customer_16x16;
            this.curUser.Id = 31;
            this.curUser.LargeGlyph = global::AISO_System.Properties.Resources.customer_32x32;
            this.curUser.Name = "curUser";
            // 
            // usertype
            // 
            this.usertype.Caption = "User Type:";
            this.usertype.Glyph = global::AISO_System.Properties.Resources.publicfix_16x16;
            this.usertype.Id = 32;
            this.usertype.LargeGlyph = global::AISO_System.Properties.Resources.publicfix_32x32;
            this.usertype.Name = "usertype";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "New User";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 33;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick_1);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgPointOfSale,
            this.rpgInventory,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Transactions";
            // 
            // rpgPointOfSale
            // 
            this.rpgPointOfSale.ItemLinks.Add(this.posNewTransact);
            this.rpgPointOfSale.ItemLinks.Add(this.barButtonItem7);
            this.rpgPointOfSale.Name = "rpgPointOfSale";
            this.rpgPointOfSale.ShowCaptionButton = false;
            this.rpgPointOfSale.Text = "Point Of Sale";
            // 
            // rpgInventory
            // 
            this.rpgInventory.ItemLinks.Add(this.barButtonItem4);
            this.rpgInventory.ItemLinks.Add(this.barButtonItem5);
            this.rpgInventory.ItemLinks.Add(this.barButtonItem6);
            this.rpgInventory.Name = "rpgInventory";
            this.rpgInventory.ShowCaptionButton = false;
            this.rpgInventory.Text = "Inventory";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Users";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem13);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Help";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Settings";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.txtServerDateTime);
            this.ribbonStatusBar.ItemLinks.Add(this.curUser);
            this.ribbonStatusBar.ItemLinks.Add(this.usertype);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 359);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(711, 31);
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 390);
            this.ControlBox = false;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "AISO Inventory and Database Storing System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPointOfSale;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem LogOut;
        private DevExpress.XtraBars.BarStaticItem txtServerDateTime;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem posNewTransact;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgInventory;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem devExpress;
        private DevExpress.XtraBars.BarButtonItem NightMode;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem curUser;
        private DevExpress.XtraBars.BarButtonItem usertype;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}