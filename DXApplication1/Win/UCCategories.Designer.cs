namespace Win
{
    partial class UCCategories
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
            this.CategoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.CategoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboCategoryRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoryRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryGridControl
            // 
            this.CategoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryGridControl.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.CategoryGridControl.Location = new System.Drawing.Point(0, 0);
            this.CategoryGridControl.MainView = this.CategoryGridView;
            this.CategoryGridControl.Name = "CategoryGridControl";
            this.CategoryGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboCategoryRepo});
            this.CategoryGridControl.Size = new System.Drawing.Size(935, 513);
            this.CategoryGridControl.TabIndex = 1;
            this.CategoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CategoryGridView});
            // 
            // CategoryGridView
            // 
            this.CategoryGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.CategoryGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.CategoryGridView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryGridView.Appearance.Row.Options.UseFont = true;
            this.CategoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryName});
            this.CategoryGridView.GridControl = this.CategoryGridControl;
            this.CategoryGridView.Name = "CategoryGridView";
            this.CategoryGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.CategoryGridView.OptionsView.ShowGroupPanel = false;
            this.CategoryGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.CategoryGridView_RowUpdated);
            // 
            // colCategoryName
            // 
            this.colCategoryName.Caption = "CategoryName";
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 0;
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
            // UCCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CategoryGridControl);
            this.Name = "UCCategories";
            this.Size = new System.Drawing.Size(935, 513);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoryRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl CategoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView CategoryGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboCategoryRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
    }
}
