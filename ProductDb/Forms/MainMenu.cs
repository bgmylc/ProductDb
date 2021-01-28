using ProductDb.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductDb
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            ProductActionsForm productActions = new ProductActionsForm();
            productActions.Show();
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            CategoryActionsForm categoryActions = new CategoryActionsForm();
            categoryActions.Show();
        }
    }
}
