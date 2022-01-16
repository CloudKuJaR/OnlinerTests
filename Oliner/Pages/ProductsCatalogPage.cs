using Onliner.WebElementExtension;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace Onliner.Pages
{
    public class ProductsCatalogPage
    {
        public const string PRODUCTS_CONTAINER = "//div[@class='catalog-content js-scrolling-area']";

        public MyWebElement ProductsContainer => new MyWebElement(By.XPath(PRODUCTS_CONTAINER));

        public void OpenProductButton(int productNumber)
        {
            //ProductsContainer.WaitForElementIsDisplayed();
            Thread.Sleep(500);
            var Products = ProductsContainer.FindElements(By.XPath(".//span[@data-bind='html: product.extended_name || product.full_name']"));
            Products[productNumber].Click();
        }
        
    }
}
