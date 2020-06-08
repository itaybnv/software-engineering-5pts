using ClothingShop.ViewModels;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClothingShop.ViewModels
{
    class ShellViewModel : Conductor<object>
    {
        public Dictionary<string, Screen> ViewsDict { get; set; } = new Dictionary<string, Screen>
        {
            { "Employees", new EmployeesViewModel() },
            { "EmployeeTypes", new EmployeeTypesViewModel() },
            { "Shifts", new ShiftsViewModel() },
            { "MerchandiseCategories", new MerchandiseCategoriesViewModel() },
            { "Merchandise", new MerchandiseViewModel() },
            { "Expenses", new ExpenseViewModel() },
            { "Customers", new CustomerViewModel() },
            { "Inventory", new InventoryViewModel() },
            { "Orders", new OrderViewModel() },
            { "HomePage", new HomePageViewModel() }
        };

        public ShellViewModel()
        {
            ActivateItem(ViewsDict["HomePage"]);
        }

        public void ActivateView(string viewModelName)
        {
            DisplayName = $"Clothing Shop - {viewModelName}";

            ActivateItem(ViewsDict[viewModelName]);
        }
    }
}
