using AventStack.ExtentReports;
using NUnit.Framework;
using Onliner.Pages;
using Onliner.WebDriverExtension;
using OpenQA.Selenium;
using System;

namespace Onliner.Cases
{
    class OnlinerTests
    {
        private string maxFrequency = "165hz";
        private string minFrequency = "120hz";
        private string quantityOfProducts = "1 товар на сумму:";
        private string catalogPageTitle = "Каталог Onlíner";
        private string catalogElectronicsText = "Электроника";
        private string quantityOfComparableProducts = "2 товара";
        private string laptopsPageTitle = "Ноутбуки";
        private string nameOfManufacturer = "asus";
        private string nameOfManufacturerInFilterContainer = "ASUS";
        private string frequencyInFilterContainer = "120 Гц — 165 Гц";
        private string superPriceInFilterContainer = "Суперцена";
        private string passwordDescription = "Очень надежный пароль, 12 символов";
        private string eur = "eur";
        private string conversionResultTypeOfCurrency = "BYN";
        private string currencyTypeTextForUSD = "1 USD";
        private string currencyTypeTextForEUR = "1 EUR";
        private string currencyTypeTextForRUB = "100 RUB";
        private string currencyConversionPageTitle = "Лучшие курсы валют";
        private string cityName = "Минск";
        private string numberOfRooms = "2";
        private string flatPriceTo = "500";
        private string subwayDropDownMemuOption = "Возле метро";
        private string sortByDropDownMenuOption = "Сначала дорогие";
        private string housesAndFlatsPageTitle = "Снять квартиру, аренда жилья в Минске";

        private static IWebDriver WebDriver => Driver.driver;

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
            Reporter.test = Reporter.extent.CreateTest(testName).Info("Test Started");
        }

