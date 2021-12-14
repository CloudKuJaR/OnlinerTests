using NUnit.Framework;
using Onliner.Actions;

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
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }



}

