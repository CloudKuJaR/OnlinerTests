using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Onliner.Cases
{
    class NavigateToCatalog
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void NavigateToCatalogTest()
        {
            Thread.Sleep(2000);
            NavigateTo.Catalog();
            Thread.Sleep(3000);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
