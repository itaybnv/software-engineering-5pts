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
    class ShiftsViewModel : Screen, INotifyPropertyChanged
    {
        public DataHandlers.ShiftDataHandler dataHandler = new DataHandlers.ShiftDataHandler();

        public List<shift> Shifts { get { return dataHandler.GetData(HideDeleted); } }
        public bool HideDeleted { get; set; } = true;

        public void AddShift()
        {
            shift s = new shift();
            AddShift addWindow = new AddShift();

            s.end_time = DateTime.Now;
            s.start_time = DateTime.Now;

            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { shift = s, employees = dataHandler.GetEntities().employee.ToList().FindAll(type => { return !type.deleted; }) };
            addWindow.ShowDialog();

            try
            {
                dataHandler.AddOrUpdate(s);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error: " + e.Message);
            }
            NotifyOfPropertyChange("Shifts");

        }

        public void Delete(shift s)
        {
            dataHandler.RemoveData(s);
            NotifyOfPropertyChange("Shifts");
        }

        public void Modify(shift s)
        {
            AddShift addWindow = new AddShift();

            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { shift = s, employees = dataHandler.GetEntities().employee.ToList().FindAll(type => { return !type.deleted; }) };
            if (addWindow.ShowDialog() == true)
            {
                try
                {
                    dataHandler.AddOrUpdate(s);
                }
                catch (Exception e)
                {
                    System.Windows.MessageBox.Show("Error: " + e.Message);
                }
            }
            else
            {
                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, s);
            }
            NotifyOfPropertyChange("Shifts");

        }
    }
}
