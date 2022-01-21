using SeleniumExtras.PageObjects;

namespace Onliner.Pages
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Driver.driver, page);
            return page;
        }

        public static CartPage CartPage => GetPage<CartPage>();

        public static CatalogPage CatalogPage => GetPage<CatalogPage>();

        public static LoginForm LoginPage => GetPage<LoginForm>();

        public static Menu Menu => GetPage<Menu>();

        public static ProductPage ProductPage => GetPage<ProductPage>();

        public static OrderPage OrderPage => GetPage<OrderPage>();

        public static ComparePage ComparePage => GetPage<ComparePage>();

        public static LaptopsPage LaptopsPage => GetPage<LaptopsPage>();

        public static ProductsCatalogPage ProductsCatalogPage => GetPage<ProductsCatalogPage>();

        public static RegistrationPage RegistrationPage => GetPage<RegistrationPage>();

        public static HomePage HomePage => GetPage<HomePage>();

        public static ArcticlePage ArcticlePage => GetPage<ArcticlePage>();

        public static UserSupportPage UserSupportPage => GetPage<UserSupportPage>();

        public static CurrencyConversionPage CurrencyConversionPage => GetPage<CurrencyConversionPage>();

        public static HousesAndFlatsPage HousesAndFlatsPage => GetPage<HousesAndFlatsPage>();
    }
}
