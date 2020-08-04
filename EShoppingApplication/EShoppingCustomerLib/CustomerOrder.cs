using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShoppingProductLib;
using EShoppingCustomerLib;

namespace EShoppingCustomerLib
{
    public class CustomerOrder
    {
      public ProductSearch ProductSearch_obj= new ProductSearch();
      public CustomerCart CustomerCart_obj = new CustomerCart();
        public bool OrderProduct(string productname, Customer c)
        {
            Product p = ProductSearch_obj.SearchProductByName(productname);
            if (CustomerCart_obj.AddProductToCart(p,c)>0)
            {
                if (c.Cart.Contains(p))
                {
                    return true;
                }
            }
            return false;
        }

        //public bool CancelProduct(string productname, Customer c)
        //{
        //    Product p = ps.SearchProductByName(productname);
        //    if (cc.AddProductToCart(p, c) > 0)
        //    {
        //        if (c.Cart.Contains(p))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;

        //}

        //public void ReOrderProduct()
        //{

        //}

        //public void ViewOrderHistory()
        //{

        //}

    }
}
