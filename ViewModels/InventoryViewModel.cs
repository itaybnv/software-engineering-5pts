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
    class InventoryViewModel : Screen, INotifyPropertyChanged
    {
        public DataHandlers.InventoryDataHandler dataHandler = new DataHandlers.InventoryDataHandler();

        public List<inventory> Inventory { get { return dataHandler.GetData(HideDeleted); } }
        public bool HideDeleted { get; set; } = true;

        public void AddInventory()
        {
            inventory inv = new inventory();
            AddInventory addWindow = new AddInventory();

            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { inventory = inv, merchandise = dataHandler.GetEntities().merchandise.ToList().FindAll(type => { return !type.deleted; }) };
            addWindow.ShowDialog();

            try
            {
                dataHandler.AddOrUpdate(inv);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error: " + e.Message);
            }
            NotifyOfPropertyChange("Inventory");

        }

        public void Delete(inventory obj)
        {
            dataHandler.RemoveData(obj);
            NotifyOfPropertyChange("Inventory");
        }

        public void Modify(inventory inv)
        {
            AddInventory addWindow = new AddInventory();

            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { inventory = inv, merchandise = dataHandler.GetEntities().merchandise.ToList().FindAll(type => { return !type.deleted; }) };
            if (addWindow.ShowDialog() == true)
            {
                try
                {
                    dataHandler.AddOrUpdate(inv);
                }
                catch (Exception e)
                {
                    System.Windows.MessageBox.Show("Error: " + e.Message);
                }
            }
            else
            {
                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, inv);
            }
            NotifyOfPropertyChange("Inventory");

        }
    }
}
