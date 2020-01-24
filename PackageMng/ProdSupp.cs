using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackageMng
{
    public partial class dlgProdSupp : Form
    {
        private bool b_modified;
        private bool b_addedNew;
        public dlgProdSupp()
        {
             InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelexpertsDataSet.packages' table. You can move, or remove it, as needed.
            this.packagesTableAdapter.Fill(this.travelexpertsDataSet.packages);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.packages_products_suppliers' table. You can move, or remove it, as needed.
            this.packages_products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.packages_products_suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.travelexpertsDataSet.suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelexpertsDataSet.products);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products_suppliers' table. You can move, or remove it, as needed.
            this.products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.products_suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.travelexpertsDataSet.suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelexpertsDataSet.products);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products_suppliers' table. You can move, or remove it, as needed.
            this.products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.products_suppliers);

            b_modified = false;
            b_addedNew = false;
            psIdChanged();
        }

        private void prodNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.prodNameCB.SelectedItem == null)
                return;
            //products_suppliersBindingSource - ProductId  productIdTextBox prodNameCB.SelectedValue
            //products_suppliersBindingSource - ProdName   prodNameTextBox prodNameCB.Text
            productIdTextBox.Text= prodNameCB.SelectedValue.ToString();
            prodNameTextBox.Text =prodNameCB.Text;

            b_modified = true;
        }
        
        private void supNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.supNameCB.SelectedItem == null)
                return;
            supplierIdTextBox.Text = supNameCB.SelectedValue.ToString();
            supNameTextBox.Text = supNameCB.Text;
            b_modified = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (b_addedNew)
            {
                MessageBox.Show("Wrong Action", "Message");
                return;
            }
            var result = MessageBox.Show("Do you really want Delete?", "Warning", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            int psId = Convert.ToInt32(productSupplierIdTextBox.Text);

            var test = (from m in this.travelexpertsDataSet.packages_products_suppliers
                        where m.ProductSupplierId == psId 
                        select m.PackageId  ).ToArray();
            if(test.Length>0)
            {
                MessageBox.Show("This is in using!", "Cannot Delete");
                return;
            }
            products_suppliersTableAdapter.DeleteQuery(psId);

            this.tableAdapterManager.UpdateAll(this.travelexpertsDataSet);
            this.products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.products_suppliers);
            b_modified = false;
            b_addedNew = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            b_addedNew = true;
            b_modified = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!b_addedNew && !b_modified)  // Do nothing if nothing is changed
                return;
            this.saveCurProdSuppData();
        }

        private void checkSave()
        {
            if (!b_addedNew && !b_modified)
                return;

            var result = MessageBox.Show("Will you save?", "Save", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.No)
                return;

            saveCurProdSuppData();
        }
        private bool saveCurProdSuppData()
        {
            if (!b_addedNew && !b_modified)
                return false;

            int sId = (int)supNameCB.SelectedValue;
            int pId = (int)prodNameCB.SelectedValue;
            if (b_addedNew)  // Insert new
            {
                products_suppliersTableAdapter.InsertQuery(pId, sId);
            }
            else  // Update modified
            {
                // get supplierId and productId from comboBox from its index, in case of just changed one of two combobox.
 /*               DataRowView tp_data = supNameCB.Items[supNameCB.SelectedIndex] as DataRowView;
                if (tp_data != null)
                    sId = Convert.ToInt32(tp_data.Row["supplierID"]);

                tp_data = prodNameCB.Items[prodNameCB.SelectedIndex] as DataRowView;
                if (tp_data != null)
                    pId = Convert.ToInt32(tp_data.Row["productId"]);
*/
                int psId = Convert.ToInt32(productSupplierIdTextBox.Text); 
                products_suppliersTableAdapter.UpdateQuery(sId, pId, psId);
            }

            this.tableAdapterManager.UpdateAll(this.travelexpertsDataSet);
            this.products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.products_suppliers);
            MessageBox.Show("Saved Successfully", "Message");
            b_modified = false;
            b_addedNew = false;

            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            checkSave();
            this.Close();
        }

        private void dlgProdSupp_FormClosing(object sender, FormClosingEventArgs e)
        {
            checkSave();
        }

         private void products_suppliersBindingNavigator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            checkSave();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            b_modified = false;
            b_addedNew = false;
            psIdChanged();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            b_modified = false;
            b_addedNew = false;
            psIdChanged();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            b_modified = false;
            b_addedNew = false;
            psIdChanged();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            b_modified = false;
            b_addedNew = false;
            psIdChanged();
        }

        // Show on ListBox What packages are using current Product-Supplier item.
        private void psIdChanged()
        {
            pkgList.Items.Clear();

            int psId = Convert.ToInt32(productSupplierIdTextBox.Text);

            // getting PackageId(s) from packages_products_suppliers with current psId
            var tp_pkgIds = (from pps in this.travelexpertsDataSet.packages_products_suppliers
                            where pps.ProductSupplierId == psId
                            select pps.PackageId).ToArray();

            // getting package Infos with PackageId those are using current psId
            var tp_pkg = (from m in tp_pkgIds
                          join p in this.travelexpertsDataSet.packages
                          on m equals p.PackageId
                          select new { p.PackageId, p.PkgDesc}).ToArray();

            if (tp_pkg.Length <= 0)
            {
                return;
            }

            foreach(var m in tp_pkg)
            {
//                custList.Add(new CustomerData((uint)addCustFm.custData.accountNo, (String)addCustFm.custData.custName,
  //                      (char)addCustFm.custData.custType, (decimal)addCustFm.custData.chargeAmt));
                // add customer object to ListView
                ListViewItem itm = new ListViewItem( new[] { m.PackageId.ToString(), m.PkgDesc } );
                pkgList.Items.Add(itm);
            }

            //pkgList.Items.Add;
        }

    }
}
