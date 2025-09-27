using AutomationFrameworkE2E.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkE2E.Pages
{
    public class InventoryPage : BasePage
    {
        public InventoryPage(IWebDriver driver) : base(driver) { }

        private readonly By _cartButton = By.Id("shopping_cart_container");
        private readonly By _inventoryItems = By.XPath("//div[@class='inventory_list']//div[@class='inventory_item']");
        private readonly By _inventoryHeader = By.XPath("//div[@class='product_label']");
        private readonly By _addToCartButton = By.CssSelector(".btn_primary");

        public void AddProductsToCart(IEnumerable<string> productNames)
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
                        break; // спира този вътрешен цикъл и продължава с следващото име
                    }
                }
            }
        }
        public void OpenCart()
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
