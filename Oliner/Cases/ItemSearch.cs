using NUnit.Framework;
using System.Threading;

namespace Onliner.Cases
{
    class ItemSearch
    {

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void SeacrhItem()
        {
            Thread.Sleep(2000);
            Actions.FillSerachBar();
            Thread.Sleep(3000);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }



}

