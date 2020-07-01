namespace Win.Itms
{
    partial class UCItems
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
            this.components = new System.ComponentModel.Container();
            this.ItemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.entityModeSource = new DevExpress.Data.Linq.EntityServerModeSource();
            this.ItemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboCategoryRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colOrderLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategories = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInventory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboSupplier = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityModeSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoryRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsGridControl
            // 
            this.ItemsGridControl.DataSource = this.entityModeSource;
            this.ItemsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGridControl.Location = new System.Drawing.Point(0, 0);
            this.ItemsGridControl.MainView = this.ItemsGridView;
            this.ItemsGridControl.Name = "ItemsGridControl";
            this.ItemsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboCategoryRepo,
            this.spinAmount,
            this.cboSupplier});
            this.ItemsGridControl.Size = new System.Drawing.Size(1150, 658);
            this.ItemsGridControl.TabIndex = 0;
            this.ItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ItemsGridView});
            // 
            // entityModeSource
            // 
            this.entityModeSource.ElementType = typeof(Models.Items);
            this.entityModeSource.KeyExpression = "Id";
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ItemsGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.ItemsGridView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ItemsGridView.Appearance.Row.Options.UseFont = true;
            this.ItemsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemName,
            this.colCategoryId,
            this.colCategoryName,
            this.colUOM,
            this.colSKU,
            this.colSN,
            this.colUnitPrice,
            this.colOrderLevel,
            this.colRetailPrice,
            this.colCreatedBy,
            this.colDateCreated,
            this.colModifiedBy,
            this.colModifiedDate,
            this.colCategories,
            this.colInventory,
            this.colQTY,
            this.colSupplier});
            this.ItemsGridView.GridControl = this.ItemsGridControl;
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.ItemsGridView.OptionsView.ShowGroupPanel = false;
            this.ItemsGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.ItemsGridView_RowUpdated);
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 0;
            // 
            // colCategoryId
            // 
            this.colCategoryId.Caption = "Categories";
            this.colCategoryId.ColumnEdit = this.cboCategoryRepo;
            this.colCategoryId.FieldName = "CategoryId";
            this.colCategoryId.Name = "colCategoryId";
            this.colCategoryId.Visible = true;
            this.colCategoryId.VisibleIndex = 2;
            // 
            // cboCategoryRepo
            // 
            this.cboCategoryRepo.AutoHeight = false;
            this.cboCategoryRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCategoryRepo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Category Name")});
            this.cboCategoryRepo.DisplayMember = "CategoryName";
            this.cboCategoryRepo.Name = "cboCategoryRepo";
            this.cboCategoryRepo.NullText = "";
            this.cboCategoryRepo.ValueMember = "Id";
            // 
            // colCategoryName
            // 
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            // 
            // colUOM
            // 
            this.colUOM.FieldName = "UOM";
            this.colUOM.Name = "colUOM";
            this.colUOM.Visible = true;
            this.colUOM.VisibleIndex = 3;
            // 
            // colSKU
            // 
            this.colSKU.FieldName = "SKU";
            this.colSKU.Name = "colSKU";
            this.colSKU.Visible = true;
            this.colSKU.VisibleIndex = 4;
            // 
            // colSN
            // 
            this.colSN.FieldName = "SN";
            this.colSN.Name = "colSN";
            this.colSN.Visible = true;
            this.colSN.VisibleIndex = 5;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.ColumnEdit = this.spinAmount;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 6;
            // 
            // spinAmount
            // 
            this.spinAmount.AutoHeight = false;
            this.spinAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinAmount.DisplayFormat.FormatString = "#,#.00##";
            this.spinAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.spinAmount.EditFormat.FormatString = "#,#.00##";
            this.spinAmount.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.spinAmount.Name = "spinAmount";
            // 
            // colOrderLevel
            // 
            this.colOrderLevel.ColumnEdit = this.spinAmount;
            this.colOrderLevel.FieldName = "OrderLevel";
            this.colOrderLevel.Name = "colOrderLevel";
            this.colOrderLevel.Visible = true;
            this.colOrderLevel.VisibleIndex = 7;
            // 
            // colRetailPrice
            // 
            this.colRetailPrice.ColumnEdit = this.spinAmount;
            this.colRetailPrice.FieldName = "RetailPrice";
            this.colRetailPrice.Name = "colRetailPrice";
            this.colRetailPrice.Visible = true;
            this.colRetailPrice.VisibleIndex = 8;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            // 
            // colDateCreated
            // 
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            // 
            // colCategories
            // 
            this.colCategories.FieldName = "Categories";
            this.colCategories.Name = "colCategories";
            // 
            // colInventory
            // 
            this.colInventory.FieldName = "Inventory";
            this.colInventory.Name = "colInventory";
            // 
            // colQTY
            // 
            this.colQTY.Caption = "QTY";
            this.colQTY.ColumnEdit = this.spinAmount;
            this.colQTY.FieldName = "TotalQty";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.ReadOnly = true;
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 9;
            // 
            // colSupplier
            // 
            this.colSupplier.Caption = "Supplier";
            this.colSupplier.ColumnEdit = this.cboSupplier;
            this.colSupplier.FieldName = "SupplierId";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.Visible = true;
            this.colSupplier.VisibleIndex = 1;
            // 
            // cboSupplier
            // 
            this.cboSupplier.AutoHeight = false;
            this.cboSupplier.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSupplier.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierName", "Supplier Name", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Address", 49, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactNumber", "Contact Number", 88, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboSupplier.DataSource = this.suppliersBindingSource;
            this.cboSupplier.DisplayMember = "SupplierName";
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.NullText = "";
            this.cboSupplier.PopupFormMinSize = new System.Drawing.Size(1500, 0);
            this.cboSupplier.PopupWidth = 150;
            this.cboSupplier.ValueMember = "Id";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataSource = typeof(Models.Suppliers);
            // 
            // UCItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemsGridControl);
            this.Name = "UCItems";
            this.Size = new System.Drawing.Size(1150, 658);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityModeSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoryRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ItemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ItemsGridView;
        private DevExpress.Data.Linq.EntityServerModeSource entityModeSource;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colUOM;
        private DevExpress.XtraGrid.Columns.GridColumn colSKU;
        private DevExpress.XtraGrid.Columns.GridColumn colSN;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCategories;
        private DevExpress.XtraGrid.Columns.GridColumn colInventory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboCategoryRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colQTY;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboSupplier;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
    }
}
