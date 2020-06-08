using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Interfaces
{
    interface IEditCostumerPage
    {
        void SetCostumerID(string CostumerID);

        void ClickOnSubmitButton();

        void ClickOnResetButton();

        string GetCostumerIDMessage();

        string CustomerIDInvaildCharactersAndMessageText(string Characters);

        string GetCostumerIDAlertMessage();
    }
}
