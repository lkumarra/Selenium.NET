using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Interfaces
{
    public interface IConfig
    {
        string GetBrowser();

        string GetUserName();

        string GetPassword();

        string GetUrl();
    }
}
