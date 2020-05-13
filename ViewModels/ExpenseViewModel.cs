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
    class ExpenseViewModel: Screen, INotifyPropertyChanged
    {
        public DataHandlers.ExpenseDataHandler dataHandler = new DataHandlers.ExpenseDataHandler();

        public List<expense> Expenses { get { return dataHandler.GetData(HideDeleted); } }
        public bool HideDeleted { get; set; } = true;

        public void AddExpense()
        {
            expense exp = new expense();
            AddExpense addWindow = new AddExpense();

            exp.date = DateTime.Now;

            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { expense = exp, employees = dataHandler.GetEntities().employee.ToList().FindAll(type => { return !type.deleted; }) };
            addWindow.ShowDialog();

            try
            {
                dataHandler.AddOrUpdate(exp);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error: " + e.Message);
            }
            NotifyOfPropertyChange("Expenses");

        }

        public void Delete(expense obj)
        {
            dataHandler.RemoveData(obj);
            NotifyOfPropertyChange("Expenses");
        }

        public void Modify(expense exp)
        {
            AddExpense addWindow = new AddExpense();

            // Sets the window's context and gives it the types available, that aren't deleted
            addWindow.DataContext = new { expense = exp, employees = dataHandler.GetEntities().employee.ToList().FindAll(type => { return !type.deleted; }) };
            if (addWindow.ShowDialog() == true)
            {
                try
                {
                    dataHandler.AddOrUpdate(exp);
                }
                catch (Exception e)
                {
                    System.Windows.MessageBox.Show("Error: " + e.Message);
                }
            }
            else
            {
                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, exp);
            }
            NotifyOfPropertyChange("Expenses");

        }
    }
}
