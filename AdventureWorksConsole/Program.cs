using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorksDAL;
using Microsoft.SqlServer.Types;
using System.Data.Entity.SqlServer;

namespace AdventureWorksConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            SqlProviderServices.SqlServerTypesAssemblyName = "Microsoft.SqlServer.Types, Version=14.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91";
           
            
            using (var context = new AdventureWorks2014Entities())
            {

                var adr = context.Address.Take(100);
                foreach (var address in adr)
                {
                    Console.WriteLine("address: " + address.AddressLine1+ "  --  city: " + address.City);
                }
            }

        }
    }
}
