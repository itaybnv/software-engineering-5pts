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
    class MerchandiseViewModel : Screen, INotifyPropertyChanged
    {
        public DataHandlers.MerchandiseDataHandler dataHandler = new DataHandlers.MerchandiseDataHandler();

        public List<merchandise> Merchandise { get { return dataHandler.GetData(HideDeleted); } }
        public bool HideDeleted { get; set; } = true;

        public void AddMerchandise()
        {
            merchandise merch = new merchandise();
            AddMerchandise addWindow = new AddMerchandise();
            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { merch, merchCategories = dataHandler.GetEntities().merchandise_category.ToList().FindAll(type => { return !type.deleted; }) };
            addWindow.ShowDialog();

            try
            {
                dataHandler.AddOrUpdate(merch);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error: " + e.Message);
            }
            NotifyOfPropertyChange("Merchandise");

        }

        public void Delete(merchandise obj)
        {
            dataHandler.RemoveData(obj);
            NotifyOfPropertyChange("Merchandise");
        }

        public void Modify(merchandise merch)
        {
            AddMerchandise addWindow = new AddMerchandise();

            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { merch, merchCategories = dataHandler.GetEntities().merchandise_category.ToList().FindAll(type => { return !type.deleted; }) };
            if (addWindow.ShowDialog() == true)
            {
                try
                {
                    dataHandler.AddOrUpdate(merch);
                }
                catch (Exception e)
                {
                    System.Windows.MessageBox.Show("Error: " + e.Message);
                }
            }
            else
            {
                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, merch);
            }
            NotifyOfPropertyChange("Merchandise");

        }
    }
}
