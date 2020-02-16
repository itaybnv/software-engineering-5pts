using ClothingShop.Views;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ClothingShop.ViewModels
{
    class EmployeesViewModel : Screen, INotifyPropertyChanged
    {
        public DataHandlers.EmployeeDataHandler dataHandler = new DataHandlers.EmployeeDataHandler();
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


        public EmployeesViewModel()
        {
            Employees = dataHandler.GetData();
        }

        public void AddEmployee()
        {
            employee emp = new employee();
            AddEmployee addWindow = new AddEmployee();

            emp.start_date = DateTime.Now;
            addWindow.DataContext = new { employee = emp, types = dataHandler.GetEntities().employee_type.ToList() };
            addWindow.ShowDialog();

            System.Diagnostics.Debug.WriteLine("test");
            dataHandler.AddData(emp);
            Employees = dataHandler.GetData();

        }
    }
}
