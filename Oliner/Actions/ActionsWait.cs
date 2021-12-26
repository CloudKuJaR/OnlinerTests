namespace Onliner.Actions
{
    public static class ActionsWait
    {
        public static Waits waits = new Waits();
        public static void WaitMethod(string locator)
        {
            waits.WaitMethod(locator);
        }

        public static void WaitForProduct(string productName)
        {
            waits.WaitForProduct(productName);
        }



    }
}
