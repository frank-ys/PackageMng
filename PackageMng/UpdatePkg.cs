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
    public partial class UpdatePkgDlg : Form
    {
        public UpdatePkgDlg()
        {
            InitializeComponent();
        }

        private void packagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.packagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelexpertsDataSet);

        }

        private void UpdatePkg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products_suppliers' table. You can move, or remove it, as needed.
            this.products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.products_suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.packages_products_suppliers' table. You can move, or remove it, as needed.
            this.packages_products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.packages_products_suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.packages' table. You can move, or remove it, as needed.
            this.packagesTableAdapter.Fill(this.travelexpertsDataSet.packages);

            var ps_result = (from tp in this.travelexpertsDataSet.products_suppliers
                          where true
                          select new { tp.ProductSupplierId, tp.ProdName, tp.SupName }).ToList();  //.ProductSupplierId

           // int pkgId = Convert.ToInt32(packageIdTextBox.Text);
            var p_ps_result = (from tp in this.travelexpertsDataSet.packages_products_suppliers  //products_suppliers
                             where tp.PackageId == packageId
                             select  tp.ProductSupplierId ).ToArray();  //.ProductSupplierId


            foreach (var m in ps_result)
            {
                var arr = new string[] { String.Format("{0,3}", m.ProductSupplierId), m.ProdName, m.SupName };
                ListViewItem itm = new ListViewItem(arr);
                if (Array.Find(p_ps_result, i => i == m.ProductSupplierId)!=0)
                    this.listPackage.Items.Add(itm);
                else
                    this.listProdSupp.Items.Add(itm);
                //listProdSupp.Items.Add(m.ProductSupplierId.ToString(), m.ProdName, m.SupName);
                //this.lb_products.Items.Add(ps_id.ProductSupplierId);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //TO: listPackage   FROM: listProdSupp
            if (listProdSupp.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select Item!");
                return;
            }
            int i = listProdSupp.SelectedIndices[0];
            var item = listProdSupp.Items[i];

            listProdSupp.Items.Remove(item);
            listPackage.Items.Add(item);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            //TO: listProdSupp   FROM: listPackage
            if (listPackage.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select Item!");
                return;
            }

            int i = listPackage.SelectedIndices[0];
            var item = listPackage.Items[i];

            listPackage.Items.Remove(item);
            listProdSupp.Items.Add(item);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime? startDT = pkgStartDateDateTimePicker?.Value.Date; // for accept NULL
            DateTime? endDT = pkgEndDateDateTimePicker?.Value.Date; // for accept NULL
            if (startDT > endDT)
            {
                MessageBox.Show("Input Error", "Start Date is earlier than End Date");
                return;
            }
            packagesTableAdapter.UpdateQuery(pkgNameTextBox.Text, startDT, endDT,
                pkgDescTextBox.Text, Convert.ToDecimal(pkgBasePriceTextBox.Text),
                (pkgAgencyCommissionTextBox.Text.Length != 0) ? Convert.ToDecimal(pkgAgencyCommissionTextBox.Text) : (Decimal?)null,  //Convert.ToDecimal(pkgAgencyCommissionTextBox.Text
                packageId);

            packages_products_suppliersTableAdapter.DeleteQuery(packageId);

             for (int i = 0; i < listPackage.Items.Count; i++)
             {
                 var prdId = Convert.ToInt32(listPackage.Items[i].Text.Trim(' '));
                 packages_products_suppliersTableAdapter.Insert(packageId, prdId);
             }
             
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
