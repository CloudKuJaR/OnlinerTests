using NUnit.Framework;
using Onliner.Actions;
using System.Threading;

namespace Onliner.Cases
{
    class ItemSearch
    {
        [OneTimeSetUp]
        public void InitializeComponent()
        {
            Initialize.InitializeComponents();
        }

        [Test]
        public void SeacrhItem()
        {
            ActionsHomePage.FillSerachBar();
            Thread.Sleep(5000);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }



}

