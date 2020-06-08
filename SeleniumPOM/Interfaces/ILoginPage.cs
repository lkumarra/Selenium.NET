using SeleniumPOM.Pages.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Interfaces
{
    interface ILoginPage
    {
        void SetUserName(string UserName);

        void SetPassword(string Password);

        void ClickOnLogin();

        void ClickOnReset();

        HomePage Login(string UserName, string Passeword);
    }
}
