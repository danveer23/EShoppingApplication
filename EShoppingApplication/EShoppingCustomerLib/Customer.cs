using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShoppingProductLib;

namespace EShoppingCustomerLib
{
    public class Customer
    {
        private string m_EmailId;
        private string m_Name;
        private long m_PhoneNo;
       private List<Product> m_cart = new List<Product>();

        public string EmailId
        {
            get
            {
                return m_EmailId;
            }

            set
            {
                m_EmailId = value;
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

        public long PhoneNo
        {
            get
            {
                return m_PhoneNo;
            }

            set
            {
                m_PhoneNo = value;
            } 
        }

        public List<Product> Cart
        {
            get
            {
                return m_cart;
            }
            set
            {
                m_cart = value;
            }
        }
    }
}
