using Onliner.WebElementExtension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Onliner.Pages
{
    public class ProductsCatalogPage
    {
        public const string PRODUCTS_CONTAINER = "//div[@class='catalog-content js-scrolling-area']";
        public const string PRODUCT = ".//span[@data-bind='html: product.extended_name || product.full_name']";
        public const string MANUFACTURER_CONTAINER_DROP_DOWN_MENU = "(//div[@class='schema-filter-control__item'])[2]/..";
        public const string SUPER_PRICE = "//div[@class='schema-filter__facet schema-filter__facet_specific']//span[@class='i-checkbox']";
        public const string QUANTITY_OF_PRODUCTS = "//span[@class='schema-filter-button__sub schema-filter-button__sub_main']";

        public MyWebElement SuperPrice => new MyWebElement(By.XPath(SUPER_PRICE));
        public MyWebElement ProductsContainer => new MyWebElement(By.XPath(PRODUCTS_CONTAINER));
        public MyWebElement ManufacturerContainerDropDownMenu => new MyWebElement(By.XPath(MANUFACTURER_CONTAINER_DROP_DOWN_MENU));
        public MyWebElement QuantityOfProducts => new MyWebElement(By.XPath(QUANTITY_OF_PRODUCTS));

        public void OpenProductPage(int productNumber)
        {
            var wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => ProductsContainer.FindElements(By.XPath(PRODUCT)).Count != 0);
            var Products = ProductsContainer.FindElements(By.XPath(PRODUCT));
            Products[productNumber].Click();
        }

        public void ClickManufactureContainerButton()
        {
            ManufacturerContainerDropDownMenu.ScrollToElement();
            ManufacturerContainerDropDownMenu.Click();
        }

        public void ChooseManufacturer(string ManufacturerName)
        {
            Driver.driver.FindElement(By.XPath($"(//div[@class='schema-filter-popover__inner'])[2]//input[@value='{ManufacturerName}']/..")).Click();
        }

        public int GetQuantityOfProducts()
        {
            QuantityOfProducts.WaitForElementIsDisplayed();
            return int.Parse(QuantityOfProducts.Text);
        }

        public bool ComparingTheQuantityOfProducts(int oldValue, int newValue)
        {
            return newValue < oldValue;
        }
    }
}
