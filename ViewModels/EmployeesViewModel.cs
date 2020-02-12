using ClothingShop.Views;
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
            set
            {
                _employees = value;
                NotifyOfPropertyChange("Employees");
            }
        }


        public EmployeesViewModel(dbEntities _db)
        {
            db = _db;
            Employees = db.employee.ToList();
        }

        public void AddEmployee()
        {
            employee emp = new employee();
            AddEmployee add = new AddEmployee();

            emp.start_date = DateTime.Now;
            add.DataContext = new { employee = emp, types = db.employee_type.ToList() };
            add.ShowDialog();

            db.employee.Add(emp);
            db.SaveChanges();

            Employees = db.employee.ToList();

        }
    }
}
