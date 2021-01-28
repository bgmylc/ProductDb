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
    public partial class CategoryListForm : Form
    {
        public CategoryListForm()
        {
            InitializeComponent();
            getCategoriestoView();
        }

        CategoryActions categoryActions = new CategoryActions();
        private void getCategoriestoView()
        {
            dataGridViewCatList.DataSource = categoryActions.GetCategories();
        }

    }
}
