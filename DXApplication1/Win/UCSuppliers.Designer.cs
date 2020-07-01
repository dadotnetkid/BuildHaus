namespace Win
{
    partial class UCSuppliers
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSuppliers));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.SupplierGridControl = new DevExpress.XtraGrid.GridControl();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupplierGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItems = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cboCategoryRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoryRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // SupplierGridControl
            // 
            this.SupplierGridControl.DataSource = this.suppliersBindingSource;
            this.SupplierGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplierGridControl.Location = new System.Drawing.Point(0, 0);
            this.SupplierGridControl.MainView = this.SupplierGridView;
            this.SupplierGridControl.Name = "SupplierGridControl";
            this.SupplierGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboCategoryRepo,
            this.btnDelete});
            this.SupplierGridControl.Size = new System.Drawing.Size(858, 611);
            this.SupplierGridControl.TabIndex = 3;
            this.SupplierGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SupplierGridView});
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataSource = typeof(Models.Suppliers);
            // 
            // SupplierGridView
            // 
            this.SupplierGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.SupplierGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.SupplierGridView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.SupplierGridView.Appearance.Row.Options.UseFont = true;
            this.SupplierGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSupplierName,
            this.colAddress,
            this.colContactNumber,
            this.colItems,
            this.colDelete});
            this.SupplierGridView.GridControl = this.SupplierGridControl;
            this.SupplierGridView.Name = "SupplierGridView";
            this.SupplierGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.SupplierGridView.OptionsView.ShowGroupPanel = false;
            this.SupplierGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.SupplierGridView_RowUpdated);
            // 
            // colSupplierName
            // 
            this.colSupplierName.FieldName = "SupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 1;
            this.colSupplierName.Width = 198;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            this.colAddress.Width = 198;
            // 
            // colContactNumber
            // 
            this.colContactNumber.FieldName = "ContactNumber";
            this.colContactNumber.Name = "colContactNumber";
            this.colContactNumber.Visible = true;
            this.colContactNumber.VisibleIndex = 3;
            this.colContactNumber.Width = 198;
            // 
            // colItems
            // 
            this.colItems.FieldName = "Items";
            this.colItems.Name = "colItems";
            this.colItems.Width = 201;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.btnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 0;
            this.colDelete.Width = 45;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ContextImageOptions.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelete_ButtonClick);
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
            // UCSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SupplierGridControl);
            this.Name = "UCSuppliers";
            this.Size = new System.Drawing.Size(858, 611);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoryRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl SupplierGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView SupplierGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboCategoryRepo;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colContactNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colItems;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
    }
}
