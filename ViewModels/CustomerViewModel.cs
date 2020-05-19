using Caliburn.Micro;
using ClothingShop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.ViewModels
{
    class CustomerViewModel : Screen, INotifyPropertyChanged
    {
        public DataHandlers.CustomerDataHandler dataHandler = new DataHandlers.CustomerDataHandler();

        public List<customer> Customers { get { return dataHandler.GetData(HideDeleted); } }
        public bool HideDeleted { get; set; } = true;

        public void AddCustomer()
        {
            customer cust = new customer();
            AddCustomer addWindow = new AddCustomer();

            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { customer = cust };
            addWindow.ShowDialog();

            try
            {
                dataHandler.AddOrUpdate(cust);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error: " + e.Message);
            }
            NotifyOfPropertyChange("Customers");

        }

        public void Delete(customer obj)
        {
            dataHandler.RemoveData(obj);
            NotifyOfPropertyChange("Customers");
        }

        public void Modify(customer cust)
        {
            AddCustomer addWindow = new AddCustomer();

            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { customer = cust };
            if (addWindow.ShowDialog() == true)
            {
                try
                {
                    dataHandler.AddOrUpdate(cust);
                }
                catch (Exception e)
                {
                    System.Windows.MessageBox.Show("Error: " + e.Message);
                }
            }
            else
            {
                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, cust);
            }
            NotifyOfPropertyChange("Customers");

        }
    }
}
