using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.ViewModels
{
    class EmployeesViewModel : Screen
    {
        public dbEntities db { get; set; }
        private List<employee> _employees;

        public List<employee> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }


        public EmployeesViewModel(dbEntities _db)
        {
            db = _db;
            Employees = db.employee.ToList();
        }
    }
}
