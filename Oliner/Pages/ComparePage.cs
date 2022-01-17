using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class ComparePage
    {
        private MyWebElement ComparsionContainer => new MyWebElement(By.XPath("//*[contains(@class,'product-table__cell_accent')]/parent::tr"));

        public bool AreDifferentParametersHighlighted()
        {
            var comparasionValues = ComparsionContainer.FindElements(By.XPath("./td//span[@class='value__text']"));

            return comparasionValues[0].Text != comparasionValues[1].Text;
        }
    }
}
