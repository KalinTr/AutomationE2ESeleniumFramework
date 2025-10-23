using AutomationFrameworkE2E.Utilities.Base;
using OpenQA.Selenium;

namespace AutomationFrameworkE2E.Pages
{
    public class InventoryPage(IWebDriver driver) : BasePage(driver)
    {
        private readonly By cartButton = By.Id("shopping_cart_container");
        private readonly By inventoryItems = By.XPath("//div[@class='inventory_list']//div[@class='inventory_item']");
        private readonly By inventoryHeader = By.XPath("//div[@class='product_label']");
        private readonly By addToCartButton = By.CssSelector(".btn_primary");

        private void AddProductsToCart(IEnumerable<string> productNames)
        {
            var items = Driver.FindElements(inventoryItems);

            foreach (var nameToAdd in productNames)
            {
                foreach (var item in items)
                {
                    var name = item.FindElement(By.ClassName("inventory_item_name")).Text;

                    if (name.Equals(nameToAdd, StringComparison.OrdinalIgnoreCase))
                    {
                        item.FindElement(addToCartButton).Click();
                        break;
                    }
                }
            }
        }

        private void OpenCart()
        {
            Driver.FindElement(cartButton).Click();
        }

        public CartPageFirstStep AddProductToCartAndOpenCart(IEnumerable<string> productNames)
        {
            AddProductsToCart(productNames);
            OpenCart();
            return new CartPageFirstStep(Driver);
        }

        public string GetInventoryHeaderText()
        {
            return Driver.FindElement(inventoryHeader).Text;
        }
    }
}
