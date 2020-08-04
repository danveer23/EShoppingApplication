using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShoppingProductLib;

namespace EShoppingProductLib
{
    public class ProductSearch
    {
        public ProductCategory ProductCategory_obj = new ProductCategory();
        public Product SearchProductByName(string ProductName)
        {  
            Product pr = null;
            
            foreach (var item in ProductCategory_obj.CategoryList.Values)
            {
      
                foreach (Product p in item)
                {
                    if (p.Name == ProductName)
                    {
                        return p;
                    }
                }

            }
            return pr;

        }

        public Product SearchProductByID(string id)
        {
            Product pr = null;
          
            foreach (var item in ProductCategory_obj.CategoryList.Values)
            {
                foreach (Product p in item)
                {
                    if (p.ID == id)
                    {
                        return p;
                    }
                }

            }
            return pr;

        }
    }
}
