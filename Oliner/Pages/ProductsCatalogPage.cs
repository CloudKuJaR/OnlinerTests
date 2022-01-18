using Onliner.WebElementExtension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace Onliner.Pages
{
    public class ProductsCatalogPage
    {
        private const string PRODUCTS_CONTAINER = "//div[@class='catalog-content js-scrolling-area']";
        private const string PRODUCT = ".//span[@data-bind='html: product.extended_name || product.full_name']";
        private const string MANUFACTURER_CONTAINER_DROP_DOWN_MENU = "(//div[@class='schema-filter-control__item'])[2]/..";
        private const string SUPER_PRICE = "//div[@class='schema-filter__facet schema-filter__facet_specific']//span[@class='i-checkbox']";
        private const string QUANTITY_OF_PRODUCTS = "//span[@class='schema-filter-button__sub schema-filter-button__sub_main']";
        private const string MANUFACTURER_LOCATOR = "(//div[@class='schema-filter-popover__inner'])[2]//input[@value='{0}']/..";

        public MyWebElement SuperPrice => new MyWebElement(By.XPath(SUPER_PRICE));
        public MyWebElement ProductsContainer => new MyWebElement(By.XPath(PRODUCTS_CONTAINER));
        public MyWebElement ManufacturerContainerDropDownMenu => new MyWebElement(By.XPath(MANUFACTURER_CONTAINER_DROP_DOWN_MENU));
        public MyWebElement QuantityOfProducts => new MyWebElement(By.XPath(QUANTITY_OF_PRODUCTS));

        public void ChooseManufacturer(string ManufacturerName) => new MyWebElement(By.XPath(string.Format(MANUFACTURER_LOCATOR, ManufacturerName))).Click();

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

        public int GetQuantityOfProducts()
        {
            QuantityOfProducts.WaitForElementIsDisplayed();
            string productsQuantityString = QuantityOfProducts.Text;
            int quantityOfProductsValue = int.Parse(string.Join("", productsQuantityString.Where(c => char.IsDigit(c))));

            return quantityOfProductsValue;
        }

        public bool ComparingTheQuantityOfProducts(int oldValue, int newValue)
        {
            return newValue < oldValue;
        }
    }
}
