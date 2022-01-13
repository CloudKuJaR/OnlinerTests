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

        public static CartPage Cart
        {
            get { return GetPage<CartPage>(); }
        }

        public static CatalogPage Catalog
        {
            get { return GetPage<CatalogPage>(); }
        }

        public static LoginForm Login
        {
            get { return GetPage<LoginForm>(); }
        }

        public static Menu Menu
        {
            get { return GetPage<Menu>(); }
        }

        public static ProductPage ProductPage
        {
            get { return GetPage<ProductPage>(); }
        }

        public static TVPage TVPage
        {
            get { return GetPage<TVPage>(); }
        }

        public static OrderPage OrderPage
        {
            get { return GetPage<OrderPage>(); }
        }

        public static ComparePage ComparePage
        {
            get { return GetPage<ComparePage>(); }
        }
    }
}
