﻿using AventStack.ExtentReports;
using NUnit.Framework;
using Onliner.Pages;
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
            Page.ProductPage.ClickSellerButton();
            Page.ProductPage.SelectCity();
            Page.ProductPage.ClickCartButton();
            Page.CartPage.TvName.WaitForElementIsDisplayed();
            Assert.AreEqual(Page.CartPage.TvName.Text, productName);
            Page.CartPage.QuantityOfProduct.WaitForElementIsDisplayed();
            Assert.AreEqual(Page.CartPage.QuantityOfProduct.Text, quantityOfProducts);
            string productPrice = Page.CartPage.GetProductPrice();
            Page.CartPage.OpenOrderPageButton();
            Page.OrderPage.Price.WaitForElementIsDisplayed();
            Assert.AreEqual(Page.OrderPage.Price.Text, productPrice);
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
            Assert.AreEqual(Page.Menu.AccName.Text, TestSettings.UserId);
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void NavigateToCatalogTest()
        {
            Page.Menu.OpenCatalogButton();
            Assert.AreEqual(Driver.driver.Title, catalogPageTitle);
            Assert.AreEqual(Page.CatalogPage.ElectronicsText.Text, catalogElectronicsText);
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
            Assert.AreEqual(Page.Menu.CompareText.Text, quantityOfComparableProducts);
            Page.Menu.OpenComparePage();
            Assert.IsTrue(Page.ComparePage.AreDifferentParametersHighlighted());
            Reporter.test.Log(Status.Pass, "test passed");
        }

        [Test]
        public void FilterCatalogTest()
        {
            Page.Menu.OpenCatalogButton();
            Page.CatalogPage.NavigateToLaptopPage();
            Assert.AreEqual(Page.LaptopsPage.LaptopsPageTitle.Text, laptopsPageTitle);
            int firstValue = Page.LaptopsPage.GetQuantityOfProducts();
            Page.LaptopsPage.ClickManufactureContainerButton();
            Page.LaptopsPage.ChooseManufacturer(nameOfManufacturer);
            Assert.IsTrue(Page.LaptopsPage.IsFilterContanerContaisFilter(nameOfManufacturerInFilterContainer));
            int secondValue = Page.LaptopsPage.GetQuantityOfProducts();
            Assert.IsTrue(Page.LaptopsPage.ComparingTheQuantityOfProducts(firstValue, secondValue));
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
            Assert.AreEqual(Page.RegistrationPage.PasswordDescription.Text, passwordDescription);
            Page.RegistrationPage.ClickRegistrationButton();
            Assert.IsTrue(Page.RegistrationPage.RegestrationConfirmationTitle.IsPresent());
            Assert.IsTrue(Page.RegistrationPage.GoToMailButton.IsPresent());
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void EstimationArticleTest()
        {
            Page.HomePage.OpenCarsArticleTeaser();
            int firstValue = Page.ArcticlePage.GetSlightSmilesValues();
            Page.ArcticlePage.ClickSlightSmile();
            int secondValue = Page.ArcticlePage.GetSlightSmilesValues();
            Assert.IsTrue(Page.ArcticlePage.SlightSmileSelected.IsPresent());
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
            Assert.IsTrue(Page.UserSupportPage.UserSupportPageTitle.IsPresent());
            Page.UserSupportPage.FillUserNameField();
            Page.UserSupportPage.ClearUserNameField();
            Assert.AreEqual(Page.UserSupportPage.UserNameField.GetAttribute("value"), "Anonymous");
            Page.UserSupportPage.FillEmailFieldWithInvalidCredentials();
            Assert.IsTrue(Page.UserSupportPage.EmailFieldError.IsPresent());
            Page.UserSupportPage.FillEmailFieldWithValidCredentials();
            Assert.IsTrue(Page.UserSupportPage.EmailFieldError.IsRemoved());
            Assert.IsTrue(Page.UserSupportPage.DropDownMenusOptionsCount());
            Assert.IsTrue(Page.UserSupportPage.IsDiscriptionsPresent());
            Assert.IsTrue(Page.UserSupportPage.IsCaptchaPresent());
            Assert.IsTrue(Page.UserSupportPage.IsAddButtonPresent());
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
            Assert.AreEqual(firstAmountCurrencyFieldValue,secondAmountCurrencyFieldValue);
            int randomValue = Page.CurrencyConversionPage.GetRandomValue();
            Page.CurrencyConversionPage.FillAmountCurrencyFieldWithValidData(randomValue.ToString());
            Page.CurrencyConversionPage.ChooseTypeOfCurrency(eur);
            float bankSellingPrice = Page.CurrencyConversionPage.GetBankSellingPrice();
            Assert.AreEqual(randomValue * bankSellingPrice, Page.CurrencyConversionPage.ConvertConversionResultStringToFloat());
            Assert.AreEqual(Page.CurrencyConversionPage.ConversionResultTypeOfCurrency.Text, conversionResultTypeOfCurrency);
            Reporter.test.Log(Status.Pass, "Test Passed");
        }

        [Test]
        public void RealtyPageTest()
        {

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
                Page.Menu.OpenCartPage();
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
            Page.Menu.OpenLoginForm();
            Page.LoginPage.FillLoginForm();
        }
    }
}
