using AutomationFrameworkE2E.Utilities;
using OpenQA.Selenium;

namespace AutomationFrameworkE2E.Pages
{
    public class InventoryPage(IWebDriver driver) : BasePage(driver)
    {
        private readonly By _cartButton = By.Id("shopping_cart_container");
        private readonly By _inventoryItems = By.XPath("//div[@class='inventory_list']//div[@class='inventory_item']");
        private readonly By _inventoryHeader = By.XPath("//div[@class='product_label']");
        private readonly By _addToCartButton = By.CssSelector(".btn_primary");

        private void AddProductsToCart(IEnumerable<string> productNames)
        {
            var items = Driver.FindElements(_inventoryItems);

            foreach (var nameToAdd in productNames)
            {
                foreach (var item in items)
                {
                    var name = item.FindElement(By.ClassName("inventory_item_name")).Text;

                    if (name.Equals(nameToAdd, StringComparison.OrdinalIgnoreCase))
                    {
                        item.FindElement(_addToCartButton).Click();
                        break;
                    }
                }
            }
        }

        private void OpenCart()
        {
            Driver.FindElement(_cartButton).Click();
        }

        public CartPageFirstStep AddProductToCartAndOpenCart(IEnumerable<string> productNames)
        {
            AddProductsToCart(productNames);
            OpenCart();
            return new CartPageFirstStep(Driver);
        }

        public string GetInventoryHeaderText()
        {
            return Driver.FindElement(_inventoryHeader).Text;
        }
    }
}
