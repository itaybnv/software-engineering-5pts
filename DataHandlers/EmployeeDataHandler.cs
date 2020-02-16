using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.DataHandlers
{
    class EmployeeDataHandler : DataHandler<employee>
    {

        protected override bool VerifyItem(employee item)
        {
            return true;
        }
    }
}
