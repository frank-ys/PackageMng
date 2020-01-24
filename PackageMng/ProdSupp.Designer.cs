namespace PackageMng
{
    partial class dlgProdSupp
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
            System.Windows.Forms.Label productSupplierIdLabel;
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label supNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgProdSupp));
            this.travelexpertsDataSet = new PackageMng.travelexpertsDataSet();
            this.products_suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_suppliersTableAdapter = new PackageMng.travelexpertsDataSetTableAdapters.products_suppliersTableAdapter();
            this.tableAdapterManager = new PackageMng.travelexpertsDataSetTableAdapters.TableAdapterManager();
            this.productsTableAdapter = new PackageMng.travelexpertsDataSetTableAdapters.productsTableAdapter();
            this.suppliersTableAdapter = new PackageMng.travelexpertsDataSetTableAdapters.suppliersTableAdapter();
            this.products_suppliersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productSupplierIdTextBox = new System.Windows.Forms.TextBox();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.supplierIdTextBox = new System.Windows.Forms.TextBox();
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.supNameTextBox = new System.Windows.Forms.TextBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodNameCB = new System.Windows.Forms.ComboBox();
            this.supNameCB = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.packages_products_suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packages_products_suppliersTableAdapter = new PackageMng.travelexpertsDataSetTableAdapters.packages_products_suppliersTableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            this.pkgList = new System.Windows.Forms.ListView();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagesTableAdapter = new PackageMng.travelexpertsDataSetTableAdapters.packagesTableAdapter();
            this.PackageId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PkgDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            productSupplierIdLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelexpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_suppliersBindingNavigator)).BeginInit();
            this.products_suppliersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_products_suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productSupplierIdLabel
            // 
            productSupplierIdLabel.AutoSize = true;
            productSupplierIdLabel.Location = new System.Drawing.Point(19, 64);
            productSupplierIdLabel.Name = "productSupplierIdLabel";
            productSupplierIdLabel.Size = new System.Drawing.Size(132, 17);
            productSupplierIdLabel.TabIndex = 1;
            productSupplierIdLabel.Text = "Product Supplier Id:";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(19, 104);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(76, 17);
            productIdLabel.TabIndex = 3;
            productIdLabel.Text = "Product Id:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(19, 150);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(79, 17);
            supplierIdLabel.TabIndex = 5;
            supplierIdLabel.Text = "Supplier Id:";
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Location = new System.Drawing.Point(452, 104);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(83, 17);
            prodNameLabel.TabIndex = 7;
            prodNameLabel.Text = "Prod Name:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Location = new System.Drawing.Point(452, 152);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(78, 17);
            supNameLabel.TabIndex = 9;
            supNameLabel.Text = "Sup Name:";
            // 
            // travelexpertsDataSet
            // 
            this.travelexpertsDataSet.DataSetName = "travelexpertsDataSet";
            this.travelexpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.packages_products_suppliersTableAdapter = null;
            this.tableAdapterManager.packagesTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.suppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.UpdateOrder = PackageMng.travelexpertsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // products_suppliersBindingNavigator
            // 
            this.products_suppliersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.products_suppliersBindingNavigator.BindingSource = this.products_suppliersBindingSource;
            this.products_suppliersBindingNavigator.CountItem = null;
            this.products_suppliersBindingNavigator.DeleteItem = null;
            this.products_suppliersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.products_suppliersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.products_suppliersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.products_suppliersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.products_suppliersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.products_suppliersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.products_suppliersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.products_suppliersBindingNavigator.Name = "products_suppliersBindingNavigator";
            this.products_suppliersBindingNavigator.PositionItem = null;
            this.products_suppliersBindingNavigator.Size = new System.Drawing.Size(1089, 27);
            this.products_suppliersBindingNavigator.TabIndex = 0;
            this.products_suppliersBindingNavigator.Text = "bindingNavigator1";
            this.products_suppliersBindingNavigator.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.products_suppliersBindingNavigator_ItemClicked);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // productSupplierIdTextBox
            // 
            this.productSupplierIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_suppliersBindingSource, "ProductSupplierId", true));
            this.productSupplierIdTextBox.Location = new System.Drawing.Point(157, 61);
            this.productSupplierIdTextBox.Name = "productSupplierIdTextBox";
            this.productSupplierIdTextBox.ReadOnly = true;
            this.productSupplierIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.productSupplierIdTextBox.TabIndex = 2;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_suppliersBindingSource, "ProductId", true));
            this.productIdTextBox.Location = new System.Drawing.Point(157, 101);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.ReadOnly = true;
            this.productIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.productIdTextBox.TabIndex = 4;
            // 
            // supplierIdTextBox
            // 
            this.supplierIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_suppliersBindingSource, "SupplierId", true));
            this.supplierIdTextBox.Location = new System.Drawing.Point(157, 147);
            this.supplierIdTextBox.Name = "supplierIdTextBox";
            this.supplierIdTextBox.ReadOnly = true;
            this.supplierIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.supplierIdTextBox.TabIndex = 6;
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_suppliersBindingSource, "ProdName", true));
            this.prodNameTextBox.Location = new System.Drawing.Point(541, 101);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.ReadOnly = true;
            this.prodNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.prodNameTextBox.TabIndex = 8;
            // 
            // supNameTextBox
            // 
            this.supNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_suppliersBindingSource, "SupName", true));
            this.supNameTextBox.Location = new System.Drawing.Point(541, 149);
            this.supNameTextBox.Name = "supNameTextBox";
            this.supNameTextBox.ReadOnly = true;
            this.supNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.supNameTextBox.TabIndex = 10;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.travelexpertsDataSet;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "suppliers";
            this.suppliersBindingSource.DataSource = this.travelexpertsDataSet;
            // 
            // prodNameCB
            // 
            this.prodNameCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.products_suppliersBindingSource, "ProductId", true));
            this.prodNameCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.products_suppliersBindingSource, "ProdName", true));
            this.prodNameCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_suppliersBindingSource, "ProdName", true));
            this.prodNameCB.DataSource = this.productsBindingSource;
            this.prodNameCB.DisplayMember = "ProdName";
            this.prodNameCB.FormattingEnabled = true;
            this.prodNameCB.Location = new System.Drawing.Point(292, 101);
            this.prodNameCB.Name = "prodNameCB";
            this.prodNameCB.Size = new System.Drawing.Size(121, 24);
            this.prodNameCB.TabIndex = 11;
            this.prodNameCB.ValueMember = "ProductId";
            this.prodNameCB.SelectedIndexChanged += new System.EventHandler(this.prodNameCB_SelectedIndexChanged);
            // 
            // supNameCB
            // 
            this.supNameCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.products_suppliersBindingSource, "SupName", true));
            this.supNameCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.products_suppliersBindingSource, "SupplierId", true));
            this.supNameCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_suppliersBindingSource, "SupName", true));
            this.supNameCB.DataSource = this.suppliersBindingSource;
            this.supNameCB.DisplayMember = "SupName";
            this.supNameCB.FormattingEnabled = true;
            this.supNameCB.Location = new System.Drawing.Point(292, 147);
            this.supNameCB.Name = "supNameCB";
            this.supNameCB.Size = new System.Drawing.Size(121, 24);
            this.supNameCB.TabIndex = 12;
            this.supNameCB.ValueMember = "SupplierId";
            this.supNameCB.SelectedIndexChanged += new System.EventHandler(this.supNameCB_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(81, 255);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 48);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(204, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 48);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // packages_products_suppliersBindingSource
            // 
            this.packages_products_suppliersBindingSource.DataMember = "packages_products_suppliers";
            this.packages_products_suppliersBindingSource.DataSource = this.travelexpertsDataSet;
            // 
            // packages_products_suppliersTableAdapter
            // 
            this.packages_products_suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(330, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 48);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pkgList
            // 
            this.pkgList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PackageId,
            this.PkgDesc});
            this.pkgList.HideSelection = false;
            this.pkgList.Location = new System.Drawing.Point(696, 29);
            this.pkgList.MultiSelect = false;
            this.pkgList.Name = "pkgList";
            this.pkgList.Size = new System.Drawing.Size(342, 274);
            this.pkgList.TabIndex = 16;
            this.pkgList.UseCompatibleStateImageBehavior = false;
            this.pkgList.View = System.Windows.Forms.View.Details;
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
            // PackageId
            // 
            this.PackageId.Text = "Package ID";
            // 
            // PkgDesc
            // 
            this.PkgDesc.Text = "Package Description";
            this.PkgDesc.Width = 300;
            // 
            // dlgProdSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 343);
            this.Controls.Add(this.pkgList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.supNameCB);
            this.Controls.Add(this.prodNameCB);
            this.Controls.Add(productSupplierIdLabel);
            this.Controls.Add(this.productSupplierIdTextBox);
            this.Controls.Add(productIdLabel);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(supplierIdLabel);
            this.Controls.Add(this.supplierIdTextBox);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.prodNameTextBox);
            this.Controls.Add(supNameLabel);
            this.Controls.Add(this.supNameTextBox);
            this.Controls.Add(this.products_suppliersBindingNavigator);
            this.Name = "dlgProdSupp";
            this.Text = "Product, Supplier Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dlgProdSupp_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelexpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_suppliersBindingNavigator)).EndInit();
            this.products_suppliersBindingNavigator.ResumeLayout(false);
            this.products_suppliersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_products_suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private travelexpertsDataSet travelexpertsDataSet;
        private System.Windows.Forms.BindingSource products_suppliersBindingSource;
        private travelexpertsDataSetTableAdapters.products_suppliersTableAdapter products_suppliersTableAdapter;
        private travelexpertsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator products_suppliersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private travelexpertsDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.TextBox productSupplierIdTextBox;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.TextBox supplierIdTextBox;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.TextBox supNameTextBox;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private travelexpertsDataSetTableAdapters.suppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.ComboBox prodNameCB;
        private System.Windows.Forms.ComboBox supNameCB;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource packages_products_suppliersBindingSource;
        private travelexpertsDataSetTableAdapters.packages_products_suppliersTableAdapter packages_products_suppliersTableAdapter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView pkgList;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private travelexpertsDataSetTableAdapters.packagesTableAdapter packagesTableAdapter;
        private System.Windows.Forms.ColumnHeader PackageId;
        private System.Windows.Forms.ColumnHeader PkgDesc;
    }
}