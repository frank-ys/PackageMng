namespace PackageMng
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
            this.btn_pkg_details = new System.Windows.Forms.Button();
            this.btn_prodSupp = new System.Windows.Forms.Button();
            this.travelexpertsDataSet = new PackageMng.travelexpertsDataSet();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.travelexpertsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pkg_details
            // 
            this.btn_pkg_details.Location = new System.Drawing.Point(78, 133);
            this.btn_pkg_details.Name = "btn_pkg_details";
            this.btn_pkg_details.Size = new System.Drawing.Size(246, 70);
            this.btn_pkg_details.TabIndex = 0;
            this.btn_pkg_details.Text = "Package Details";
            this.btn_pkg_details.UseVisualStyleBackColor = true;
            this.btn_pkg_details.Click += new System.EventHandler(this.btn_pkg_details_Click);
            // 
            // btn_prodSupp
            // 
            this.btn_prodSupp.Location = new System.Drawing.Point(78, 209);
            this.btn_prodSupp.Name = "btn_prodSupp";
            this.btn_prodSupp.Size = new System.Drawing.Size(124, 70);
            this.btn_prodSupp.TabIndex = 1;
            this.btn_prodSupp.Text = "Product Supplier Mng";
            this.btn_prodSupp.UseVisualStyleBackColor = true;
            this.btn_prodSupp.Click += new System.EventHandler(this.btn_prodSupp_Click);
            // 
            // travelexpertsDataSet
            // 
            this.travelexpertsDataSet.DataSetName = "travelexpertsDataSet";
            this.travelexpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(209, 210);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(115, 33);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Products Mng";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(209, 250);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(115, 29);
            this.btnSupp.TabIndex = 3;
            this.btnSupp.Text = "Supplier Mng";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 622);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btn_prodSupp);
            this.Controls.Add(this.btn_pkg_details);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelexpertsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pkg_details;
        private travelexpertsDataSet travelexpertsDataSet;
        private System.Windows.Forms.Button btn_prodSupp;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSupp;
    }
}

