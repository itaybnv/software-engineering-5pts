using ClothingShop.Views;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;

namespace ClothingShop.ViewModels
{
    class EmployeesViewModel : Screen, INotifyPropertyChanged
    {
        public DataHandlers.EmployeeDataHandler dataHandler = new DataHandlers.EmployeeDataHandler();

        public List<employee> Employees { get { return dataHandler.GetData(HideDeleted); } }
        public bool HideDeleted { get; set; } = true;

        public void AddEmployee()
        {
            employee emp = new employee();
            AddEmployee addWindow = new AddEmployee();

            emp.start_date = DateTime.Now;
            
            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { employee = emp, types = dataHandler.GetEntities().employee_type.ToList().FindAll(type => { return !type.deleted; }) };
            addWindow.ShowDialog();

            try
            {
                dataHandler.AddOrUpdate(emp);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error: " + e.Message);
            }
            NotifyOfPropertyChange("Employees");

        }

        public void Delete(employee obj)
        {
            dataHandler.RemoveData(obj);
            NotifyOfPropertyChange("Employees");
        }

        public void Modify(employee emp)
        {
            AddEmployee addWindow = new AddEmployee();

            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { employee = emp, types = dataHandler.GetEntities().employee_type.ToList().FindAll(type => { return !type.deleted; }) };
            if (addWindow.ShowDialog() == true)
            {
                try
                {
                    dataHandler.AddOrUpdate(emp);
                } catch (Exception e)
                {
                    System.Windows.MessageBox.Show("Error: " + e.Message);
                }
            }
            else
            {
                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, emp);
            }
            NotifyOfPropertyChange("Employees");

        }
    }
}
