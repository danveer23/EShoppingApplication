using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EShoppingCustomerLib;
using EShoppingProductLib;

namespace EShoppingCustomerLibTest
{
    [TestFixture]
    class CustomerOrderTest
    {
        CustomerOrder co = new CustomerOrder();
        [Test]
        public void OrderProduct()
        {
            Customer c = new Customer();
            c.Cart.Clear();
            c.Name = "danny";
            c.EmailId= "danny@gmail.com";
            c.PhoneNo= 9876543210;
            int x=co.ProductSearch_obj.ProductCategory_obj.AddCategory("Electronics");
            Product p = new Product();
            p.ID = "pr1";
            p.Name = "Samsung";
            p.Cost = 10000;
            p.Category = "Electronics";
            int y = co.ProductSearch_obj.ProductCategory_obj.AddProductToCategory(p);
            int z=co.CustomerCart_obj.CustomerProfile_obj.AddDetails( c.EmailId,c.Name,c.PhoneNo);
            //int a = co.cc.AddProductToCart(p,"danny@gmail.com");
            Assert.AreEqual(true,co.OrderProduct("Samsung",c));

        }
        //[Test]
        //public void CancelProduct()
        //{
        //    //
        //}
    }
}
