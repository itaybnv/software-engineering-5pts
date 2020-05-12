using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClothingShop.DataHandlers
{
    class MerchandiseDataHandler : DataHandler<merchandise>
    {
        private bool VerifyString(string name)
        {
            Regex nameRegex = new Regex(@"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$");

            return nameRegex.IsMatch(name);
        }

        protected override void VerifyItem(merchandise item)
        {
            if (!VerifyString(item.name))
            {
                throw new Exception("Name incorrect");
            }
            else if (!VerifyString(item.merchandise_category.clothing_type))
            {
                throw new Exception("Clothing type incorrect");
            }
            else if (!VerifyString(item.merchandise_category.targeted_customer))
            {
                throw new Exception("targeted customer incorrect");
            }
            else if (!VerifyString(item.size))
            {
                throw new Exception("size incorrect");
            } 

        }
    }
}
