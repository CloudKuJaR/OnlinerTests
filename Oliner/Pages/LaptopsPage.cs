using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class LaptopsPage
    {
        public const string ASUS = "(//span[@class='i-checkbox']//input[@value='asus'])[1]";

        public MyWebElement Asus => new MyWebElement(By.XPath(ASUS));
        //$x("//span[text()='Частота матрицы']/parent::div/parent::div//select[@class='schema-filter-control__item']")
        public void ClickAsusCheckBox()
        {
            Asus.Click();
        }

        public void ChangeHzFilte()
        {

        }


    }
}
