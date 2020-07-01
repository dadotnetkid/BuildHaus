namespace Win
{
    partial class UCCustomers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.CustomerGridControl = new DevExpress.XtraGrid.GridControl();
            this.CustomerGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobileNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInventory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.ElementType = typeof(Models.Users);
            this.entityServerModeSource1.KeyExpression = "Id";
            // 
            // CustomerGridControl
            // 
            this.CustomerGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerGridControl.Location = new System.Drawing.Point(0, 0);
            this.CustomerGridControl.MainView = this.CustomerGridView;
            this.CustomerGridControl.Name = "CustomerGridControl";
            this.CustomerGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.CustomerGridControl.Size = new System.Drawing.Size(1044, 701);
            this.CustomerGridControl.TabIndex = 3;
            this.CustomerGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CustomerGridView});
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.CustomerGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.CustomerGridView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.CustomerGridView.Appearance.Row.Options.UseFont = true;
            this.CustomerGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCustomerName,
            this.colMobileNumber,
            this.colAddress,
            this.colInventory});
            this.CustomerGridView.GridControl = this.CustomerGridControl;
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.CustomerGridView.OptionsView.ShowGroupPanel = false;
            this.CustomerGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.CustomerGridView_RowUpdated);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            // 
            // colMobileNumber
            // 
            this.colMobileNumber.FieldName = "MobileNumber";
            this.colMobileNumber.Name = "colMobileNumber";
            this.colMobileNumber.Visible = true;
            this.colMobileNumber.VisibleIndex = 1;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            // 
            // colInventory
            // 
            this.colInventory.FieldName = "Inventory";
            this.colInventory.Name = "colInventory";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Category Name")});
            this.repositoryItemLookUpEdit1.DisplayMember = "CategoryName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "Id";
            // 
            // UCCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomerGridControl);
            this.Name = "UCCustomers";
            this.Size = new System.Drawing.Size(1044, 701);
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private DevExpress.XtraGrid.GridControl CustomerGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView CustomerGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colMobileNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colInventory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}
