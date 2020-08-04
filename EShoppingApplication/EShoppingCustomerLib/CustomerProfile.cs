using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShoppingUtilitiesLib;

namespace EShoppingCustomerLib
{
    public class CustomerProfile
    {
       public List<Customer> CustomerList = new List<Customer>();
        CommonUtilities CUtilities= new CommonUtilities();
        public int AddDetails(string emailid,string name,long phoneno)
        {
           
            if (CUtilities.VerifyEmailId() && CUtilities.VerifyPhoneNo())
            {
                Customer c = new Customer();
                c.EmailId = emailid;
                c.Name = name;
                c.PhoneNo = phoneno;
                CustomerList.Add(c);
                return CustomerList.Count; ;
            }
            return 0;
        }

        public bool EditDetails(string emailid)
        {
            foreach (Customer c in CustomerList)
            {
                if (c.EmailId == emailid)
                {
                    // Edit customer detail.
                    return true;
                }
            }
            return false;

        }
    }
}
