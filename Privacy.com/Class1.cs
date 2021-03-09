using System;
using System.Threading.Tasks;
using PrivacyCom.Models;

namespace PrivacyCom
{
    public class Class1
    {
        public async Task main()
        {
            var privacy = new Privacy("0075c03d-235b-4c69-8a6b-e27dc4200bf0", false);
            var model = new AddBank { RoutingNumber = "1039", AccountNumber = "238923208" };
            var res = await privacy.AddBank(model);
            Console.Write(res);
        }
    }
}
