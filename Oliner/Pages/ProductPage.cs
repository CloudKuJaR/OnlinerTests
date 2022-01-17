﻿using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class ProductPage
    {
        public const string SELLERS_OFFERS = "//span[text()='Предложения продавцов']/..";
        public const string SELLER = "(//div[contains(@class,'helpers_hide_tablet')]//a[@class='button-style button-style_base-alter offers-list__button offers-list__button_cart button-style_expletive'])[3]";
        public const string CART = "//div[@class='product-recommended__control product-recommended__control_checkout']/a[2]";
        public const string COMPARISON_BUTTON = "//span[@class='catalog-masthead-controls__input i-checkbox i-checkbox_yellow']";
        public const string TV_CATALOG_BUTTON = "//span[text()='Телевизоры']";
        public const string CONFIRM_CITY_BUTTON = "//span[@class='button-style button-style_another button-style_base offers-form__button']";
        public const string NEW_SELLERS = "//a[@href='https://b2breg.onliner.by/reg']";

        public MyWebElement SellersOffers => new MyWebElement(By.XPath(SELLERS_OFFERS));
        public MyWebElement Seller => new MyWebElement(By.XPath(SELLER));
        public MyWebElement Cart => new MyWebElement(By.XPath(CART));
        public MyWebElement ComparisonButton => new MyWebElement(By.XPath(COMPARISON_BUTTON));
        public MyWebElement TvCatalogButton => new MyWebElement(By.XPath(TV_CATALOG_BUTTON));
        public MyWebElement ConfirmCityButton => new MyWebElement(By.XPath(CONFIRM_CITY_BUTTON));
        public MyWebElement NewSellers => new MyWebElement(By.XPath(NEW_SELLERS));

        public void ClickSellersOffersButton()
        {
            SellersOffers.Click();
        }

        public void ClickSellerButton()
        {
            Seller.Click();
        }

        public void ClickCartButton()
        {
            Cart.Click();
        }

        public void ClickComparisonButton()
        {
            ComparisonButton.Click();
        }

        public void ClickTvCatalogButton()
        {
            TvCatalogButton.Click();
        }

        public void SelectCity()
        {
            //Actions actions = new Actions(Driver.driver);
            //actions.MoveToElement(NewSellers);
            //actions.Perform();
            ConfirmCityButton.Click();
        }
    }
}
