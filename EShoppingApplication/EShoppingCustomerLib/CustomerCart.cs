using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShoppingProductLib;
using EShoppingCustomerLib;

namespace EShoppingCustomerLib
{
    public class CustomerCart
    {
        public CustomerProfile CustomerProfile_obj = new CustomerProfile();
        public int AddProductToCart(Product p,Customer c)
        {
           
            foreach (Customer ci in CustomerProfile_obj.CustomerList)
            {
                if (ci.EmailId == c.EmailId)
                {
                    c.Cart.Add(p);
                    return c.Cart.Count;
                }

            }

            return 0;
        }

        public int RemoveProductFromCart(Product p, Customer c)
        {
           
            foreach (Customer ci in CustomerProfile_obj.CustomerList)
            {
                if (ci.EmailId == c.EmailId && c.Cart.Contains(p))
                {

                    c.Cart.Remove(p);
                    return c.Cart.Count;
                }

            }
            return 0;
        }
        public List<Product> GetCustomerCartDetail(Customer c)
        {
            return c.Cart;

        }
    }
}
