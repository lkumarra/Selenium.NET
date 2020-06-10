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

        /// <summary>
        /// Enter username on username field on login page.
        /// </summary>
        /// <param name="UserName">User name to login</param>
        void SetUserName(string UserName);

        /// <summary>
        /// Enter password on passworn=d field on login page.
        /// </summary>
        /// <param name="Password">Password to login</param>
        void SetPassword(string Password);

        /// <summary>
        /// Click on Login Button.
        /// </summary>
        void ClickOnLogin();

        /// <summary>
        /// Click on Reset Button.
        /// </summary>
        void ClickOnReset();

        /// <summary>
        /// Perform login operation on login page.
        /// </summary>
        /// <param name="UserName">Username to login</param>
        /// <param name="Passeword">Password to login</param>
        /// <returns>Object of HomePage</returns>
        HomePage Login(string UserName, string Passeword);
    }
}
