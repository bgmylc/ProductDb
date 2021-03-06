﻿using ProductDb.Models;
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
    public partial class CategoryActionsForm : Form
    {
        public CategoryActionsForm()
        {
            InitializeComponent();
            getCategoriesToSelect();
        }
        CategoryActions categoryActions = new CategoryActions();
        Category selectedCategory = null;
        private void getCategoriesToSelect()
        {
            comboBoxCategories.DataSource = categoryActions.GetCategories();
            comboBoxCategories.DisplayMember = "Name";
            comboBoxCategories.ValueMember = "ID";
        }

        private void buttonCatAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = textBoxCatName.Text;

            category.Info = textBoxCatInfo.Text;

            if (categoryActions.DoesCategoryExist(category))
            {
                MessageBox.Show($"Category {category.Name} already exists. Try adding another category.","Existing Category");
            }
            else if (categoryActions.CatNameEmpty(category))
            {
                MessageBox.Show("Category name cannot be empty! Please enter a name.", "Enter a name");
            }
            else
            {
                categoryActions.AddCategory(category);
                getCategoriesToSelect();
            }
            
        }
        private void comboBoxCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedID = (int)comboBoxCategories.SelectedValue;

            selectedCategory = categoryActions.GetCategoryByID(selectedID);

            textBoxCatName.Text = selectedCategory.Name;
            textBoxCatInfo.Text = selectedCategory.Info;

            buttonCatUpdate.Enabled = true;
            buttonCatDelete.Enabled = true;
        }
        private void buttonCatUpdate_Click(object sender, EventArgs e)
        {
            selectedCategory.Name = textBoxCatName.Text;
            selectedCategory.Info = textBoxCatInfo.Text;

            categoryActions.UpdateCategory(selectedCategory);
            getCategoriesToSelect();
        }

        private void buttonCatDelete_Click(object sender, EventArgs e)
        {
            if (!categoryActions.IsCategoryEmpty(selectedCategory))
            {
                MessageBox.Show($"{selectedCategory.Name} category is not empty. You can't delete it!", "Filled Category");
            }
            else
            {
                categoryActions.DeleteCategory(selectedCategory);
                getCategoriesToSelect();
            }
            
        }

        private void buttonCatList_Click(object sender, EventArgs e)
        {
            CategoryListForm categoryList = new CategoryListForm();
            categoryList.Show();
        }
    }
}
