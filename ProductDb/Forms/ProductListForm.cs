using ProductDb.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductDb.Forms
{
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
            getProductstoView();
        }

        ProductActions productActions = new ProductActions();
        private void getProductstoView()
        {
            dataGridViewProList.DataSource = productActions.GetProducts();
        }

        
    }
}
