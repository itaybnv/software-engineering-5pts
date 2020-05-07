using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClothingShop.DataHandlers
{
    class EmployeeTypesDataHandler : DataHandler<employee_type>
    {
        private bool VerifyString(string name)
        {
            Regex nameRegex = new Regex(@"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$");

            return nameRegex.IsMatch(name);
        }

        private bool VerifySalery(double salery)
        {
            return salery != 0;
        }

        protected override void VerifyItem(employee_type type)
        {
            if (!VerifyString(type.title))
            {
                throw new Exception("title incorrect");
            }
            else if (!VerifySalery(type.salery))
            {
                throw new Exception("Salery Incorrect");
            }
        }
    }
}
