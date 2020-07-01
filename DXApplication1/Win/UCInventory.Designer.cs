namespace Win
{
    partial class UCInventory
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCInventory));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.InventoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.InventoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboCategoryRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colUOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboItems = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colRetailPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboTransactionType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoryRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTransactionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryGridControl
            // 
            this.InventoryGridControl.DataSource = this.entityServerModeSource1;
            this.InventoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryGridControl.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.InventoryGridControl.Location = new System.Drawing.Point(0, 0);
            this.InventoryGridControl.MainView = this.InventoryGridView;
            this.InventoryGridControl.Name = "InventoryGridControl";
            this.InventoryGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboCategoryRepo,
            this.cboItems,
            this.cboTransactionType,
            this.spinAmount,
            this.btnDelete});
            this.InventoryGridControl.Size = new System.Drawing.Size(1304, 744);
            this.InventoryGridControl.TabIndex = 2;
            this.InventoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InventoryGridView});
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.ElementType = typeof(Models.Inventory);
            this.entityServerModeSource1.KeyExpression = "Id";
            // 
            // InventoryGridView
            // 
            this.InventoryGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.InventoryGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.InventoryGridView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryGridView.Appearance.Row.Options.UseFont = true;
            this.InventoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colItemName,
            this.colCategoryId,
            this.colUOM,
            this.colSKU,
            this.colSN,
            this.colUnitPrice,
            this.colRetailPrice,
            this.colTransactionType,
            this.colQTY,
            this.colDelete});
            this.InventoryGridView.GridControl = this.InventoryGridControl;
            this.InventoryGridView.Name = "InventoryGridView";
            this.InventoryGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.InventoryGridView.OptionsView.ShowGroupPanel = false;
            this.InventoryGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.InventoryGridView_CellValueChanged);
            this.InventoryGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.InventoryGridView_RowUpdated);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 2;
            this.colItemName.Width = 155;
            // 
            // colCategoryId
            // 
            this.colCategoryId.Caption = "Category";
            this.colCategoryId.ColumnEdit = this.cboCategoryRepo;
            this.colCategoryId.FieldName = "CategoryId";
            this.colCategoryId.Name = "colCategoryId";
            this.colCategoryId.OptionsColumn.ReadOnly = true;
            this.colCategoryId.Visible = true;
            this.colCategoryId.VisibleIndex = 3;
            this.colCategoryId.Width = 155;
            // 
            // cboCategoryRepo
            // 
            this.cboCategoryRepo.AutoHeight = false;
            this.cboCategoryRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCategoryRepo.DisplayMember = "CategoryName";
            this.cboCategoryRepo.KeyMember = "Id";
            this.cboCategoryRepo.Name = "cboCategoryRepo";
            this.cboCategoryRepo.NullText = "";
            this.cboCategoryRepo.ValueMember = "Id";
            // 
            // colUOM
            // 
            this.colUOM.FieldName = "UOM";
            this.colUOM.Name = "colUOM";
            this.colUOM.OptionsColumn.ReadOnly = true;
            this.colUOM.Visible = true;
            this.colUOM.VisibleIndex = 4;
            this.colUOM.Width = 155;
            // 
            // colSKU
            // 
            this.colSKU.FieldName = "SKU";
            this.colSKU.Name = "colSKU";
            // 
            // colSN
            // 
            this.colSN.ColumnEdit = this.cboItems;
            this.colSN.FieldName = "SN";
            this.colSN.Name = "colSN";
            this.colSN.Visible = true;
            this.colSN.VisibleIndex = 1;
            this.colSN.Width = 155;
            // 
            // cboItems
            // 
            this.cboItems.AutoHeight = false;
            this.cboItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboItems.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SN", "SN"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "ItemName")});
            this.cboItems.DisplayMember = "SN";
            this.cboItems.Name = "cboItems";
            this.cboItems.NullText = "";
            this.cboItems.ValueMember = "SN";
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.ColumnEdit = this.spinAmount;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsColumn.ReadOnly = true;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 5;
            this.colUnitPrice.Width = 155;
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
            // colRetailPrice
            // 
            this.colRetailPrice.ColumnEdit = this.spinAmount;
            this.colRetailPrice.FieldName = "RetailPrice";
            this.colRetailPrice.Name = "colRetailPrice";
            this.colRetailPrice.OptionsColumn.ReadOnly = true;
            this.colRetailPrice.Visible = true;
            this.colRetailPrice.VisibleIndex = 6;
            this.colRetailPrice.Width = 155;
            // 
            // colTransactionType
            // 
            this.colTransactionType.ColumnEdit = this.cboTransactionType;
            this.colTransactionType.FieldName = "TransactionType";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.Visible = true;
            this.colTransactionType.VisibleIndex = 7;
            this.colTransactionType.Width = 155;
            // 
            // cboTransactionType
            // 
            this.cboTransactionType.AutoHeight = false;
            this.cboTransactionType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTransactionType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionTypeName", "Transaction Type")});
            this.cboTransactionType.DisplayMember = "TransactionTypeName";
            this.cboTransactionType.Name = "cboTransactionType";
            this.cboTransactionType.NullText = "";
            this.cboTransactionType.ValueMember = "Type";
            // 
            // colQTY
            // 
            this.colQTY.ColumnEdit = this.spinAmount;
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 8;
            this.colQTY.Width = 165;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.btnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 0;
            this.colDelete.Width = 36;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelete_ButtonClick);
            // 
            // UCInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InventoryGridControl);
            this.Name = "UCInventory";
            this.Size = new System.Drawing.Size(1304, 744);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoryRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTransactionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl InventoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView InventoryGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboCategoryRepo;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colUOM;
        private DevExpress.XtraGrid.Columns.GridColumn colSKU;
        private DevExpress.XtraGrid.Columns.GridColumn colSN;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionType;
        private DevExpress.XtraGrid.Columns.GridColumn colQTY;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboItems;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTransactionType;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
    }
}
