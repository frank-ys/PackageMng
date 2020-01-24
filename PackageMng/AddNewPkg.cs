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
    public partial class AddNewPkg : Form
    {
        public AddNewPkg()
        {
            InitializeComponent();
        }

        private void packagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.packagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelexpertsDataSet);

        }

        private void AddNewPkg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelexpertsDataSet.suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.travelexpertsDataSet.suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelexpertsDataSet.products);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products_suppliers' table. You can move, or remove it, as needed.
            this.products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.products_suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.packages_products_suppliers' table. You can move, or remove it, as needed.
            this.packages_products_suppliersTableAdapter.Fill(this.travelexpertsDataSet.packages_products_suppliers);
            // TODO: This line of code loads data into the 'travelexpertsDataSet.packages' table. You can move, or remove it, as needed.
            this.packagesTableAdapter.Fill(this.travelexpertsDataSet.packages);

            var result = (from m in this.travelexpertsDataSet.products_suppliers
                          where true
                          select new { m.ProductSupplierId, m.ProdName, m.SupName }).ToList();  //.ProductSupplierId

            foreach (var m in result)
            {
                var arr = new string[] { String.Format("{0,3}",m.ProductSupplierId), m.ProdName, m.SupName };
                ListViewItem itm = new ListViewItem(arr);
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
            DateTime? startDT = pkgStartDateDateTimePicker?.Value.Date;  // for accept NULL
            DateTime? endDT = pkgEndDateDateTimePicker?.Value.Date;  // for accept NULL

            if (startDT > endDT)
            {
                MessageBox.Show("Input Error", "Start Date is earlier than End Date");
                return;
            }
            packagesTableAdapter.InsertQuery( pkgNameTextBox.Text, startDT, endDT,
                pkgDescTextBox.Text, Convert.ToDecimal(pkgBasePriceTextBox.Text),
                (pkgAgencyCommissionTextBox.Text.Length!=0) ? Convert.ToDecimal(pkgAgencyCommissionTextBox.Text) : (Decimal?)null);

            var pkgId = Convert.ToInt32(packagesTableAdapter.GetNewIdQuery());  // get new packageID just inserted above.
            for (int i = 0; i < listPackage.Items.Count; i++)
            {
                var prdId = Convert.ToInt32(listPackage.Items[i].Text.Trim(' '));
                packages_products_suppliersTableAdapter.Insert(pkgId, prdId);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime? startDT = pkgStartDateDateTimePicker?.Value.Date;  // for accept NULL
            DateTime? endDT = pkgEndDateDateTimePicker?.Value.Date;  // for accept NULL
           // startDT = (startDT!=null) ? startDT : DateTime.Today;
        }
    }
}
