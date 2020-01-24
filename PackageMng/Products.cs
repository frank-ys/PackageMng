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
    public partial class Products : Form
    {
        private bool b_modified;
        private bool b_addedNew;
        public Products()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelexpertsDataSet);

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products_suppliers' table. You can move, or remove it, as needed.
            this.products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.products_suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelexpertsDataSet.products);
            
            b_modified = false;
            b_addedNew = false;
        }

        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.travelexpertsDataSet);

        }

        private void prodNameTextBox_TextChanged(object sender, EventArgs e)
        {
            b_modified = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            b_modified = true;
            b_addedNew = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(b_addedNew)
            {
                MessageBox.Show("Wrong Action", "Message");
                return;
            }
            var result = MessageBox.Show("Do you really want Delete?", "Warning", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            int pId = Convert.ToInt32(productIdTextBox.Text);

            var test = (from m in this.travelexpertsDataSet.products_suppliers
                        where m.ProductId == pId
                        select m.SupplierId).ToArray();
            if (test.Length > 0)
            {
                MessageBox.Show("This is in using!", "Cannot Delete");
                return;
            }
            productsTableAdapter.DeleteQuery(pId);

            this.tableAdapterManager.UpdateAll(this.travelexpertsDataSet);
            this.productsTableAdapter.Fill(this.travelexpertsDataSet.products);
            b_modified = false;
            b_addedNew = false;
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

            if (b_addedNew)  // Insert new
            {
                productsTableAdapter.InsertQuery(prodNameTextBox.Text);
            }
            else  // Update modified
            {
                int pId = Convert.ToInt32(productIdTextBox.Text);
                productsTableAdapter.UpdateQuery(prodNameTextBox.Text, pId);
            }

            this.tableAdapterManager.UpdateAll(this.travelexpertsDataSet);
            this.productsTableAdapter.Fill(this.travelexpertsDataSet.products);
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

        private void Products_FormClosing(object sender, FormClosingEventArgs e)
        {
            checkSave();
        }

        private void bindingNavigator1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            checkSave();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            b_modified = false;
            b_addedNew = false;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            b_modified = false;
            b_addedNew = false;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            b_modified = false;
            b_addedNew = false;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            b_modified = false;
            b_addedNew = false;
        }
    }
}
