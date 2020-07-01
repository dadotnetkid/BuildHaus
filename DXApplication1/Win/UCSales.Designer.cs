namespace Win
{
    partial class UCSales
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSales));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.InventoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.InventoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboItems = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colORNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboCategoryRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboTransactionType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.pnlTransaction = new System.Windows.Forms.Panel();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEnd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoryRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTransactionType)).BeginInit();
            this.pnlTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.13655F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.86345F));
            this.tableLayoutPanel1.Controls.Add(this.InventoryGridControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlTransaction, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1318, 625);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // InventoryGridControl
            // 
            this.InventoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryGridControl.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.InventoryGridControl.Location = new System.Drawing.Point(479, 3);
            this.InventoryGridControl.MainView = this.InventoryGridView;
            this.InventoryGridControl.Name = "InventoryGridControl";
            this.InventoryGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboCategoryRepo,
            this.cboItems,
            this.cboTransactionType,
            this.spinAmount,
            this.btnDelete});
            this.InventoryGridControl.Size = new System.Drawing.Size(836, 619);
            this.InventoryGridControl.TabIndex = 4;
            this.InventoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InventoryGridView});
            // 
            // InventoryGridView
            // 
            this.InventoryGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.InventoryGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.InventoryGridView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryGridView.Appearance.Row.Options.UseFont = true;
            this.InventoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemName,
            this.colSN,
            this.colQTY,
            this.colORNumber,
            this.colCustomer,
            this.colTotalAmount,
            this.colDelete});
            this.InventoryGridView.GridControl = this.InventoryGridControl;
            this.InventoryGridView.Name = "InventoryGridView";
            this.InventoryGridView.OptionsBehavior.ReadOnly = true;
            this.InventoryGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            // 
            // colSN
            // 
            this.colSN.ColumnEdit = this.cboItems;
            this.colSN.FieldName = "SN";
            this.colSN.Name = "colSN";
            this.colSN.Visible = true;
            this.colSN.VisibleIndex = 0;
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
            // colQTY
            // 
            this.colQTY.ColumnEdit = this.spinAmount;
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 2;
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
            // colORNumber
            // 
            this.colORNumber.Caption = "ORNumber";
            this.colORNumber.FieldName = "ORNumber";
            this.colORNumber.Name = "colORNumber";
            this.colORNumber.Visible = true;
            this.colORNumber.VisibleIndex = 3;
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Customer";
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Caption = "Total Amount";
            this.colTotalAmount.ColumnEdit = this.spinAmount;
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 4;
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
            // pnlTransaction
            // 
            this.pnlTransaction.BackColor = System.Drawing.Color.White;
            this.pnlTransaction.Controls.Add(this.txtDescription);
            this.pnlTransaction.Controls.Add(this.btnSubmit);
            this.pnlTransaction.Controls.Add(this.labelControl2);
            this.pnlTransaction.Controls.Add(this.labelControl1);
            this.pnlTransaction.Controls.Add(this.txtSearch);
            this.pnlTransaction.Controls.Add(this.txtCustomer);
            this.pnlTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransaction.Enabled = false;
            this.pnlTransaction.Location = new System.Drawing.Point(3, 3);
            this.pnlTransaction.Name = "pnlTransaction";
            this.pnlTransaction.Size = new System.Drawing.Size(470, 619);
            this.pnlTransaction.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(4, 156);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.ReadOnly = true;
            this.txtDescription.Properties.UseReadOnlyAppearance = false;
            this.txtDescription.Size = new System.Drawing.Size(464, 369);
            this.txtDescription.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Appearance.Options.UseFont = true;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.Location = new System.Drawing.Point(0, 531);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(470, 88);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(4, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 25);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Customer";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(204, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Search(Quantity@SN)";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(3, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Size = new System.Drawing.Size(465, 36);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomer.Location = new System.Drawing.Point(3, 114);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Properties.Appearance.Options.UseFont = true;
            this.txtCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 181, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MobileNumber", "Mobile Number", 170, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Address", 94, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtCustomer.Properties.DataSource = this.customersBindingSource;
            this.txtCustomer.Properties.DisplayMember = "CustomerName";
            this.txtCustomer.Properties.NullText = "";
            this.txtCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtCustomer.Properties.ValueMember = "Id";
            this.txtCustomer.Size = new System.Drawing.Size(465, 36);
            this.txtCustomer.TabIndex = 0;
            this.txtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(Models.Customers);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnEnd);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1318, 63);
            this.panel2.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Enabled = false;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(854, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(427, 63);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel(F5)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Appearance.Options.UseFont = true;
            this.btnEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEnd.Enabled = false;
            this.btnEnd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEnd.ImageOptions.Image")));
            this.btnEnd.Location = new System.Drawing.Point(427, 0);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(427, 63);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "&End(F4)";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(427, 63);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "&New(F3)";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // colDelete
            // 
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelete_ButtonClick);
            // 
            // UCSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "UCSales";
            this.Size = new System.Drawing.Size(1318, 688);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoryRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTransactionType)).EndInit();
            this.pnlTransaction.ResumeLayout(false);
            this.pnlTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl InventoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView InventoryGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colSN;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboItems;
        private DevExpress.XtraGrid.Columns.GridColumn colQTY;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colORNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboCategoryRepo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTransactionType;
        private System.Windows.Forms.Panel pnlTransaction;
        public DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit txtCustomer;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnEnd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
    }
}
