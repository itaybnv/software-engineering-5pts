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
    class OrderViewModel : Screen, INotifyPropertyChanged
    {
        public DataHandlers.OrderDataHandler dataHandler = new DataHandlers.OrderDataHandler();

        public List<order> Orders
        {
            get
            {
                return dataHandler.GetData(HideDeleted).Where(v => v.date >= LowDate && v.date <= HighDate).ToList();
            }

        }
        public bool HideDeleted { get; set; } = true;
        public DateTime LowDate { get; set; } = DateTime.Now.AddDays(-1);
        public DateTime HighDate { get; set; } = DateTime.Now.AddDays(1);

        public void AddOrder()
        {
            order order = new order();
            AddOrder addWindow = new AddOrder();

            order.date = DateTime.Now;

            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { order, customers = dataHandler.GetEntities().customer.ToList().FindAll(type => { return !type.deleted; }), merchandise = dataHandler.GetEntities().merchandise.ToList().FindAll(type => { return !type.deleted; }) };
            addWindow.ShowDialog();
            try
            {
                dataHandler.AddOrUpdate(order);

                // Deduct from inventory
                List<inventory> invList = dataHandler.GetEntities().inventory.ToList();
                foreach (inventory inv in invList)
                {
                    if(inv.merchandise_id == order.merchandise_id)
                    {
                        inv.quantity -= 1;

                        dataHandler.GetEntities().SaveChanges();
                        NotifyOfPropertyChange("Inventory");
                        break;
                    }
                }

                
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error: " + e.Message);
            }
            NotifyOfPropertyChange("Orders");

        }

        public void Delete(order obj)
        {
            dataHandler.RemoveData(obj);
            NotifyOfPropertyChange("Orders");
        }
    }
}
