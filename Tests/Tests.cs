using AutomationFrameworkE2E.Pages;
using AutomationFrameworkE2E.Utilities.Base;

namespace AutomationFrameworkE2E.Tests
{
    public class Tests : TestBase
    {
        [Test]
        public void E2ETest()
        {            
            var loginPage = new LoginPage(Driver);
            var inventoryPage = loginPage.Login("standard_user", "secret_sauce");
            var products = new List<string> { "Sauce Labs Backpack", "Sauce Labs Bike Light" };
            var cartPage = inventoryPage.AddProductToCartAndOpenCart(products);
            var cartSecondStep = cartPage.ClickCheckOutButton();
            cartSecondStep.FillFormAndContinue("Kalin", "Malin", "1000");
            var lastStep = new CartPageLastStep(Driver);
            var thankYouPage = lastStep.FinishOrder();
            thankYouPage.CompareThankYouText();
        }
    }
}