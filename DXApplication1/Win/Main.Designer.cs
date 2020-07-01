namespace Win
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnSales = new DevExpress.XtraEditors.SimpleButton();
            this.btnCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.btnCategories = new DevExpress.XtraEditors.SimpleButton();
            this.btnInventory = new DevExpress.XtraEditors.SimpleButton();
            this.btnItems = new DevExpress.XtraEditors.SimpleButton();
            this.btnDashboard = new DevExpress.XtraEditors.SimpleButton();
            this.btnMaintenance = new DevExpress.XtraEditors.SimpleButton();
            this.btnSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(240, 59);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1044, 502);
            this.pnlBody.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 59);
            this.panel1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(384, 32);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Build Haus Center Inventory System";
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlSideBar.Controls.Add(this.btnMaintenance);
            this.pnlSideBar.Controls.Add(this.btnSales);
            this.pnlSideBar.Controls.Add(this.btnCustomer);
            this.pnlSideBar.Controls.Add(this.btnSupplier);
            this.pnlSideBar.Controls.Add(this.btnCategories);
            this.pnlSideBar.Controls.Add(this.btnInventory);
            this.pnlSideBar.Controls.Add(this.btnItems);
            this.pnlSideBar.Controls.Add(this.btnDashboard);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.ForeColor = System.Drawing.Color.White;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 59);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(240, 502);
            this.pnlSideBar.TabIndex = 0;
            // 
            // btnSales
            // 
            this.btnSales.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSales.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSales.Appearance.Options.UseBackColor = true;
            this.btnSales.Appearance.Options.UseBorderColor = true;
            this.btnSales.Appearance.Options.UseFont = true;
            this.btnSales.Appearance.Options.UseForeColor = true;
            this.btnSales.Appearance.Options.UseTextOptions = true;
            this.btnSales.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSales.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.ImageOptions.Image")));
            this.btnSales.Location = new System.Drawing.Point(0, 318);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(240, 53);
            this.btnSales.TabIndex = 5;
            this.btnSales.Text = "Sales";
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnCustomer.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Appearance.Options.UseBackColor = true;
            this.btnCustomer.Appearance.Options.UseBorderColor = true;
            this.btnCustomer.Appearance.Options.UseFont = true;
            this.btnCustomer.Appearance.Options.UseForeColor = true;
            this.btnCustomer.Appearance.Options.UseTextOptions = true;
            this.btnCustomer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnCustomer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.ImageOptions.Image")));
            this.btnCustomer.Location = new System.Drawing.Point(0, 265);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(240, 53);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnCategories.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Appearance.Options.UseBackColor = true;
            this.btnCategories.Appearance.Options.UseBorderColor = true;
            this.btnCategories.Appearance.Options.UseFont = true;
            this.btnCategories.Appearance.Options.UseForeColor = true;
            this.btnCategories.Appearance.Options.UseTextOptions = true;
            this.btnCategories.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnCategories.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategories.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCategories.ImageOptions.Image")));
            this.btnCategories.Location = new System.Drawing.Point(0, 159);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(240, 53);
            this.btnCategories.TabIndex = 2;
            this.btnCategories.Text = "Category";
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnInventory.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Appearance.Options.UseBackColor = true;
            this.btnInventory.Appearance.Options.UseBorderColor = true;
            this.btnInventory.Appearance.Options.UseFont = true;
            this.btnInventory.Appearance.Options.UseForeColor = true;
            this.btnInventory.Appearance.Options.UseTextOptions = true;
            this.btnInventory.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnInventory.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.ImageOptions.Image")));
            this.btnInventory.Location = new System.Drawing.Point(0, 106);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(240, 53);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnItems
            // 
            this.btnItems.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnItems.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnItems.Appearance.Options.UseBackColor = true;
            this.btnItems.Appearance.Options.UseBorderColor = true;
            this.btnItems.Appearance.Options.UseFont = true;
            this.btnItems.Appearance.Options.UseForeColor = true;
            this.btnItems.Appearance.Options.UseTextOptions = true;
            this.btnItems.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnItems.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItems.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItems.ImageOptions.Image")));
            this.btnItems.Location = new System.Drawing.Point(0, 53);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(240, 53);
            this.btnItems.TabIndex = 0;
            this.btnItems.Text = "Items";
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnDashboard.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Appearance.Options.UseBackColor = true;
            this.btnDashboard.Appearance.Options.UseBorderColor = true;
            this.btnDashboard.Appearance.Options.UseFont = true;
            this.btnDashboard.Appearance.Options.UseForeColor = true;
            this.btnDashboard.Appearance.Options.UseTextOptions = true;
            this.btnDashboard.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnDashboard.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.ImageOptions.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(240, 53);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnMaintenance.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Appearance.Options.UseBackColor = true;
            this.btnMaintenance.Appearance.Options.UseBorderColor = true;
            this.btnMaintenance.Appearance.Options.UseFont = true;
            this.btnMaintenance.Appearance.Options.UseForeColor = true;
            this.btnMaintenance.Appearance.Options.UseTextOptions = true;
            this.btnMaintenance.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnMaintenance.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintenance.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnMaintenance.Location = new System.Drawing.Point(0, 371);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(240, 53);
            this.btnMaintenance.TabIndex = 6;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSupplier.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Appearance.Options.UseBackColor = true;
            this.btnSupplier.Appearance.Options.UseBorderColor = true;
            this.btnSupplier.Appearance.Options.UseFont = true;
            this.btnSupplier.Appearance.Options.UseForeColor = true;
            this.btnSupplier.Appearance.Options.UseTextOptions = true;
            this.btnSupplier.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSupplier.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btnSupplier.Location = new System.Drawing.Point(0, 212);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(240, 53);
            this.btnSupplier.TabIndex = 7;
            this.btnSupplier.Text = "Suppliers";
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // Main
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Build Haus Center Inverntory System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSideBar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSales;
        private DevExpress.XtraEditors.SimpleButton btnDashboard;
        private DevExpress.XtraEditors.SimpleButton btnCustomer;
        private DevExpress.XtraEditors.SimpleButton btnCategories;
        private DevExpress.XtraEditors.SimpleButton btnInventory;
        private DevExpress.XtraEditors.SimpleButton btnItems;
        public System.Windows.Forms.Panel pnlBody;
        private DevExpress.XtraEditors.SimpleButton btnMaintenance;
        private DevExpress.XtraEditors.SimpleButton btnSupplier;
    }
}

