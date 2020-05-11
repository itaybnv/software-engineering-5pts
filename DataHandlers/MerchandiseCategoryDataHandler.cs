using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClothingShop.DataHandlers
{
    class MerchandiseCategoryDataHandler : DataHandler<merchandise_category>
    {
        private bool VerifyString(string name)
        {
            Regex nameRegex = new Regex(@"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$");

            return nameRegex.IsMatch(name);
        }

        protected override void VerifyItem(merchandise_category item)
        {
            if (!VerifyString(item.clothing_type))
            {
                throw new Exception("Clothing type incorrect");
            }
            else if (!VerifyString(item.targeted_customer))
            {
                throw new Exception("Targeted customer incorrect");
            }
        }

    }
}
