using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductDb.Migrations;
using ProductDb.Models;
using ProductDb.Services;
using Microsoft.EntityFrameworkCore;
namespace ProductDb.Forms
{
    public partial class ProductActionsForm : Form
    {
        public ProductActionsForm()
        {
            InitializeComponent();
            getProductsToSelect();
            getCategoriesToSelect();
        }

        ProductActions productActions = new ProductActions();
        CategoryActions categoryActions = new CategoryActions();
        Product selectedProduct = null;
        private void getProductsToSelect()
        {
            comboBoxProduct.DataSource = productActions.GetProducts();
            comboBoxProduct.DisplayMember = "Name";
            comboBoxProduct.ValueMember = "ID";
        }

        private void getCategoriesToSelect()
        {
            comboBoxProCat.DataSource = categoryActions.GetCategories();
            comboBoxProCat.DisplayMember = "Name";
            comboBoxProCat.ValueMember = "ID";
        }

        private void buttonProAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = textBoxProductName.Text;
            
            int selectedCategoryID = (int)comboBoxProCat.SelectedValue;
            product.CategoryID = selectedCategoryID;

            Decimal.TryParse(textBoxProductPrice.Text, out decimal proPrice);
            product.Price = proPrice;

            product.Info = textBoxProductInfo.Text;


            if (productActions.DoesProductExist(product))
            {
                MessageBox.Show($"Product {product.Name} already exists. Please try adding another product.", "Existing Product");
                
            }
            else if (productActions.ProNameEmpty(product))
            {
                MessageBox.Show("Product name cannot be empty! Please enter a name.", "Enter a name");
            }
            else
            {
                productActions.AddProduct(product);
                getProductsToSelect();
            }
            

        }

        private void comboBoxProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedID = (int)comboBoxProduct.SelectedValue;

            selectedProduct = productActions.GetProductByID(selectedID);

            textBoxProductName.Text = selectedProduct.Name;
            textBoxProductPrice.Text = selectedProduct.Price.ToString();
            textBoxProductInfo.Text = selectedProduct.Info;
            comboBoxProCat.SelectedValue = selectedProduct.CategoryID;

            buttonProUpdate.Enabled = true;
            buttonProDelete.Enabled = true;

        }

        private void buttonProUpdate_Click(object sender, EventArgs e)
        {
            selectedProduct.Name = textBoxProductName.Text;
          
            int selectedCategoryID = (int)comboBoxProCat.SelectedValue;
            selectedProduct.CategoryID = selectedCategoryID;

            Decimal.TryParse(textBoxProductPrice.Text, out decimal proPrice);
            selectedProduct.Price = proPrice;

            selectedProduct.Info = textBoxProductInfo.Text;

            productActions.UpdateProduct(selectedProduct);
            getProductsToSelect();
        }

        private void buttonProDelete_Click(object sender, EventArgs e)
        {
            productActions.DeleteProduct(selectedProduct);
            getProductsToSelect();
        }

        private void buttonProList_Click(object sender, EventArgs e)
        {
            ProductListForm productList = new ProductListForm();
            productList.Show();
        }
    }
}
