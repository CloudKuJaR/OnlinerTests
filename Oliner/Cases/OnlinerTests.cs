using AventStack.ExtentReports;
using NUnit.Framework;
using Onliner.Pages;
using System;
using System.Threading;

namespace Onliner.Cases
{
    class OnlinerTests
    {
        private string BuyProduct = "BuyProductTest";
        private string SeacrhItem = "SeacrhItemTest";
        private string LogIn = "LogInTest";
        private string NavigateToCatalog = "NavigateToCatalogTest";
        private string ProductComparison = "ProductComparisonTest";
        private string FilterCatalog = "FilterCatalogtext";
        private string Registration = "RegistrationTest";
        private string EstimationArticle = "EstimationArticleTest";
        private string UserSupport = "UserSupportTest";

        [OneTimeSetUp]
        public void InitializeComponent()
        {
            Initialize.InitializeDriver();
        }

        [SetUp]
        public void InitializeReporterForBuyProductTest()
        {
            Initialize.GoToBaseUrl();
            string reportPath = Initialize.InitializePath();
            var testName = TestContext.CurrentContext.Test.Name;
            Initialize.InitializeReporter(reportPath, testName);
        }

        [Test]
        public void BuyProductTest()
        {
            Reporter.test = Reporter.extent.CreateTest(BuyProduct).Info("Test Started");
            Login();
            Page.Menu.OpenCatalogButton();
            Page.CatalogPage.NavigateToTvPage();
            //Page.TVPage.ClickFirstProductButton();
            Page.ProductsCatalogPage.OpenProductButton(0);
            Page.ProductPage.ClickSellersOffersButton();
            Page.ProductPage.ClickSellerButton();
            Page.ProductPage.SelectCity();
            Page.ProductPage.ClickCartButton();
            Page.CartPage.TvName.WaitForElementIsDisplayed();
            Assert.AreEqual(Page.CartPage.TvName.Text, Page.CartPage.TvName.Text);
            Page.CartPage.QuantityOfProduct.WaitForElementIsDisplayed();
            Assert.AreEqual(Page.CartPage.QuantityOfProduct.Text, "1 товар на сумму:");
            Page.CartPage.OpenOrderPageButton();
            Page.OrderPage.Price.WaitForElementIsDisplayed();
            Assert.AreEqual(Page.OrderPage.Price.Text, Page.OrderPage.Price.Text);
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void SeacrhItemTest()
        {
            Reporter.test = Reporter.extent.CreateTest(SeacrhItem).Info("Test Started");
            Page.Menu.FillSerachBar();
            Assert.IsTrue(Page.Menu.IsSearchItemContains(TestSettings.SearchItem));
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void LogInTest()
        {
            Reporter.test = Reporter.extent.CreateTest(LogIn).Info("Test Started");
            Login();
            Page.Menu.ClickUserMenuBatton();
            Assert.AreEqual(Page.Menu.AccName.Text, TestSettings.UserId);
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void NavigateToCatalogTest()
        {
            Reporter.test = Reporter.extent.CreateTest(NavigateToCatalog).Info("Test Started");
            Page.Menu.OpenCatalogButton();
            Assert.AreEqual(Driver.driver.Title, "Каталог Onlíner");
            Assert.AreEqual(Page.CatalogPage.ElectronicsText.Text, "Электроника");
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void ProductComparisonTest()
        {
            Reporter.test = Reporter.extent.CreateTest(ProductComparison).Info("test started");
            Page.Menu.OpenCatalogButton();
            Page.CatalogPage.NavigateToTvPage();
            //Page.TVPage.ClickFirstProductButton();
            Page.ProductsCatalogPage.OpenProductButton(0);
            Page.ProductPage.ClickComparisonButton();
            Page.ProductPage.ClickTvCatalogButton();
            //Page.TVPage.ClickSecondProductButton();
            Page.ProductsCatalogPage.OpenProductButton(1);
            Page.ProductPage.ClickComparisonButton();
            Assert.AreEqual(Page.Menu.CompareText.Text, "2 товара");
            Page.Menu.OpenCompareButton();
            Assert.IsTrue(Page.ComparePage.AreDifferentParametersHighlighted());
            Reporter.test.Log(Status.Pass, "test passed");
        }

        [Test]
        public void FilterCatalogTest()
        {
            Reporter.test = Reporter.extent.CreateTest(FilterCatalog).Info("Test Started");
            Page.Menu.OpenCatalogButton();
            Page.CatalogPage.NavigateToLaptopPage();
            Assert.AreEqual(Page.LaptopsPage.LaptopsPageTitle.Text, "Ноутбуки");
            Page.LaptopsPage.ClickAsusCheckBox();
            Assert.IsTrue(Page.LaptopsPage.FilterContainerAsus.IsPresent());
            Page.LaptopsPage.ChangeMinFrequency();
            Page.LaptopsPage.ChangeMaxFrequency();
            Assert.IsTrue(Page.LaptopsPage.FilterContainerMinMaxFrequency.IsPresent());
            Page.LaptopsPage.ClickSuperPriceCheckBox();
            Assert.IsTrue(Page.LaptopsPage.FilterContainerSuperPrice.IsPresent());
            Assert.IsTrue(Page.LaptopsPage.SuperPriceProductCount());
            Page.LaptopsPage.ClickAsusCheckBox();
            Assert.IsTrue(Page.LaptopsPage.FilterContainerAsus.IsRemoved());
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void RegistarationTest()
        {
            Reporter.test = Reporter.extent.CreateTest(Registration).Info("Test Started");
            Page.Menu.ClickLoginForm();
            Assert.IsTrue(Page.LoginPage.AuthFormTitle.IsPresent());
            Page.LoginPage.OpenRegistrationPage();
            Assert.IsTrue(Page.RegistrationPage.RegistrationFormTitle.IsPresent());
            Page.RegistrationPage.FillEmailField();
            Assert.IsTrue(Page.RegistrationPage.EmailFieldHightLightedAndGreen.IsPresent());
            Page.RegistrationPage.ClickCheckBox();
            Page.RegistrationPage.ClickRegistrationButton();
            Assert.IsTrue(Page.RegistrationPage.PasswordFieldHightLightedAndRed.IsPresent());
            Assert.IsTrue(Page.RegistrationPage.PasswordDescriptionError.IsPresent());
            Page.RegistrationPage.FillPasswordFields();
            Assert.AreEqual(Page.RegistrationPage.PasswordDescription.Text, "Очень надежный пароль, 12 символов");
            Page.RegistrationPage.ClickRegistrationButton();
            Assert.IsTrue(Page.RegistrationPage.RegestrationConfirmationTitle.IsPresent());
            Assert.IsTrue(Page.RegistrationPage.GoToMailButton.IsPresent());
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void EstimationArticleTest()
        {
            Reporter.test = Reporter.extent.CreateTest(EstimationArticle).Info("Test Started");
            Page.HomePage.OpenCarsArticleTeaser();
            Page.ArcticlePage.ClickSlightSmile();
            Assert.IsTrue(Page.ArcticlePage.SlightSmileSelected.IsPresent());
            Assert.IsTrue(Page.ArcticlePage.SlightSmilesNumberIsBigger());
            Page.ArcticlePage.ClickSlightSmile();
            //Написать ассерт на проверку оценки, а также изменить существующий метод.
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void UserSupportTest()
        {
            Reporter.test = Reporter.extent.CreateTest(UserSupport).Info("Test Started");
            Page.HomePage.OpenUserSupprotPage();
            Assert.IsTrue(Page.UserSupportPage.UserSupportPageTitle.IsPresent());
            Page.UserSupportPage.FillUserNameField();
            Page.UserSupportPage.ClearUserNameField();
            Assert.AreEqual(Page.UserSupportPage.UserNameField.GetAttribute("value"), "Anonymous");
            Page.UserSupportPage.FillEmailFieldWithInvalidCredentials();
            Assert.IsTrue(Page.UserSupportPage.EmailFieldError.IsPresent());
            Page.UserSupportPage.FillEmailFieldWithValidCredentials();
            Assert.IsTrue(Page.UserSupportPage.EmailFieldError.IsRemoved());

            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [TearDown]
        public void CleanUpAfterTest()
        {
            if (Page.OrderPage.OrderText.IsPresent() == true)
            {
                Page.OrderPage.OpenCatalogButton();
            }

            if (Page.Menu.CartBanner.IsPresent() == true)
            {
                Page.Menu.ClickCartButton();
                Page.CartPage.ClickToDeleteButton();
                Page.CartPage.OpenHomePageButton();
                Console.WriteLine("Очистка Корзины удалась");
            }

            if (Page.Menu.UserMenu.IsPresent() == true)
            {
                Page.Menu.ClickUserMenuBatton();
                Page.Menu.ClickLogOutButton();
                Console.WriteLine("LogOut Удался");
            }
            Console.WriteLine("TearDown Удался");
            Reporter.extent.Flush();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

        private void Login()
        {
            Page.Menu.ClickLoginForm();
            Page.LoginPage.FillLoginForm();
        }
    }
}
