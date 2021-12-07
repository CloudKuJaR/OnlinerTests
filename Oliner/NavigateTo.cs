using Onliner.Pages;
using System.Threading;

namespace Onliner
{
    class NavigateTo
    {
        public static void LoginFormScenario()
        {
            HomePage homePage = new HomePage();
            Thread.Sleep(800);
            homePage.authButton.Click();
            Thread.Sleep(2000);
        }
    }
}
