using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksDAL
{
    public class Class1
    {
        public void test()
        {

            using (var context = new AdventureWorks2014Entities())
            {
                foreach (var address in context.Address)
                {
                    Console.WriteLine(address.AddressID);
                }
            }
        }
    }
}
