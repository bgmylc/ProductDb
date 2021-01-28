using ProductDb.Migrations;
using ProductDb.Models;
using ProductDb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDb.Services
{
    public class ProductActions
    {
        ProductsDbCntxt dbCntxt = new ProductsDbCntxt();

        public List<Product> GetProducts()
        {
            //To view and to select products
            return dbCntxt.Products.ToList();
        }
        

        public Product GetProductByID(int ID)
        {
            //For editing and deleting
            return dbCntxt.Products.Find(ID);
        
        }

        public void AddProduct(Product product)
        {
            //Adding a new product
            dbCntxt.Products.Add(product);
            dbCntxt.SaveChanges();
        
        }

        public void UpdateProduct(Product product)
        {
            //Updating an existing product
            dbCntxt.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbCntxt.SaveChanges();
        
        }

        public void DeleteProduct(Product product)
        {
            //Deleting an existing product
            dbCntxt.Remove(product);
            dbCntxt.SaveChanges();
        
        }





    }
}
