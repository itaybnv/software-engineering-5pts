using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClothingShop.DataHandlers
{
    class CustomerDataHandler : DataHandler<customer>
    {
        private bool VerifyString(string name)
        {
            Regex nameRegex = new Regex(@"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$");

            return nameRegex.IsMatch(name);

        }

        protected override void VerifyItem(customer item)
        {
            if (!VerifyString(item.firstname))
            {
                throw new Exception("First name incorrect");
            } else if (!VerifyString(item.lastname))
            {
                throw new Exception("Last name incorrect"); 
            }
        }
    }
}
