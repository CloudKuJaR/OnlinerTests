using OpenQA.Selenium;

namespace Onliner.WebElementExtension
{
    interface IMyWebElement : IWebElement, ILocatable, IWrapsElement 
    {
        By Selector { get; }
    }
}
