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
    class MerchandiseCategoriesViewModel : Screen, INotifyPropertyChanged
    {
        public DataHandlers.MerchandiseCategoryDataHandler dataHandler = new DataHandlers.MerchandiseCategoryDataHandler();

        public List<merchandise_category> MerchandiseCategories { get { return dataHandler.GetData(HideDeleted); } }
        public bool HideDeleted { get; set; } = true;

        public void AddMerchandiseCategory()
        {
            merchandise_category merchCategory = new merchandise_category();
            AddMerchandiseCategory addWindow = new AddMerchandiseCategory();

            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { merchCategory };
            addWindow.ShowDialog();

            try
            {
                dataHandler.AddOrUpdate(merchCategory);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error: " + e.Message);
            }
            NotifyOfPropertyChange("MerchandiseCategories");

        }

        public void Delete(merchandise_category obj)
        {
            dataHandler.RemoveData(obj);
            NotifyOfPropertyChange("MerchandiseCategories");
        }

        public void Modify(merchandise_category merchCategory)
        {
            AddMerchandiseCategory addWindow = new AddMerchandiseCategory();

            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { merchCategory };
            if (addWindow.ShowDialog() == true)
            {
                try
                {
                    dataHandler.AddOrUpdate(merchCategory);
                }
                catch (Exception e)
                {
                    System.Windows.MessageBox.Show("Error: " + e.Message);
                }
            }
            else
            {
                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, merchCategory);
            }
            NotifyOfPropertyChange("MerchandiseCategories");

        }
    }
}
