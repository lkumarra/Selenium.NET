using SeleniumPOM.Pages.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Interfaces
{
    interface IHomePage
    {
        string GetWelcomeMessage();

        string GetManagerID();

        NewCustomerPage ClickOnNewCustomerLink();

        EditCustomerPage ClickOnEditCustomerPage();
        
    }
}
