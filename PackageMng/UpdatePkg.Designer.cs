namespace PackageMng
{
    partial class UpdatePkgDlg
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
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            this.travelexpertsDataSet = new PackageMng.travelexpertsDataSet();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagesTableAdapter = new PackageMng.travelexpertsDataSetTableAdapters.packagesTableAdapter();
            this.tableAdapterManager = new PackageMng.travelexpertsDataSetTableAdapters.TableAdapterManager();
            this.packages_products_suppliersTableAdapter = new PackageMng.travelexpertsDataSetTableAdapters.packages_products_suppliersTableAdapter();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listPackage = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listProdSupp = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.packages_products_suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_suppliersTableAdapter = new PackageMng.travelexpertsDataSetTableAdapters.products_suppliersTableAdapter();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelexpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_products_suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_suppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(79, 62);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(77, 17);
            pkgNameLabel.TabIndex = 3;
            pkgNameLabel.Text = "Pkg Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(53, 91);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(104, 17);
            pkgStartDateLabel.TabIndex = 5;
            pkgStartDateLabel.Text = "Pkg Start Date:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(59, 119);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(99, 17);
            pkgEndDateLabel.TabIndex = 7;
            pkgEndDateLabel.Text = "Pkg End Date:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(406, 61);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(72, 17);
            pkgDescLabel.TabIndex = 9;
            pkgDescLabel.Text = "Pkg Desc:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(372, 89);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(108, 17);
            pkgBasePriceLabel.TabIndex = 11;
            pkgBasePriceLabel.Text = "Pkg Base Price:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(316, 117);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(166, 17);
            pkgAgencyCommissionLabel.TabIndex = 13;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // travelexpertsDataSet
            // 
            this.travelexpertsDataSet.DataSetName = "travelexpertsDataSet";
            this.travelexpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataMember = "packages";
            this.packagesBindingSource.DataSource = this.travelexpertsDataSet;
            // 
            // packagesTableAdapter
            // 
            this.packagesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.packages_products_suppliersTableAdapter = this.packages_products_suppliersTableAdapter;
            this.tableAdapterManager.packagesTableAdapter = this.packagesTableAdapter;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.suppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PackageMng.travelexpertsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // packages_products_suppliersTableAdapter
            // 
            this.packages_products_suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.Location = new System.Drawing.Point(163, 58);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(112, 22);
            this.pkgNameTextBox.TabIndex = 4;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(163, 86);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(112, 22);
            this.pkgStartDateDateTimePicker.TabIndex = 6;
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(163, 114);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(112, 22);
            this.pkgEndDateDateTimePicker.TabIndex = 8;
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.Location = new System.Drawing.Point(488, 58);
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.Size = new System.Drawing.Size(112, 22);
            this.pkgDescTextBox.TabIndex = 10;
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(488, 86);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(112, 22);
            this.pkgBasePriceTextBox.TabIndex = 12;
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(488, 114);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(112, 22);
            this.pkgAgencyCommissionTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(530, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(414, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listPackage
            // 
            this.listPackage.AllowColumnReorder = true;
            this.listPackage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listPackage.FullRowSelect = true;
            this.listPackage.HideSelection = false;
            this.listPackage.Location = new System.Drawing.Point(54, 172);
            this.listPackage.MultiSelect = false;
            this.listPackage.Name = "listPackage";
            this.listPackage.Size = new System.Drawing.Size(233, 164);
            this.listPackage.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listPackage.TabIndex = 27;
            this.listPackage.UseCompatibleStateImageBehavior = false;
            this.listPackage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 24;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Supplier";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listProdSupp
            // 
            this.listProdSupp.AllowColumnReorder = true;
            this.listProdSupp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.pname,
            this.sname});
            this.listProdSupp.FullRowSelect = true;
            this.listProdSupp.HideSelection = false;
            this.listProdSupp.Location = new System.Drawing.Point(396, 172);
            this.listProdSupp.MultiSelect = false;
            this.listProdSupp.Name = "listProdSupp";
            this.listProdSupp.Size = new System.Drawing.Size(233, 164);
            this.listProdSupp.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listProdSupp.TabIndex = 26;
            this.listProdSupp.UseCompatibleStateImageBehavior = false;
            this.listProdSupp.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 24;
            // 
            // pname
            // 
            this.pname.Text = "Product";
            this.pname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sname
            // 
            this.sname.Text = "Supplier";
            this.sname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Package";
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(296, 258);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(91, 44);
            this.btn_remove.TabIndex = 22;
            this.btn_remove.Text = "Remove >";
            this.btn_remove.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(295, 192);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(91, 44);
            this.btn_add.TabIndex = 23;
            this.btn_add.Text = "Add <";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // packages_products_suppliersBindingSource
            // 
            this.packages_products_suppliersBindingSource.DataMember = "packages_products_suppliers";
            this.packages_products_suppliersBindingSource.DataSource = this.travelexpertsDataSet;
            // 
            // products_suppliersBindingSource
            // 
            this.products_suppliersBindingSource.DataMember = "products_suppliers";
            this.products_suppliersBindingSource.DataSource = this.travelexpertsDataSet;
            // 
            // products_suppliersTableAdapter
            // 
            this.products_suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // UpdatePkgDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listPackage);
            this.Controls.Add(this.listProdSupp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.pkgNameTextBox);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.pkgStartDateDateTimePicker);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.pkgEndDateDateTimePicker);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.pkgDescTextBox);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.pkgBasePriceTextBox);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.Name = "UpdatePkgDlg";
            this.Text = "UpdatePkg";
            this.Load += new System.EventHandler(this.UpdatePkg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelexpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_products_suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_suppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private travelexpertsDataSet travelexpertsDataSet;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private travelexpertsDataSetTableAdapters.packagesTableAdapter packagesTableAdapter;
        private travelexpertsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public int packageId;
        public System.Windows.Forms.TextBox pkgNameTextBox;
        public System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        public System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        public System.Windows.Forms.TextBox pkgDescTextBox;
        public System.Windows.Forms.TextBox pkgBasePriceTextBox;
        public System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listPackage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listProdSupp;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader pname;
        private System.Windows.Forms.ColumnHeader sname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private travelexpertsDataSetTableAdapters.packages_products_suppliersTableAdapter packages_products_suppliersTableAdapter;
        private System.Windows.Forms.BindingSource packages_products_suppliersBindingSource;
        private System.Windows.Forms.BindingSource products_suppliersBindingSource;
        private travelexpertsDataSetTableAdapters.products_suppliersTableAdapter products_suppliersTableAdapter;
    }
}