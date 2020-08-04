using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShoppingProductLib
{
    public class Product
    {
        private string m_ID;
        private string m_Name;
        private int m_Cost;
      private string m_Category;

        public string ID
        {
            get
            {
                return m_ID;
            }

            set
            {
                m_ID = value;
            }
        }

        public string Name
        {
            get
            {
                return m_Name;
            }

            set
            {
                m_Name = value;
            }
        }

        public int Cost
        {
            get
            {
                return m_Cost;
            }

            set
            {
                m_Cost = value;
            }
        }

        public string Category
        {
            get
            {
                return m_Category;
            }
            set
            {
                m_Category = value;
            }
        }
    }
}
