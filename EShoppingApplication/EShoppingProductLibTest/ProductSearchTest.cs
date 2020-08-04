using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EShoppingProductLib;


namespace EShoppingProductLibTest
{
    [TestFixture]
    class ProductSearchTest
    {
        ProductSearch ProductSearch_obj = new ProductSearch();
        [Test]
        public void SearchProductByName()
        {

            ProductSearch_obj.ProductCategory_obj.CategoryList.Clear();
            int c = ProductSearch_obj.ProductCategory_obj.AddCategory("Electronics");
            Product p = new Product();
            p.ID = "pr1";
            p.Name = "Samsung";
            p.Cost = 10000;
            p.Category = "Electronics";
            int x = ProductSearch_obj.ProductCategory_obj.AddProductToCategory(p);
            Assert.AreEqual(p, ProductSearch_obj.SearchProductByName("Samsung"));
            
            




        }

        [Test]
        public void SearchProductByID()
        {
            ProductSearch_obj.ProductCategory_obj.CategoryList.Clear();
            int c = ProductSearch_obj.ProductCategory_obj.AddCategory("Electronics");
            Product p = new Product();
            p.ID = "pr1";
            p.Name = "Samsung";
            p.Cost = 10000;
            p.Category = "Electronics";
            int x = ProductSearch_obj.ProductCategory_obj.AddProductToCategory(p);
            Assert.AreEqual(p, ProductSearch_obj.SearchProductByID("pr1"));
            
        }
    }
}