        [Test]
        public void BuyProductTest()
        {
            Login();
            Page.Menu.OpenCatalogButton();
            Page.CatalogPage.NavigateToTvPage();
            Page.ProductsCatalogPage.OpenProductPage(0);
            string productName = Page.ProductPage.GetProductName();
            Page.ProductPage.ClickSellersOffersButton();
            Page.ProductPage.SelectCity();
            Page.ProductPage.ClickSellerButton();
            Page.ProductPage.ClickCartButton();
            Assert.AreEqual(Page.CartPage.GetTvNameText(), productName);
            Assert.AreEqual(Page.CartPage.GetQuantityOfProductText(), quantityOfProducts);
            string productPrice = Page.CartPage.GetProductPrice();
            Page.CartPage.OpenOrderPageButton();
            Assert.AreEqual(Page.OrderPage.GetPriceText(), productPrice);
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void SeacrhItemTest()
        {
            Page.Menu.FillSerachBar();
            Assert.IsTrue(Page.Menu.IsSearchItemContains(TestSettings.SearchItem));
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void LogInTest()
        {
            Login();
            Page.Menu.ClickUserMenuBatton();
            Assert.AreEqual(Page.Menu.GetAccNameText(), TestSettings.UserId);
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void NavigateToCatalogTest()
        {
            Page.Menu.OpenCatalogButton();
            Assert.AreEqual(Driver.driver.Title, catalogPageTitle);
            Assert.AreEqual(Page.CatalogPage.GetElectronicsText(), catalogElectronicsText);
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void ProductComparisonTest()
        {
            Page.Menu.OpenCatalogButton();
            Page.CatalogPage.NavigateToTvPage();
            Page.ProductsCatalogPage.OpenProductPage(0);
            Page.ProductPage.ClickComparisonButton();
            Page.ProductPage.ClickTvCatalogButton();
            Page.ProductsCatalogPage.OpenProductPage(1);
            Page.ProductPage.ClickComparisonButton();
            Assert.AreEqual(Page.Menu.GetCompareText(), quantityOfComparableProducts);
            Page.Menu.OpenComparePage();
            Assert.IsTrue(Page.ComparePage.AreDifferentParametersHighlighted());
            Reporter.test.Log(Status.Pass, "test passed");
        }

        [Test]
        public void FilterCatalogTest()
        {
            Page.Menu.OpenCatalogButton();
            Page.CatalogPage.NavigateToLaptopPage();
            Assert.AreEqual(Page.LaptopsPage.GetLaptopsPageTitleText(), laptopsPageTitle);
            //int firstValue = Page.LaptopsPage.GetQuantityOfProducts();
            Page.LaptopsPage.ClickManufactureContainerButton();
            Page.LaptopsPage.ChooseManufacturer(nameOfManufacturer);
            Assert.IsTrue(Page.LaptopsPage.IsFilterContanerContaisFilter(nameOfManufacturerInFilterContainer));
            //int secondValue = Page.LaptopsPage.GetQuantityOfProducts();
            //Assert.IsTrue(Page.LaptopsPage.ComparingTheQuantityOfProducts(firstValue, secondValue));
            Page.LaptopsPage.ChangeMinFrequency(minFrequency);
            Page.LaptopsPage.ChangeMaxFrequency(maxFrequency);
            Assert.IsTrue(Page.LaptopsPage.IsFilterContanerContaisFilter(frequencyInFilterContainer));
            Page.LaptopsPage.ClickSuperPriceCheckBox();
            Assert.IsTrue(Page.LaptopsPage.IsFilterContanerContaisFilter(superPriceInFilterContainer));
            Assert.IsTrue(Page.LaptopsPage.AreAllProductsContainsSuperPriceBanner());
            Page.LaptopsPage.ClickManufactureContainerButton();
            Page.LaptopsPage.ChooseManufacturer(nameOfManufacturer);
            Page.LaptopsPage.ClickManufactureContainerButton();
            Assert.IsFalse(Page.LaptopsPage.IsFilterContanerContaisFilter(nameOfManufacturerInFilterContainer));
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void RegistarationTest()
        {
            Page.Menu.OpenLoginForm();
            Assert.IsTrue(Page.LoginPage.IsAuthFormTitlePresent());
            Page.LoginPage.OpenRegistrationPage();
            Assert.IsTrue(Page.RegistrationPage.IsRegistrationFormTitlePresent());
            Page.RegistrationPage.FillEmailField();
            Assert.IsTrue(Page.RegistrationPage.IsEmailFieldHightLightedAndGreenPresent());
            Page.RegistrationPage.ClickCheckBox();
            Page.RegistrationPage.ClickRegistrationButton();
            Assert.IsTrue(Page.RegistrationPage.IsPasswordFieldHightLightedAndRedPresent());
            Assert.IsTrue(Page.RegistrationPage.IsPasswordDescriptionErrorPresent());
            Page.RegistrationPage.FillPasswordFields();
            Assert.AreEqual(Page.RegistrationPage.GetPasswordDescriptionText(), passwordDescription);
            Page.RegistrationPage.ClickRegistrationButton();
            Assert.IsTrue(Page.RegistrationPage.IsRegestrationConfirmationTitlePresent());
            Assert.IsTrue(Page.RegistrationPage.IsGoToMailButtonPresent());
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void EstimationArticleTest()
        {
            Page.HomePage.OpenCarsArticleTeaser();
            int firstValue = Page.ArcticlePage.GetSlightSmilesValues();
            Page.ArcticlePage.ClickSlightSmile();
            int secondValue = Page.ArcticlePage.GetSlightSmilesValues();
            Assert.IsTrue(Page.ArcticlePage.IsSlightSmileSelectedPresent());
            Assert.AreEqual(firstValue + 1, secondValue);
            Page.ArcticlePage.ClickSlightSmile();
            int thirdValue = Page.ArcticlePage.GetSlightSmilesValues();
            Assert.AreEqual(secondValue, thirdValue);
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void UserSupportTest()
        {
            Page.HomePage.OpenUserSupprotPage();
            Assert.IsTrue(Page.UserSupportPage.IsUserSupportPageTitlePresent());
            Page.UserSupportPage.FillUserNameField();
            Page.UserSupportPage.ClearUserNameField();
            Assert.AreEqual(Page.UserSupportPage.GetUserNameFieldAttribute(), "Anonymous");
            Page.UserSupportPage.FillEmailFieldWithInvalidCredentials();
            Assert.IsTrue(Page.UserSupportPage.IsEmailFieldErrorPresent());
            Page.UserSupportPage.FillEmailFieldWithValidCredentials();
            Assert.IsTrue(Page.UserSupportPage.IsEmailFieldErrorRemoved());
            Assert.IsTrue(Page.UserSupportPage.DropDownMenusOptionsCount());
            Assert.IsTrue(Page.UserSupportPage.IsShortDiscriptionsPresent());
            Assert.IsTrue(Page.UserSupportPage.IsDetaildDiscriptionPresent());
            Assert.IsTrue(Page.UserSupportPage.IsCaptchaFieldPresent());
            Assert.IsTrue(Page.UserSupportPage.IsCapthcaImgPresent());
            Assert.IsTrue(Page.UserSupportPage.IsAddButtonPresent());
            Assert.IsTrue(Page.UserSupportPage.IsAddButtonEnable());
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void CurrencyConversionTest()
        {
            Page.HomePage.OpenCurrencyConversionPage();
            Page.CurrencyConversionPage.ClickBuyButton();
            Assert.AreEqual(Page.CurrencyConversionPage.GetCurrecnyPageTitle(), currencyConversionPageTitle);
            Assert.IsTrue(Page.CurrencyConversionPage.IsTheDateCorrect());
            Assert.IsTrue(Page.CurrencyConversionPage.IsCurrencyTypePresent(currencyTypeTextForUSD));
            Assert.IsTrue(Page.CurrencyConversionPage.IsCurrencyTypePresent(currencyTypeTextForEUR));
            Assert.IsTrue(Page.CurrencyConversionPage.IsCurrencyTypePresent(currencyTypeTextForRUB));
            string firstAmountCurrencyFieldValue = Page.CurrencyConversionPage.GetAmountCurrencyFieldValue();
            Page.CurrencyConversionPage.FillAmountCurrencyFieldWithInvalidData();
            string secondAmountCurrencyFieldValue = Page.CurrencyConversionPage.GetAmountCurrencyFieldValue();
            Assert.AreEqual(firstAmountCurrencyFieldValue, secondAmountCurrencyFieldValue);
            int randomValue = Page.CurrencyConversionPage.GetRandomValue();
            Page.CurrencyConversionPage.FillAmountCurrencyFieldWithValidData(randomValue.ToString());
            Page.CurrencyConversionPage.ChooseTypeOfCurrency(eur);
            float bankSellingPrice = Page.CurrencyConversionPage.GetBankSellingPrice();
            Assert.AreEqual(Math.Round(randomValue * bankSellingPrice), Math.Round(Page.CurrencyConversionPage.ConvertConversionResultStringToFloat()));
            Assert.AreEqual(Page.CurrencyConversionPage.ConversionResultTypeOfCurrency.Text, conversionResultTypeOfCurrency);
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void RealtyPageTest()
        {
            Page.HomePage.OpenHousesAndFlatsPage();
            Page.HousesAndFlatsPage.ClickRentButton();
            Page.HousesAndFlatsPage.ClickCityAndAddressDropDownMenu();
            Page.HousesAndFlatsPage.ChooseCity(cityName);
            int firstResultsValue = Page.HousesAndFlatsPage.GetQuantityOfFlats();
            Assert.AreEqual(Page.HousesAndFlatsPage.GetPageTitle(), housesAndFlatsPageTitle);
            Assert.IsTrue(Page.HousesAndFlatsPage.IsMapPresent());
            Page.HousesAndFlatsPage.ClickFilterFlatButton();
            Page.HousesAndFlatsPage.WaitForQuantityOfFlatsChanged(firstResultsValue);
            int secondResultValue = Page.HousesAndFlatsPage.GetQuantityOfFlats();
            Assert.IsTrue(firstResultsValue > secondResultValue);
            Assert.IsTrue(Page.HousesAndFlatsPage.IsFlatContainsOnlyNumberOfRooms());
            Page.HousesAndFlatsPage.ChooseNumberOfRooms(numberOfRooms);
            Page.HousesAndFlatsPage.WaitForQuantityOfFlatsChanged(secondResultValue);
            int thirdResultValue = Page.HousesAndFlatsPage.GetQuantityOfFlats();
            Assert.IsTrue(secondResultValue > thirdResultValue);
            Assert.IsTrue(Page.HousesAndFlatsPage.IsFlatContainsOnlyTwoRoomsFlat());
            Page.HousesAndFlatsPage.FillFilterPriceToField(flatPriceTo);
            Page.HousesAndFlatsPage.WaitForQuantityOfFlatsChanged(thirdResultValue);
            Assert.IsTrue(Page.HousesAndFlatsPage.IsFlatContainsPriceLessThan());
            Page.HousesAndFlatsPage.ClickSubWayDropDownMenu();
            Page.HousesAndFlatsPage.ChooseSubWayDropDownMenuOption(subwayDropDownMemuOption);
            Page.HousesAndFlatsPage.WaitForQuantityOfFlatsChanged(thirdResultValue);
            int fourthResultValue = Page.HousesAndFlatsPage.GetQuantityOfFlats();
            Assert.IsTrue(thirdResultValue > fourthResultValue);
            string firstStreetNameOfTheFirstFlat = Page.HousesAndFlatsPage.GetStreetNameOfTheFirstFlat();
            Page.HousesAndFlatsPage.ClickFilterSortByDropDownMenu();
            Page.HousesAndFlatsPage.ChooseFilterSortByDropDownMenuOption(sortByDropDownMenuOption);
            WebDriver.GetWait().Until(drv => firstStreetNameOfTheFirstFlat != Page.HousesAndFlatsPage.GetStreetNameOfTheFirstFlat());
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [TearDown]
        public void CleanUpAfterTest()
        {
            if (Page.OrderPage.IsOrderTextPresent() == true)
            {
                Page.OrderPage.OpenCatalogPage();
            }

            if (Page.Menu.IsCartBannerPresent() == true)
            {
                Page.Menu.OpenCartPage();
                Page.CartPage.ClickDeleteButton();
                Page.CartPage.OpenHomePageButton();
                Console.WriteLine("Очистка Корзины удалась");
            }

            if (Page.Menu.IsUserMenuPresent() == true)
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
            Page.Menu.OpenLoginForm();
            Page.LoginPage.FillLoginForm();
        }
    }
}
