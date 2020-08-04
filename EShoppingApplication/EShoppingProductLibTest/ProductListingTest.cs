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
    class ProductListingTest
    {
         ProductListing ProductListing_obj = new ProductListing();
        [Test]
        public void ListProductBasedOnCategory()
        {
           
            int c = ProductListing_obj.ProductCategory_obj.AddCategory("Electronics");
            Product p = new Product();
            p.ID = "pr1";
            p.ID = "Samsung";
            p.Cost = 10000;
            p.Category = "Electronics";
            int y = ProductListing_obj.ProductCategory_obj.AddProductToCategory(p);
            Assert.AreEqual(ProductListing_obj.ProductCategory_obj.CategoryList["Electronics"], ProductListing_obj.ListProductBasedOnCategory("Electronics"));
            

        }
    }
}
