using ProductDb.Data;
using ProductDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDb.Services
{
    public class CategoryActions
    {
        ProductsDbCntxt dbCntxt = new ProductsDbCntxt();

        public List<Category> GetCategories()
        {
            //Category of the Product
            return dbCntxt.Categories.ToList();
        }

        public Category GetCategoryByID(int ID)
        {
            //For editing and deleting
            return dbCntxt.Categories.Find(ID);

        }

        public bool CatNameEmpty(Category category)
        {
            bool NameEmpty = false;
            if (category.Name == "")
            {
                NameEmpty = true;
            }
            return NameEmpty;
        }
        public void AddCategory(Category category)
        {
            //Adding a new category
            dbCntxt.Categories.Add(category);
            dbCntxt.SaveChanges();

        }

        public void UpdateCategory(Category category)
        {
            //Updating an existing category
            dbCntxt.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbCntxt.SaveChanges();

        }

        public void DeleteCategory(Category category)
        {
            //Deleting an existing category
            dbCntxt.Remove(category);
            dbCntxt.SaveChanges();

        }
        public bool DoesCategoryExist(Category currentCategory)
        {
            bool checkCat = false;
            foreach (var category in dbCntxt.Categories)
            {
                if (category.Name == currentCategory.Name)
                {
                    checkCat = true;
                }
            }
            return checkCat;
        }

        public bool IsCategoryEmpty(Category currentCategory)
        {
            bool checkNotEmpty = true;
            foreach (var product in dbCntxt.Products)
            {
                if (product.CategoryID == currentCategory.ID)
                {
                    checkNotEmpty = false;
                }
            }
            return checkNotEmpty;
        }




    }
}
