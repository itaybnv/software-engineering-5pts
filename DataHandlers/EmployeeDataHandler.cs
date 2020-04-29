using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClothingShop.DataHandlers
{
    class EmployeeDataHandler : DataHandler<employee>
    {
        private bool VerifyName(string name)
        {
            Regex nameRegex = new Regex(@"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$");

            return nameRegex.IsMatch(name);
        }

        private bool VerifyPhone(string phone)
        {
            Regex phoneRegex = new Regex(@"^\+?(972|0)(\-)?0?(([23489]{1}\d{7})|[5]{1}\d{8})$");

            return phoneRegex.IsMatch(phone);
        }

        protected override bool VerifyItem(employee item)
        {
            return VerifyName(item.first_name) && VerifyName(item.last_name) && VerifyPhone(item.phone_number) && VerifyName(item.address);
        }
    }
}
