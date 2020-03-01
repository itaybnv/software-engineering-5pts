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

        public List<employee> Employees { get; set; }


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

            dataHandler.AddData(emp);
            Employees = dataHandler.GetData();

        }
    }
}
