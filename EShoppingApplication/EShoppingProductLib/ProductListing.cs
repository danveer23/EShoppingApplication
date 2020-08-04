using EShoppingProductLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShoppingProductLib
{
    public class ProductListing
    {

        public ProductCategory ProductCategory_obj = new ProductCategory();

        public List<Product> ListProductBasedOnCategory(string categoryName)
        {
          
            List<Product> lp = new List<Product>();
            
            if (ProductCategory_obj.CategoryList.ContainsKey(categoryName) && ProductCategory_obj.CategoryList[categoryName].Count > 0)
            {
             
                return ProductCategory_obj.CategoryList[categoryName];
            }
            return lp;
        }

    }
}
