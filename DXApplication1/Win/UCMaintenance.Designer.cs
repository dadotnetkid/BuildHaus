namespace Win
{
    partial class UCMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMaintenance));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.MaintenanceGridControl = new DevExpress.XtraGrid.GridControl();
            this.MaintenanceGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddleInitial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cboCategoryRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboUserLevel = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MaintenanceGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaintenanceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoryRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUserLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // MaintenanceGridControl
            // 
            this.MaintenanceGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaintenanceGridControl.Location = new System.Drawing.Point(0, 0);
            this.MaintenanceGridControl.MainView = this.MaintenanceGridView;
            this.MaintenanceGridControl.Name = "MaintenanceGridControl";
            this.MaintenanceGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboCategoryRepo,
            this.btnDelete,
            this.cboUserLevel});
            this.MaintenanceGridControl.Size = new System.Drawing.Size(1296, 596);
            this.MaintenanceGridControl.TabIndex = 2;
            this.MaintenanceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MaintenanceGridView});
            // 
            // MaintenanceGridView
            // 
            this.MaintenanceGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.MaintenanceGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.MaintenanceGridView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.MaintenanceGridView.Appearance.Row.Options.UseFont = true;
            this.MaintenanceGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfirstName,
            this.colMiddleInitial,
            this.colLastName,
            this.colUserName,
            this.colPassword,
            this.colDelete,
            this.colLevel});
            this.MaintenanceGridView.GridControl = this.MaintenanceGridControl;
            this.MaintenanceGridView.Name = "MaintenanceGridView";
            this.MaintenanceGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.MaintenanceGridView.OptionsView.ShowGroupPanel = false;
            this.MaintenanceGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.MaintenanceGridView_RowUpdated);
            // 
            // colfirstName
            // 
            this.colfirstName.Caption = "First Name";
            this.colfirstName.FieldName = "FirstName";
            this.colfirstName.Name = "colfirstName";
            this.colfirstName.Visible = true;
            this.colfirstName.VisibleIndex = 1;
            this.colfirstName.Width = 330;
            // 
            // colMiddleInitial
            // 
            this.colMiddleInitial.Caption = "M.I";
            this.colMiddleInitial.FieldName = "MiddleName";
            this.colMiddleInitial.Name = "colMiddleInitial";
            this.colMiddleInitial.Visible = true;
            this.colMiddleInitial.VisibleIndex = 2;
            this.colMiddleInitial.Width = 65;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "LastName";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 3;
            this.colLastName.Width = 132;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Username";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 4;
            this.colUserName.Width = 162;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "Password(hash password)";
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 5;
            this.colPassword.Width = 306;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.btnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 0;
            this.colDelete.Width = 26;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            // colLevel
            // 
            this.colLevel.Caption = "Level";
            this.colLevel.ColumnEdit = this.cboUserLevel;
            this.colLevel.FieldName = "UserLevel";
            this.colLevel.Name = "colLevel";
            this.colLevel.Visible = true;
            this.colLevel.VisibleIndex = 6;
            this.colLevel.Width = 246;
            // 
            // cboUserLevel
            // 
            this.cboUserLevel.AutoHeight = false;
            this.cboUserLevel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboUserLevel.Items.AddRange(new object[] {
            "Staff",
            "Manager"});
            this.cboUserLevel.Name = "cboUserLevel";
            // 
            // UCMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MaintenanceGridControl);
            this.Name = "UCMaintenance";
            this.Size = new System.Drawing.Size(1296, 596);
            ((System.ComponentModel.ISupportInitialize)(this.MaintenanceGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaintenanceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoryRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUserLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl MaintenanceGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView MaintenanceGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colfirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleInitial;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboCategoryRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colLevel;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cboUserLevel;
    }
}
