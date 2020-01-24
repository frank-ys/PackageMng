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
    public partial class dlgPackageDetail : Form
    {
        public dlgPackageDetail()
        {
            InitializeComponent();
        }

        private void packagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.packagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelexpertsDataSet);

        }

        private void dlgPackageDetale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelexpertsDataSet.packages_products_suppliers' table. You can move, or remove it, as needed.
            this.packages_products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.packages_products_suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.travelexpertsDataSet.suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelexpertsDataSet.products);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products_suppliers' table. You can move, or remove it, as needed.
            this.products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.products_suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.packages' table. You can move, or remove it, as needed.
            this.packagesTableAdapter.Fill(this.travelexpertsDataSet.packages);
        }


        private void packagesDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (packagesDataGridView.Rows.Count < 1 || packagesDataGridView.CurrentRow==null)
                return;
            var id = packagesDataGridView.CurrentRow.Cells[0].Value;
            if (String.IsNullOrEmpty(id.ToString()))
                return;

            var result = (from m in this.travelexpertsDataSet.packages_products_suppliers
                          where m.PackageId == (int)id
                          select m.ProductSupplierId).ToArray();

            String filter = "";
            if (result.Length == 0)  // filtering all for no product included in package
            {
                filter = "ProductSupplierId < 0";
            }
            else  // filtering all, but selected products
            {
                for (int i = 0; i < result.Length; i++)
                {
                    filter = filter + String.Format("(ProductSupplierId='{0}')", result[i]);
                    if (i + 1 != result.Length)
                        filter += " OR ";
                }
            }
            products_suppliersBindingSource.Filter = filter;
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            AddNewPkg addNewPkg = new AddNewPkg();
            addNewPkg.ShowDialog();
            if(addNewPkg.DialogResult== DialogResult.OK)
            {
                this.tableAdapterManager.UpdateAll(this.travelexpertsDataSet);
                this.packagesDataGridView.Update();
                this.packagesDataGridView.Refresh();
                this.packagesTableAdapter.Fill(this.travelexpertsDataSet.packages);
                this.packages_products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.packages_products_suppliers);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            
            var id = packagesDataGridView.CurrentRow.Cells[0].Value;
            if (String.IsNullOrEmpty(id.ToString()))
                return;


            UpdatePkgDlg updatePkgDlg = new UpdatePkgDlg();
            updatePkgDlg.packageId = (int)packagesDataGridView.CurrentRow.Cells[0].Value;
            updatePkgDlg.pkgNameTextBox.Text= (String)packagesDataGridView.CurrentRow.Cells[1].Value;

            // DateTime doesn't allow null. Put Today instead, if it is null.
            DateTime? startDT = (DateTime?)packagesDataGridView.CurrentRow.Cells[2].Value;  // for processing NULL
            DateTime? endDT = (DateTime?)packagesDataGridView.CurrentRow.Cells[3].Value;  // for processing NULL
            updatePkgDlg.pkgStartDateDateTimePicker.Value = (DateTime)(startDT!=null ? startDT : DateTime.Today);
            updatePkgDlg.pkgEndDateDateTimePicker.Value = (DateTime)(endDT != null ? endDT : DateTime.Today);

            updatePkgDlg.pkgDescTextBox.Text= (String)packagesDataGridView.CurrentRow.Cells[4].Value;
            updatePkgDlg.pkgBasePriceTextBox.Text= packagesDataGridView.CurrentRow.Cells[5].Value.ToString();
            updatePkgDlg.pkgAgencyCommissionTextBox.Text= packagesDataGridView.CurrentRow.Cells[6].Value.ToString();


            updatePkgDlg.ShowDialog();
            if (updatePkgDlg.DialogResult == DialogResult.OK)
            {
                this.tableAdapterManager.UpdateAll(this.travelexpertsDataSet);
                this.packages_products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.packages_products_suppliers);
                this.packagesDataGridView.Update();
                this.packagesDataGridView.Refresh();

                var result = (from m in this.travelexpertsDataSet.packages_products_suppliers
                              where m.PackageId == (int)id
                              select m.ProductSupplierId).ToArray();

                String filter = "";
                if (result.Length == 0)  // filtering all for no product included in package
                {
                    filter = "ProductSupplierId < 0";
                }
                else  // filtering all, but selected products
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        filter = filter + String.Format("(ProductSupplierId='{0}')", result[i]);
                        if (i + 1 != result.Length)
                            filter += " OR ";
                    }
                }
                products_suppliersBindingSource.Filter = filter;

            }
        }
    }
}
