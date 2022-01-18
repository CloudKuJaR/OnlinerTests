using Onliner.WebElementExtension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Onliner.Pages
{
    public class LaptopsPage: ProductsCatalogPage
    {
        public const string MIN_FREQUENCY_DROP_DOWN_MENU = "(//span[text()='Частота матрицы']/parent::div/parent::div//select[@class='schema-filter-control__item'])[1]";
        public const string MAX_FREQUENCY_DROP_DOWN_MENU = "(//span[text()='Частота матрицы']/parent::div/parent::div//select[@class='schema-filter-control__item'])[2]";
        public const string LAPTOPS_PAGE_TITLE = "//h1[text()='Ноутбуки']";
        public const string ELEMENT_CONTAINER = "//div[@class='js-schema-results schema-grid__center-column']";
        
        public MyWebElement LaptopsPageTitle => new MyWebElement(By.XPath(LAPTOPS_PAGE_TITLE));
        public MyWebElement ElementsContainer => new MyWebElement(By.XPath(ELEMENT_CONTAINER));
        public SelectElement MinFrequencyDropDownMenu => new SelectElement(Driver.driver.FindElement(By.XPath(MIN_FREQUENCY_DROP_DOWN_MENU)));
        public SelectElement MaxFrequencyDropDownMenu => new SelectElement(Driver.driver.FindElement(By.XPath(MAX_FREQUENCY_DROP_DOWN_MENU)));

        public void ChangeMinFrequency(string minFrequency)
        {
            MinFrequencyDropDownMenu.SelectByValue(minFrequency); 
        }

        public void ChangeMaxFrequency(string maxFrequency)
        {
            MaxFrequencyDropDownMenu.SelectByValue(maxFrequency);
        }

        public void ClickSuperPriceCheckBox()
        {
            SuperPrice.Click();
        }

        public bool SuperPriceProductCount()
        {
            var wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));

            wait.Until(drv => ElementsContainer.FindElements(By.XPath(".//span[@data-bind='html: product.extended_name || product.full_name']")).Count != 0);

            //Thread.Sleep(1000);
            var Products = ElementsContainer.FindElements(By.XPath(".//span[@data-bind='html: product.extended_name || product.full_name']"));

            wait.Until(drv => ElementsContainer.FindElements(By.XPath(".//div[@class='schema-product__hot']")).Count != 0);

            //Thread.Sleep(1000);
            var SuperPriceBanner = ElementsContainer.FindElements(By.XPath(".//div[@class='schema-product__hot']"));

            return Products.Count == SuperPriceBanner.Count;
        }

        public bool FilterContanerContais(string filterText)
        {
            MyWebElement FilterElemet = new MyWebElement(By.XPath($"//span[@class='schema-tags__text'][text()='{filterText}']"));
            return FilterElemet.IsPresent(); ;
        }
    }
}
