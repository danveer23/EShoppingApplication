using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EShoppingCustomerLib;

namespace EShoppingCustomerLibTest
{
    [TestFixture]
    class CustomerProfileTest
    {
        CustomerProfile CustomerProfile_obj = new CustomerProfile();
        [Test]
        public void AddDetails()
        {
            CustomerProfile_obj.CustomerList.Clear();
            int x= CustomerProfile_obj.CustomerList.Count;
            Assert.AreEqual(x+1, CustomerProfile_obj.AddDetails("danny@gmail.com","danny",9876543210));


        }

        [Test]
        public void EditDetails()
        {
            int x = CustomerProfile_obj.AddDetails("danny@gmail.com", "danny", 9876543210);
            Assert.AreEqual(true, CustomerProfile_obj.EditDetails("danny@gmail.com"));

        }
    }
}
