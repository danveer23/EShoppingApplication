using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShoppingProductLib
{
    public class ProductCategory
    {
        public Dictionary<string, List<Product>> CategoryList = new Dictionary<string, List<Product>>();
          

        public int AddCategory(string categoryName)
        {
            if (!CategoryList.ContainsKey(categoryName))
            {
                CategoryList.Add(categoryName, new List<Product>());
                return CategoryList.Count;
            }
            return 0;
        }
        public int AddProductToCategory(Product p)
        {
            if (CategoryList.ContainsKey(p.Category))
            {
                CategoryList[p.Category].Add(p);
                return CategoryList[p.Category].Count;
            }
            return 0;
        }

        public int RemoveCategory(string categoryName)
        {
            if (CategoryList.ContainsKey(categoryName))
            {
                CategoryList.Remove(categoryName);
                return CategoryList.Count;
            }
            return 0;
        }
    }
}
