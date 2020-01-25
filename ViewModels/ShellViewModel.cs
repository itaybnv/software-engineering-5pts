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

        public void LoadEmployees()
        {
            ActivateItem(new EmployeesViewModel());
        }
    }
}
