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
    
    public partial class Supplier : Form
    {
        private bool b_modified;
        private bool b_addedNew;
        public Supplier()
        {
            InitializeComponent();
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelexpertsDataSet);

        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products_suppliers' table. You can move, or remove it, as needed.
            this.products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.products_suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products_suppliers' table. You can move, or remove it, as needed.
            this.products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.products_suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products_suppliers' table. You can move, or remove it, as needed.
            this.products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.products_suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.travelexpertsDataSet.suppliers);

            b_modified = false;
            b_addedNew = false;
        }

        private void supNameTextBox_TextChanged(object sender, EventArgs e)
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
            var result = MessageBox.Show("Do you really want Delete?", "Warning", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            int sId = Convert.ToInt32(supplierIdTextBox.Text);

            var test = (from m in this.travelexpertsDataSet.products_suppliers
                        where m.SupplierId == sId
                        select m.ProductId).ToArray();
            if (test.Length > 0)
            {
                MessageBox.Show("This is in using!", "Cannot Delete");
                return;
            }
            suppliersTableAdapter.DeleteQuery(sId);

            this.tableAdapterManager.UpdateAll(this.travelexpertsDataSet);
            this.suppliersTableAdapter.Fill(this.travelexpertsDataSet.suppliers);
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
                suppliersTableAdapter.InsertQuery(supNameTextBox.Text);
            }
            else  // Update modified
            {
                int sId = Convert.ToInt32(supplierIdTextBox.Text);
                suppliersTableAdapter.UpdateQuery(supNameTextBox.Text, sId);
            }

            this.tableAdapterManager.UpdateAll(this.travelexpertsDataSet);
            this.suppliersTableAdapter.Fill(this.travelexpertsDataSet.suppliers);
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

        private void Supplier_FormClosing(object sender, FormClosingEventArgs e)
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
