using Caliburn.Micro;
using ClothingShop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.ViewModels
{
    class EmployeeTypesViewModel : Screen, INotifyPropertyChanged
    {
        public DataHandlers.EmployeeTypesDataHandler dataHandler = new DataHandlers.EmployeeTypesDataHandler();

        public List<employee_type> EmployeeTypes { get { return dataHandler.GetData(HideDeleted); } }
        public bool HideDeleted { get; set; } = true;

        public void AddEmployeeType()
        {
            employee_type empType = new employee_type();
            AddEmployeeType addWindow = new AddEmployeeType();

            addWindow.DataContext = new { employeeType = empType };
            addWindow.ShowDialog();
            try
            {
                dataHandler.AddOrUpdate(empType);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error: " + e.Message);
            }

            NotifyOfPropertyChange("EmployeeTypes");
        }

        public void Delete(employee_type obj)
        {
            dataHandler.RemoveData(obj);
            NotifyOfPropertyChange("EmployeeTypes");
        }

        public void Modify(employee_type empType)
        {
            AddEmployeeType addWindow = new AddEmployeeType();

            addWindow.DataContext = new { employeeType = empType };
            if(addWindow.ShowDialog() == true)
            {
                try
                {
                    dataHandler.AddOrUpdate(empType);
                }
                catch (Exception e)
                {
                    System.Windows.MessageBox.Show("Error: " + e.Message);
                }
            }
            else
            {
                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, empType);
            }
            NotifyOfPropertyChange("EmployeeTypes");
        }
    }
}
