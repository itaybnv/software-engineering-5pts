[מערכת לניהול חנות בגדים]{dir="rtl"}

[מגיש: איתי בנבניסטי]{dir="rtl"}

[תעודת זהות: 209267582]{dir="rtl"}

[\
]{dir="rtl"}

[תוכן]{dir="rtl"}

 {#section .TOC-Heading}

[[מבוא]{dir="rtl"} 5](#מבוא)

[[נושא הפרוייקט:]{dir="rtl"} 5](#נושא-הפרוייקט)

[[מהות התוכנה:]{dir="rtl"} 5](#מהות-התוכנה)

[[תהליכים מרכזיים]{dir="rtl"} 5](#תהליכים-מרכזיים)

[[מדריך למשתמש]{dir="rtl"} 6](#מדריך-למשתמש)

[[דף ראשי]{dir="rtl"} 6](#דף-ראשי)

[[עובדים]{dir="rtl"} 7](#עובדים)

[[הוספת עובד]{dir="rtl"} 7](#הוספת-עובד)

[[סוגי עובדים]{dir="rtl"} 8](#סוגי-עובדים)

[[הוספת סוג עובד]{dir="rtl"} 8](#הוספת-סוג-עובד)

[[משמרות]{dir="rtl"} 9](#משמרות)

[[הוספת משמרת]{dir="rtl"} 9](#הוספת-משמרת)

[[לקוחות]{dir="rtl"} 10](#לקוחות)

[[הוספת לקוח]{dir="rtl"} 10](#הוספת-לקוח)

[[מוצרים]{dir="rtl"} 11](#מוצרים)

[[הוספת מוצר]{dir="rtl"} 11](#הוספת-מוצר)

[[סוגי מוצרים]{dir="rtl"} 12](#סוגי-מוצרים)

[[הוספת סוג מוצר]{dir="rtl"} 12](#הוספת-סוג-מוצר)

[[הוצאות]{dir="rtl"} 13](#הוצאות)

[[הוספת הוצאה]{dir="rtl"} 13](#הוספת-הוצאה)

[[מלאי]{dir="rtl"} 14](#מלאי)

[[הוספה למלאי]{dir="rtl"} 14](#הוספה-למלאי)

[[מכירות]{dir="rtl"} 15](#מכירות)

[[הוספת מכירה]{dir="rtl"} 15](#הוספת-מכירה)

[[מדריך למתכנת]{dir="rtl"} 16](#מדריך-למתכנת)

[[הסבר על שיטת השכבות]{dir="rtl"} 16](#הסבר-על-שיטת-השכבות)

[[קשרים בין הטבלאות]{dir="rtl"} 16](#קשרים-בין-הטבלאות)

[[טבלת העובדים]{dir="rtl"} 17](#טבלת-העובדים)

[[טבלת סוגי העובדים]{dir="rtl"} 17](#טבלת-סוגי-העובדים)

[[טבלת משמרות]{dir="rtl"} 18](#טבלת-משמרות)

[[טבלת לקוחות]{dir="rtl"} 19](#טבלת-לקוחות)

[[טבלת מוצרים]{dir="rtl"} 19](#טבלת-מוצרים)

[[טבלת סוגי מוצרים]{dir="rtl"} 20](#טבלת-סוגי-מוצרים)

[[טבלת הוצאות]{dir="rtl"} 20](#טבלת-הוצאות)

[[טבלת מלאי]{dir="rtl"} 21](#טבלת-מלאי)

[[טבלת המכירות]{dir="rtl"} 21](#טבלת-המכירות)

[[טבלת הזמנות מספק]{dir="rtl"} 22](#טבלת-הזמנות-מספק)

[[טבלה קישורת בין הזמנה מספק למוצרים בהזמנה]{dir="rtl"}
22](#טבלה-קישורת-בין-הזמנה-מספק-למוצרים-בהזמנה)

[[קוד התוכנה]{dir="rtl"} 23](#קוד-התוכנה)

[[קוד משני]{dir="rtl"} 23](#קוד-משני)

[Bootstrapper 23](#bootstrapper)

[Bool Converter 23](#bool-converter)

[ViewModels 24](#viewmodels)

[ShellViewModel 24](#shellviewmodel)

[CustomerViewModel 25](#customerviewmodel)

[EmployeesViewModel 26](#employeesviewmodel)

[EmployeeTypesViewModel 28](#employeetypesviewmodel)

[ExpenseViewModel 29](#expenseviewmodel)

[HomePageViewModel 30](#homepageviewmodel)

[InventoryViewModel 31](#inventoryviewmodel)

[MerchandiseCategoriesViewModel 32](#merchandisecategoriesviewmodel)

[MerchandiseViewModel 34](#merchandiseviewmodel)

[OrderViewModel 35](#orderviewmodel)

[ShiftsViewModel 37](#shiftsviewmodel)

[DataHandlers 38](#datahandlers)

[Abstract dataHandler 38](#abstract-datahandler)

[CustomerDataHandler 39](#customerdatahandler)

[EmployeeDataHandler 40](#employeedatahandler)

[EmployeeTypesDataHandler 41](#employeetypesdatahandler)

[ExpenseDataHandler 42](#expensedatahandler)

[InventoryDataHandler 42](#inventorydatahandler)

[MerchandiseCategoryDataHandler 42](#merchandisecategorydatahandler)

[MerchandiseDataHandler 43](#merchandisedatahandler)

[OrderDataHandler 44](#orderdatahandler)

[ShiftsDataHandler 44](#shiftsdatahandler)

[\
]{dir="rtl"}

[מבוא]{dir="rtl"}
=================

[נושא הפרוייקט:]{dir="rtl"}
---------------------------

[הקמה של מערכת ממוחשבת כללית למודל חנות בגדים.]{dir="rtl"}

[מהות התוכנה:]{dir="rtl"}
-------------------------

[תוכנה זו נכתבה במטרה לייעל את דרכי ההתנהלות של חנויות
בגדים.]{dir="rtl"}

[תהליכים מרכזיים]{dir="rtl"}
============================

[\
]{dir="rtl"}

[מדריך למשתמש]{dir="rtl"}
=========================

[דף ראשי]{dir="rtl"}
--------------------

![](.//media/image1.png){width="6.5in" height="3.660416666666667in"}

[דף זה משמש כמסך הבית של התוכנה, דרך דף זה אפשר להגיע לכל האפשרויות
בתוכנה]{dir="rtl"}

[עובדים]{dir="rtl"}
-------------------

![](.//media/image2.png){width="6.5in" height="3.660416666666667in"}

[דף העובדים, בדף זה אפשר להוסיף, לערוך או להסיר עובדים.]{dir="rtl"}

[הוספת עובד]{dir="rtl"}
-----------------------

![](.//media/image3.png){width="2.5672594050743656in"
height="3.9440004374453195in"}

[סוגי עובדים]{dir="rtl"}
------------------------

![](.//media/image4.png){width="6.5in" height="3.660416666666667in"}

[דף סוגי העובדים, בדף זה אפשר להוסיף, לערוך או להסיר סוגי
עובדים.]{dir="rtl"}

[הוספת סוג עובד]{dir="rtl"}
---------------------------

![](.//media/image5.png){width="2.884910323709536in"
height="4.431999125109361in"}

[משמרות]{dir="rtl"}
-------------------

![](.//media/image6.png){width="6.5in" height="3.660416666666667in"}

[דף משמרות, בדף זה אפשר להוסיף, לערוך או להסיר משמרות לפי העובדים
הקיימים.]{dir="rtl"}

[הוספת משמרת]{dir="rtl"}
------------------------

![](.//media/image7.png){width="2.8797036307961505in"
height="4.423999343832021in"}

[לקוחות]{dir="rtl"}
-------------------

![](.//media/image8.png){width="6.5in" height="3.660416666666667in"}

[דף לקוחות, בדף זה אפשר להוסיף, לערוך או להסיר לקוחות.]{dir="rtl"}

[הוספת לקוח]{dir="rtl"}
-----------------------

![](.//media/image9.png){width="2.8328357392825896in"
height="4.351999125109361in"}

[מוצרים]{dir="rtl"}
-------------------

![](.//media/image10.png){width="6.5in" height="3.660416666666667in"}

[דף מוצרים, בדף זה אפשר להוסיף, לערוך או להסיר מוצרים. המוצרים לא בהכרח
קיימים בחנות, אלא היו קיימים או בדרך לחנות.]{dir="rtl"}

[הוספת מוצר]{dir="rtl"}
-----------------------

![](.//media/image11.png){width="2.7547265966754155in"
height="4.23200021872266in"}

[סוגי מוצרים]{dir="rtl"}
------------------------

![](.//media/image12.png){width="6.5in" height="3.660416666666667in"}

[דף סוגי מוצרים, בדף זה אפשר להוסיף, לערוך או להסיר סוגי
מוצרים.]{dir="rtl"}

[הוספת סוג מוצר]{dir="rtl"}
---------------------------

![](.//media/image13.png){width="2.864081364829396in" height="4.4in"}

[הוצאות]{dir="rtl"}
-------------------

![](.//media/image14.png){width="6.5in" height="3.660416666666667in"}

[דף ההוצאות, בדך זה אפשר להוסיף, לערוך או להסיר הוצאות. דף זה יציג
הוצאות אינן שוטפות.]{dir="rtl"}

[הוספת הוצאה]{dir="rtl"}
------------------------

![](.//media/image15.png){width="2.884910323709536in"
height="4.431999125109361in"}

[מלאי]{dir="rtl"}
-----------------

![](.//media/image16.png){width="6.5in" height="3.660416666666667in"}

[דף מלאי, בדך זה אפשר להוסיף, לערוך או להסיר מלאי קיים.]{dir="rtl"}

[הוספה למלאי]{dir="rtl"}
------------------------

![](.//media/image17.png){width="2.8744958442694664in"
height="4.41599956255468in"}

[מכירות]{dir="rtl"}
-------------------

![](.//media/image18.png){width="6.5in" height="3.660416666666667in"}

[דף מכירות, בדך זה אפשר להוסיף, לערוך או להסיר מכירות.]{dir="rtl"}

[הוספת מכירה]{dir="rtl"}
------------------------

![](.//media/image19.png){width="2.8797036307961505in"
height="4.423999343832021in"}

[מדריך למתכנת]{dir="rtl"}
=========================

[הסבר על שיטת השכבות]{dir="rtl"}
--------------------------------

[בתוכנה זו אני עושה שימוש ב]{dir="rtl"}framework [בשם]{dir="rtl"}
caliburn.micro[. המערכת הזו משתמשת בשיטת השכבות]{dir="rtl"} MVVM
[(]{dir="rtl"}Model, View, View-Model[), כאשר המודל מובא לי על ידי
ה]{dir="rtl"}database [בצורת]{dir="rtl"} classes [לכל טבלה שמציגים שורה
מן הטבלה. שכבת ה]{dir="rtl"} view [היא חלון]{dir="rtl"} userControl
[שמוכנס לחלון הראשי כאשר המשתמש בוחר בהצגתו. בשכבה זו קיימים קשרים בין
ה]{dir="rtl"} XAML [לשכבה הבאה, ולא נמצא קוד פונקציונלי בכלל בשכבה זו.
שכבת ה]{dir="rtl"} view-model [היא שכבת הקוד המקשרת בין ה]{dir="rtl"}
view [ל]{dir="rtl"} model [וה]{dir="rtl"} database[. בשכבה זו נמצא כל
הקוד של הוספה, עריכה ומחיקה.]{dir="rtl"} Caliburn.micro [נותן לי גישה
מהירה למשתנים ב]{dir="rtl"}viewmodel [מתוך ה]{dir="rtl"} XAML [של
ה]{dir="rtl"} view [בצורת]{dir="rtl"} binding [פשוטה או אפילו בשינוי השם
של הרכיב לשם של המשתנה ב]{dir="rtl"}viewmodel[.]{dir="rtl"}

[קשרים בין הטבלאות]{dir="rtl"}
------------------------------

![](.//media/image20.png){width="6.5in" height="3.527308617672791in"}

[\
]{dir="rtl"}

[טבלת העובדים]{dir="rtl"}
-------------------------

![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image22.png){width="2.3210837707786527in"
height="4.287999781277341in"}

![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}

[ ]{dir="rtl"}

[טבלת סוגי העובדים]{dir="rtl"}
------------------------------

![](.//media/image23.png){width="2.2823589238845146in"
height="3.0079997812773405in"}

![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}

[טבלת משמרות]{dir="rtl"}
------------------------

![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image24.png){width="2.283959973753281in"
height="3.064000437445319in"}

[\
]{dir="rtl"}

[טבלת לקוחות]{dir="rtl"}
------------------------

![](.//media/image25.png){width="2.28in" height="2.7309897200349957in"}

![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}

[טבלת מוצרים]{dir="rtl"}
------------------------

![](.//media/image26.png){width="2.2612117235345583in" height="3.28in"}

![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}

[\
]{dir="rtl"}

[טבלת סוגי מוצרים]{dir="rtl"}
-----------------------------

![](.//media/image27.png){width="2.24in" height="2.5111581364829396in"}

![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}

[טבלת הוצאות]{dir="rtl"}
------------------------

![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image28.png){width="2.2159995625546807in"
height="3.248109142607174in"}

[\
]{dir="rtl"}

[טבלת מלאי]{dir="rtl"}
----------------------

![](.//media/image29.png){width="2.2159995625546807in"
height="2.6372233158355205in"}

![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}

[טבלת המכירות]{dir="rtl"}
-------------------------

![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image30.png){width="2.1990813648293965in"
height="3.20799978127734in"}

[\
]{dir="rtl"}

[טבלת הזמנות מספק]{dir="rtl"}
-----------------------------

![](.//media/image31.png){width="2.20799978127734in"
height="2.6375021872265965in"}

![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}

![](.//media/image32.png){width="2.183333333333333in" height="2.863888888888889in"}[טבלה קישורת בין הזמנה מספק למוצרים בהזמנה]{dir="rtl"}
-----------------------------------------------------------------------------------------------------------------------------------------

![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}![](.//media/image21.emf){width="6.174305555555556in"
height="0.29583333333333334in"}

[\
]{dir="rtl"}

[קוד התוכנה]{dir="rtl"}
=======================

[קוד משני]{dir="rtl"}
---------------------

### Bootstrapper

using ClothingShop.ViewModels;

using Caliburn.Micro;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows;

namespace ClothingShop

{

    class Bootstrapper : BootstrapperBase

    {

        public Bootstrapper()

        {

            Initialize();

        }

        protected override void OnStartup(object sender, StartupEventArgs e)

        {

            DisplayRootViewFor\<ShellViewModel\>();

        }

    }

}

### Bool Converter

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Data;

namespace ClothingShop.misc

{

    \[ValueConversion(typeof(bool), typeof(bool))\]

    public class InverseBooleanConverter : IValueConverter

    {

        public object Convert(object value, Type targetType, object parameter,

            System.Globalization.CultureInfo culture)

        {

            if (targetType != typeof(bool))

                throw new InvalidOperationException(\"The target must be a boolean\");

            return !(bool)value;

        }

        public object ConvertBack(object value, Type targetType, object parameter,

            System.Globalization.CultureInfo culture)

        {

            throw new NotSupportedException();

        }

    }

}

ViewModels
----------

### ShellViewModel

using ClothingShop.ViewModels;

using Caliburn.Micro;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows;

namespace ClothingShop.ViewModels

{

    class ShellViewModel : Conductor\<object\>

    {

        public Dictionary\<string, Screen\> ViewsDict { get; set; } = new Dictionary\<string, Screen\>

        {

            { \"Employees\", new EmployeesViewModel() },

            { \"EmployeeTypes\", new EmployeeTypesViewModel() },

            { \"Shifts\", new ShiftsViewModel() },

            { \"MerchandiseCategories\", new MerchandiseCategoriesViewModel() },

            { \"Merchandise\", new MerchandiseViewModel() },

            { \"Expenses\", new ExpenseViewModel() },

            { \"Customers\", new CustomerViewModel() },

            { \"Inventory\", new InventoryViewModel() },

            { \"Orders\", new OrderViewModel() },

            { \"HomePage\", new HomePageViewModel() }

        };

        public ShellViewModel()

        {

            ActivateItem(ViewsDict\[\"HomePage\"\]);

        }

        public void ActivateView(string viewModelName)

        {

            DisplayName = \$\"Clothing Shop - {viewModelName}\";

            ActivateItem(ViewsDict\[viewModelName\]);

        }

    }

}

### CustomerViewModel

using Caliburn.Micro;

using ClothingShop.Views;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ClothingShop.ViewModels

{

    class CustomerViewModel : Screen, INotifyPropertyChanged

    {

        public DataHandlers.CustomerDataHandler dataHandler = new DataHandlers.CustomerDataHandler();

        public List\<customer\> Customers { get { return dataHandler.GetData(HideDeleted); } }

        public bool HideDeleted { get; set; } = true;

        public void AddCustomer()

        {

            customer cust = new customer();

            AddCustomer addWindow = new AddCustomer();

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { customer = cust };

            addWindow.ShowDialog();

            try

            {

                dataHandler.AddOrUpdate(cust);

            }

            catch (Exception e)

            {

                System.Windows.MessageBox.Show(\"Error: \" + e.Message);

            }

            NotifyOfPropertyChange(\"Customers\");

        }

        public void Delete(customer obj)

        {

            dataHandler.RemoveData(obj);

            NotifyOfPropertyChange(\"Customers\");

        }

        public void Modify(customer cust)

        {

            AddCustomer addWindow = new AddCustomer();

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { customer = cust };

            if (addWindow.ShowDialog() == true)

            {

                try

                {

                    dataHandler.AddOrUpdate(cust);

                }

                catch (Exception e)

                {

                    System.Windows.MessageBox.Show(\"Error: \" + e.Message);

                }

            }

            else

            {

                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, cust);

            }

            NotifyOfPropertyChange(\"Customers\");

        }

    }

}

### EmployeesViewModel

using ClothingShop.Views;

using Caliburn.Micro;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.ComponentModel;

using System.Diagnostics;

using System.Windows.Input;

namespace ClothingShop.ViewModels

{

    class EmployeesViewModel : Screen, INotifyPropertyChanged

    {

        public DataHandlers.EmployeeDataHandler dataHandler = new DataHandlers.EmployeeDataHandler();

        public List\<employee\> Employees { get { return dataHandler.GetData(HideDeleted); } }

        public bool HideDeleted { get; set; } = true;

        public void AddEmployee()

        {

            employee emp = new employee();

            AddEmployee addWindow = new AddEmployee();

            emp.start\_date = DateTime.Now;

            

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { employee = emp, types = dataHandler.GetEntities().employee\_type.ToList().FindAll(type =\> { return !type.deleted; }) };

            addWindow.ShowDialog();

            try

            {

                dataHandler.AddOrUpdate(emp);

            }

            catch (Exception e)

            {

                System.Windows.MessageBox.Show(\"Error: \" + e.Message);

            }

            NotifyOfPropertyChange(\"Employees\");

        }

        public void Delete(employee obj)

        {

            dataHandler.RemoveData(obj);

            NotifyOfPropertyChange(\"Employees\");

        }

        public void Modify(employee emp)

        {

            AddEmployee addWindow = new AddEmployee();

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { employee = emp, types = dataHandler.GetEntities().employee\_type.ToList().FindAll(type =\> { return !type.deleted; }) };

            if (addWindow.ShowDialog() == true)

            {

                try

                {

                    dataHandler.AddOrUpdate(emp);

                } catch (Exception e)

                {

                    System.Windows.MessageBox.Show(\"Error: \" + e.Message);

                }

            }

            else

            {

                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, emp);

            }

            NotifyOfPropertyChange(\"Employees\");

        }

    }

}

### EmployeeTypesViewModel

using Caliburn.Micro;

using ClothingShop.Views;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Diagnostics;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ClothingShop.ViewModels

{

    class EmployeeTypesViewModel : Screen, INotifyPropertyChanged

    {

        public DataHandlers.EmployeeTypesDataHandler dataHandler = new DataHandlers.EmployeeTypesDataHandler();

        public List\<employee\_type\> EmployeeTypes { get { return dataHandler.GetData(HideDeleted); } }

        public bool HideDeleted { get; set; } = true;

        public void AddEmployeeType()

        {

            employee\_type empType = new employee\_type();

            AddEmployeeType addWindow = new AddEmployeeType();

            addWindow.DataContext = new { employeeType = empType };

            addWindow.ShowDialog();

            try

            {

                dataHandler.AddOrUpdate(empType);

            }

            catch (Exception e)

            {

                System.Windows.MessageBox.Show(\"Error: \" + e.Message);

            }

            NotifyOfPropertyChange(\"EmployeeTypes\");

        }

        public void Delete(employee\_type obj)

        {

            dataHandler.RemoveData(obj);

            NotifyOfPropertyChange(\"EmployeeTypes\");

        }

        public void Modify(employee\_type empType)

        {

            AddEmployeeType addWindow = new AddEmployeeType();

            addWindow.DataContext = new { employeeType = empType };

            if(addWindow.ShowDialog() == true)

            {

                try

                {

                    dataHandler.AddOrUpdate(empType);

                }

                catch (Exception e)

                {

                    System.Windows.MessageBox.Show(\"Error: \" + e.Message);

                }

            }

            else

            {

                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, empType);

            }

            NotifyOfPropertyChange(\"EmployeeTypes\");

        }

    }

}

### ExpenseViewModel

using Caliburn.Micro;

using ClothingShop.Views;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ClothingShop.ViewModels

{

    class ExpenseViewModel: Screen, INotifyPropertyChanged

    {

        public DataHandlers.ExpenseDataHandler dataHandler = new DataHandlers.ExpenseDataHandler();

        public List\<expense\> Expenses { get { return dataHandler.GetData(HideDeleted); } }

        public bool HideDeleted { get; set; } = true;

        public void AddExpense()

        {

            expense exp = new expense();

            AddExpense addWindow = new AddExpense();

            exp.date = DateTime.Now;

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { expense = exp, employees = dataHandler.GetEntities().employee.ToList().FindAll(type =\> { return !type.deleted; }) };

            addWindow.ShowDialog();

            try

            {

                dataHandler.AddOrUpdate(exp);

            }

            catch (Exception e)

            {

                System.Windows.MessageBox.Show(\"Error: \" + e.Message);

            }

            NotifyOfPropertyChange(\"Expenses\");

        }

        public void Delete(expense obj)

        {

            dataHandler.RemoveData(obj);

            NotifyOfPropertyChange(\"Expenses\");

        }

        public void Modify(expense exp)

        {

            AddExpense addWindow = new AddExpense();

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { expense = exp, employees = dataHandler.GetEntities().employee.ToList().FindAll(type =\> { return !type.deleted; }) };

            if (addWindow.ShowDialog() == true)

            {

                try

                {

                    dataHandler.AddOrUpdate(exp);

                }

                catch (Exception e)

                {

                    System.Windows.MessageBox.Show(\"Error: \" + e.Message);

                }

            }

            else

            {

                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, exp);

            }

            NotifyOfPropertyChange(\"Expenses\");

        }

    }

}

### HomePageViewModel

using Caliburn.Micro;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ClothingShop.ViewModels

{

    class HomePageViewModel : Screen

    {

    }

}

### InventoryViewModel

using Caliburn.Micro;

using ClothingShop.Views;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ClothingShop.ViewModels

{

    class InventoryViewModel : Screen, INotifyPropertyChanged

    {

        public DataHandlers.InventoryDataHandler dataHandler = new DataHandlers.InventoryDataHandler();

        public List\<inventory\> Inventory { get { return dataHandler.GetData(HideDeleted); } }

        public bool HideDeleted { get; set; } = true;

        public void AddInventory()

        {

            inventory inv = new inventory();

            AddInventory addWindow = new AddInventory();

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { inventory = inv, merchandise = dataHandler.GetEntities().merchandise.ToList().FindAll(type =\> { return !type.deleted; }) };

            addWindow.ShowDialog();

            try

            {

                dataHandler.AddOrUpdate(inv);

            }

            catch (Exception e)

            {

                System.Windows.MessageBox.Show(\"Error: \" + e.Message);

            }

            NotifyOfPropertyChange(\"Inventory\");

        }

        public void Delete(inventory obj)

        {

            dataHandler.RemoveData(obj);

            NotifyOfPropertyChange(\"Inventory\");

        }

        public void Modify(inventory inv)

        {

            AddInventory addWindow = new AddInventory();

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { inventory = inv, merchandise = dataHandler.GetEntities().merchandise.ToList().FindAll(type =\> { return !type.deleted; }) };

            if (addWindow.ShowDialog() == true)

            {

                try

                {

                    dataHandler.AddOrUpdate(inv);

                }

                catch (Exception e)

                {

                    System.Windows.MessageBox.Show(\"Error: \" + e.Message);

                }

            }

            else

            {

                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, inv);

            }

            NotifyOfPropertyChange(\"Inventory\");

        }

    }

}

### MerchandiseCategoriesViewModel

using Caliburn.Micro;

using ClothingShop.Views;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ClothingShop.ViewModels

{

    class MerchandiseCategoriesViewModel : Screen, INotifyPropertyChanged

    {

        public DataHandlers.MerchandiseCategoryDataHandler dataHandler = new DataHandlers.MerchandiseCategoryDataHandler();

        public List\<merchandise\_category\> MerchandiseCategories { get { return dataHandler.GetData(HideDeleted); } }

        public bool HideDeleted { get; set; } = true;

        public void AddMerchandiseCategory()

        {

            merchandise\_category merchCategory = new merchandise\_category();

            AddMerchandiseCategory addWindow = new AddMerchandiseCategory();

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { merchCategory };

            addWindow.ShowDialog();

            try

            {

                dataHandler.AddOrUpdate(merchCategory);

            }

            catch (Exception e)

            {

                System.Windows.MessageBox.Show(\"Error: \" + e.Message);

            }

            NotifyOfPropertyChange(\"MerchandiseCategories\");

        }

        public void Delete(merchandise\_category obj)

        {

            dataHandler.RemoveData(obj);

            NotifyOfPropertyChange(\"MerchandiseCategories\");

        }

        public void Modify(merchandise\_category merchCategory)

        {

            AddMerchandiseCategory addWindow = new AddMerchandiseCategory();

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { merchCategory };

            if (addWindow.ShowDialog() == true)

            {

                try

                {

                    dataHandler.AddOrUpdate(merchCategory);

                }

                catch (Exception e)

                {

                    System.Windows.MessageBox.Show(\"Error: \" + e.Message);

                }

            }

            else

            {

                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, merchCategory);

            }

            NotifyOfPropertyChange(\"MerchandiseCategories\");

        }

    }

}

### MerchandiseViewModel

using Caliburn.Micro;

using ClothingShop.Views;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ClothingShop.ViewModels

{

    class MerchandiseViewModel : Screen, INotifyPropertyChanged

    {

        public DataHandlers.MerchandiseDataHandler dataHandler = new DataHandlers.MerchandiseDataHandler();

        public List\<merchandise\> Merchandise { get { return dataHandler.GetData(HideDeleted); } }

        public bool HideDeleted { get; set; } = true;

        public void AddMerchandise()

        {

            merchandise merch = new merchandise();

            AddMerchandise addWindow = new AddMerchandise();

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { merch, merchCategories = dataHandler.GetEntities().merchandise\_category.ToList().FindAll(type =\> { return !type.deleted; }) };

            addWindow.ShowDialog();

            try

            {

                dataHandler.AddOrUpdate(merch);

            }

            catch (Exception e)

            {

                System.Windows.MessageBox.Show(\"Error: \" + e.Message);

            }

            NotifyOfPropertyChange(\"Merchandise\");

        }

        public void Delete(merchandise obj)

        {

            dataHandler.RemoveData(obj);

            NotifyOfPropertyChange(\"Merchandise\");

        }

        public void Modify(merchandise merch)

        {

            AddMerchandise addWindow = new AddMerchandise();

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { merch, merchCategories = dataHandler.GetEntities().merchandise\_category.ToList().FindAll(type =\> { return !type.deleted; }) };

            if (addWindow.ShowDialog() == true)

            {

                try

                {

                    dataHandler.AddOrUpdate(merch);

                }

                catch (Exception e)

                {

                    System.Windows.MessageBox.Show(\"Error: \" + e.Message);

                }

            }

            else

            {

                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, merch);

            }

            NotifyOfPropertyChange(\"Merchandise\");

        }

    }

}

### OrderViewModel

using Caliburn.Micro;

using ClothingShop.Views;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Diagnostics;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ClothingShop.ViewModels

{

    class OrderViewModel : Screen, INotifyPropertyChanged

    {

        public DataHandlers.OrderDataHandler dataHandler = new DataHandlers.OrderDataHandler();

        public List\<order\> Orders { get { return dataHandler.GetData(HideDeleted); } }

        public bool HideDeleted { get; set; } = true;

        public void AddOrder()

        {

            order order = new order();

            AddOrder addWindow = new AddOrder();

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { order, customers = dataHandler.GetEntities().customer.ToList().FindAll(type =\> { return !type.deleted; }), merchandise = dataHandler.GetEntities().merchandise.ToList().FindAll(type =\> { return !type.deleted; }) };

            addWindow.ShowDialog();

            try

            {

                dataHandler.AddOrUpdate(order);

                // Deduct from inventory

                List\<inventory\> invList = dataHandler.GetEntities().inventory.ToList();

                foreach (inventory inv in invList)

                {

                    if(inv.merchandise\_id == order.merchandise\_id)

                    {

                        inv.quantity -= 1;

                        dataHandler.GetEntities().SaveChanges();

                        NotifyOfPropertyChange(\"Inventory\");

                        break;

                    }

                }

                

            }

            catch (Exception e)

            {

                System.Windows.MessageBox.Show(\"Error: \" + e.Message);

            }

            NotifyOfPropertyChange(\"Orders\");

        }

        public void Delete(order obj)

        {

            dataHandler.RemoveData(obj);

            NotifyOfPropertyChange(\"Orders\");

        }

    }

}

### 

### ShiftsViewModel

using Caliburn.Micro;

using ClothingShop.Views;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Diagnostics;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ClothingShop.ViewModels

{

    class ShiftsViewModel : Screen, INotifyPropertyChanged

    {

        public DataHandlers.ShiftDataHandler dataHandler = new DataHandlers.ShiftDataHandler();

        public List\<shift\> Shifts { get { return dataHandler.GetData(HideDeleted); } }

        public bool HideDeleted { get; set; } = true;

        public void AddShift()

        {

            shift s = new shift();

            AddShift addWindow = new AddShift();

            s.end\_time = DateTime.Now;

            s.start\_time = DateTime.Now;

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { shift = s, employees = dataHandler.GetEntities().employee.ToList().FindAll(type =\> { return !type.deleted; }) };

            addWindow.ShowDialog();

            try

            {

                dataHandler.AddOrUpdate(s);

            }

            catch (Exception e)

            {

                System.Windows.MessageBox.Show(\"Error: \" + e.Message);

            }

            NotifyOfPropertyChange(\"Shifts\");

        }

        public void Delete(shift s)

        {

            dataHandler.RemoveData(s);

            NotifyOfPropertyChange(\"Shifts\");

        }

        public void Modify(shift s)

        {

            AddShift addWindow = new AddShift();

            // Sets the window\'s context and gives it the types available, that aren\'t deleted

            addWindow.DataContext = new { shift = s, employees = dataHandler.GetEntities().employee.ToList().FindAll(type =\> { return !type.deleted; }) };

            if (addWindow.ShowDialog() == true)

            {

                try

                {

                    dataHandler.AddOrUpdate(s);

                }

                catch (Exception e)

                {

                    System.Windows.MessageBox.Show(\"Error: \" + e.Message);

                }

            }

            else

            {

                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dataHandler.GetEntities()).ObjectContext.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, s);

            }

            NotifyOfPropertyChange(\"Shifts\");

        }

    }

}

DataHandlers
------------

### Abstract dataHandler

using System;

using System.Collections.Generic;

using System.Data.Entity.Migrations;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ClothingShop

{

    abstract class DataHandler\<T\> where T : class

    {

        static protected dbEntities db = new dbEntities();

        public virtual List\<T\> GetData(bool hideDeleted)

        {

            if (hideDeleted)

            {

                return db.Set\<T\>().ToList().FindAll(o =\> !(bool)(typeof(T).GetProperty(\"deleted\").GetValue(o)));

            }

            else

            {

                return db.Set\<T\>().ToList();

            }

        }

        public virtual void RemoveData(T item)

        {

            // Set the data item as deleted

            typeof(T).GetProperty(\"deleted\").SetValue(item, true);

            // Notify db that the item was changed

            db.Entry(item).State = System.Data.Entity.EntityState.Modified;

            // Save the database

            db.SaveChanges();

        }

        public virtual void AddOrUpdate(T item)

        {

            try

            {

                VerifyItem(item);

                // Add item to database

                db.Set\<T\>().AddOrUpdate(item);

                // Save the database

                db.SaveChanges();

            }

            catch(Exception e)

            {

                throw new Exception(e.Message);

            }

        }

        public dbEntities GetEntities()

        {

            return db;

        }

        protected abstract void VerifyItem(T item);

    }

}

### CustomerDataHandler

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Text.RegularExpressions;

using System.Threading.Tasks;

namespace ClothingShop.DataHandlers

{

    class CustomerDataHandler : DataHandler\<customer\>

    {

        private bool VerifyString(string name)

        {

            Regex nameRegex = new Regex(@\"\^(\[a-zA-Z\]+?)(\[-\\s\'\]\[a-zA-Z\]+)\*?\$\");

            return nameRegex.IsMatch(name);

        }

        protected override void VerifyItem(customer item)

        {

            if (!VerifyString(item.firstname))

            {

                throw new Exception(\"First name incorrect\");

            } else if (!VerifyString(item.lastname))

            {

                throw new Exception(\"Last name incorrect\"); 

            }

        }

    }

}

### EmployeeDataHandler

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Text.RegularExpressions;

using System.Threading.Tasks;

namespace ClothingShop.DataHandlers

{

    class EmployeeDataHandler : DataHandler\<employee\>

    {

        private bool VerifyString(string name)

        {

            Regex nameRegex = new Regex(@\"\^(\[a-zA-Z\]+?)(\[-\\s\'\]\[a-zA-Z\]+)\*?\$\");

            return nameRegex.IsMatch(name);

        }

        private bool VerifyPhone(string phone)

        {

            Regex phoneRegex = new Regex(@\"\^\\+?(972\|0)(\\-)?0?((\[23489\]{1}\\d{7})\|\[5\]{1}\\d{8})\$\");

            return phoneRegex.IsMatch(phone);

        }

        protected override void VerifyItem(employee item)

        {

            if(!VerifyString(item.first\_name))

            {

                throw new Exception(\"First name incorrect\");

            }

            else if (!VerifyString(item.last\_name))

            {

                throw new Exception(\"Last name incorrect\");

            }

            else if (!VerifyPhone(item.phone\_number))

            {

                throw new Exception(\"Phone number incorrect\");

            }

            else if (!VerifyString(item.address))

            {

                throw new Exception(\"Address incorrect\");

            }

            

        }

    }

}

### EmployeeTypesDataHandler

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Text.RegularExpressions;

using System.Threading.Tasks;

namespace ClothingShop.DataHandlers

{

    class EmployeeTypesDataHandler : DataHandler\<employee\_type\>

    {

        private bool VerifyString(string name)

        {

            Regex nameRegex = new Regex(@\"\^(\[a-zA-Z\]+?)(\[-\\s\'\]\[a-zA-Z\]+)\*?\$\");

            return nameRegex.IsMatch(name);

        }

        private bool VerifySalery(double salery)

        {

            return salery != 0;

        }

        protected override void VerifyItem(employee\_type type)

        {

            if (!VerifyString(type.title))

            {

                throw new Exception(\"title incorrect\");

            }

            else if (!VerifySalery(type.salery))

            {

                throw new Exception(\"Salery Incorrect\");

            }

        }

    }

}

### ExpenseDataHandler

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ClothingShop.DataHandlers

{

    class ExpenseDataHandler : DataHandler\<expense\>

    {

        protected override void VerifyItem(expense item)

        {

        }

    }

}

### InventoryDataHandler

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ClothingShop.DataHandlers

{

    class InventoryDataHandler : DataHandler\<inventory\>

    {

        protected override void VerifyItem(inventory item)

        {

        }

    }

}

### MerchandiseCategoryDataHandler

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Text.RegularExpressions;

using System.Threading.Tasks;

namespace ClothingShop.DataHandlers

{

    class MerchandiseCategoryDataHandler : DataHandler\<merchandise\_category\>

    {

        private bool VerifyString(string name)

        {

            Regex nameRegex = new Regex(@\"\^(\[a-zA-Z\]+?)(\[-\\s\'\]\[a-zA-Z\]+)\*?\$\");

            return nameRegex.IsMatch(name);

        }

        protected override void VerifyItem(merchandise\_category item)

        {

            if (!VerifyString(item.clothing\_type))

            {

                throw new Exception(\"Clothing type incorrect\");

            }

            else if (!VerifyString(item.targeted\_customer))

            {

                throw new Exception(\"Targeted customer incorrect\");

            }

        }

    }

}

### MerchandiseDataHandler

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Text.RegularExpressions;

using System.Threading.Tasks;

namespace ClothingShop.DataHandlers

{

    class MerchandiseDataHandler : DataHandler\<merchandise\>

    {

        private bool VerifyString(string name)

        {

            Regex nameRegex = new Regex(@\"\^(\[a-zA-Z\]+?)(\[-\\s\'\]\[a-zA-Z\]+)\*?\$\");

            return nameRegex.IsMatch(name);

        }

        protected override void VerifyItem(merchandise item)

        {

            if (!VerifyString(item.name))

            {

                throw new Exception(\"Name incorrect\");

            }

            else if (!VerifyString(item.merchandise\_category.clothing\_type))

            {

                throw new Exception(\"Clothing type incorrect\");

            }

            else if (!VerifyString(item.merchandise\_category.targeted\_customer))

            {

                throw new Exception(\"targeted customer incorrect\");

            }

            else if (!VerifyString(item.size))

            {

                throw new Exception(\"size incorrect\");

            } 

        }

    }

}

### OrderDataHandler

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ClothingShop.DataHandlers

{

    class OrderDataHandler : DataHandler\<order\>

    {

        protected override void VerifyItem(order item)

        {

        }

    }

}

### ShiftsDataHandler

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ClothingShop.DataHandlers

{

    class ShiftDataHandler : DataHandler\<shift\>

    {

        protected override void VerifyItem(shift item)

        {

        }

    }

}

[סיכום]{dir="rtl"}
==================

[בכל מהלך בניית התוכנה למדתי רבות. למדתי איך להתמודד עם בעיות ותקלות
אפילו אם הן קשות ומסובכות, איך משתמשים במערכת]{dir="rtl"}
caliburn.micro[, בשיטת השכבות]{dir="rtl"} MVVM [והעמקתי המון את הידע שלי
על]{dir="rtl"} WPF [ו]{dir="rtl"}C\# [ובנוסף למדתי גם את הבסיס
של]{dir="rtl"} Regex[, אך בעיקר למדתי איך ללמוד, להתמודד בעצמי ולחפש
בעצמי פתרון. לסיכום בניית תוכנה זו הייתה חוויה מהנה ומאוד מעשירה להמשך
החיים.]{dir="rtl"}
