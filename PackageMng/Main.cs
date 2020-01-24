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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelexpertsDataSet.products_suppliers' table. You can move, or remove it, as needed.
        }

        private void btn_pkg_details_Click(object sender, EventArgs e)
        {
            dlgPackageDetail pkg_dlg = new dlgPackageDetail();
            pkg_dlg.ShowDialog();
        }

        private void btn_prodSupp_Click(object sender, EventArgs e)
        {
            dlgProdSupp prodsupp_dlg = new dlgProdSupp();
            prodsupp_dlg.ShowDialog();
            
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Products product_dlg = new Products();
            product_dlg.ShowDialog();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            Supplier supplier_dlg = new Supplier();
            supplier_dlg.ShowDialog();
            
        }
    }
}
