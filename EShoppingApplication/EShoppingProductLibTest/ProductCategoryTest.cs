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
    class ProductCategoryTest
    {
        ProductCategory ProductCategory_obj = new ProductCategory();
        [Test]
        public void AddCategory()
        {
            int x = ProductCategory_obj.CategoryList.Count;
            Assert.AreEqual(x + 1, ProductCategory_obj.AddCategory("Electronics"));
            ProductCategory_obj.CategoryList.Remove("Electronics");
        }

        [Test]
        public void AddProductToCategory()
        {
            int c = ProductCategory_obj.AddCategory("Electronics");
            Product p = new Product();
            p.ID = "pr1";
            p.Name = "Samsung";
            p.Cost = 10000;
            p.Category = "Electronics";

            int x = ProductCategory_obj.CategoryList[p.Category].Count;
            Assert.AreEqual(x + 1, ProductCategory_obj.AddProductToCategory(p));
            ProductCategory_obj.CategoryList.Remove("Electronics");
        }

        [Test]
        public void RemoveCategory()
        {
            int c = ProductCategory_obj.AddCategory("Electronics");
            int x = ProductCategory_obj.CategoryList.Count;
            Assert.AreEqual(x-1, ProductCategory_obj.RemoveCategory("Electronics"));
        }
    }
}
