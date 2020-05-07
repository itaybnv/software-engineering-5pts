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
        private bool VerifyString(string name)
        {
            Regex nameRegex = new Regex(@"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$");

            return nameRegex.IsMatch(name);
        }

        private bool VerifyPhone(string phone)
        {
            Regex phoneRegex = new Regex(@"^\+?(972|0)(\-)?0?(([23489]{1}\d{7})|[5]{1}\d{8})$");

            return phoneRegex.IsMatch(phone);
        }

        protected override void VerifyItem(employee item)
        {
            if(!VerifyString(item.first_name))
            {
                throw new Exception("First name incorrect");
            }
            else if (!VerifyString(item.last_name))
            {
                throw new Exception("Last name incorrect");
            }
            else if (!VerifyPhone(item.phone_number))
            {
                throw new Exception("Phone number incorrect");
            }
            else if (!VerifyString(item.address))
            {
                throw new Exception("Address incorrect");
            }
            
        }
    }
}
