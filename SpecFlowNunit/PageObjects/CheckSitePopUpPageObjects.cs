using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SpecFlowNunit.PageObjects
{
    public class CheckSitePopUpPageObjects
    {
        //url of the site
        private const string SiteUrl = "https://www.afr.com/policy/foreign-affairs/capability-edge-and-keeping-south-china-sea-open-crucial--christopher-pyne-20180924-h15rq9";

        //The Selenium web driver to automate the browser
        private readonly IWebDriver _webDriver;

        //The default wait time in seconds for wait.Until
        public const int DefaultWaitInSeconds = 5;

        public CheckSitePopUpPageObjects(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        //elements to find
        private IWebElement SubscriptionButton => _webDriver.FindElement(By.XPath("//a[@data-testid='SubscriptionPrompt-callToAction']"));
        private IWebElement PageFooter => _webDriver.FindElement(By.Id("footer"));
        //private IWebElement FooterCaption => _webDriver.FindElement(By.XPath("//p[contains(text(),'The Daily Habit of Successful People')]"));

        public void GoToSite()
        {
           
            if(_webDriver.Url != SiteUrl)
            {
                _webDriver.Url = SiteUrl;
                _webDriver.Manage().Window.Maximize();
            }
        }

        public void ScrollDownToElement(IWebElement webElement) 
        {
            
            Actions actions = new Actions(_webDriver);
            actions.MoveToElement(webElement);
            actions.Perform();
        }

        public void ScrollToTheBottomOfThePage()
        {
            ScrollDownToElement(PageFooter);

        }

        public bool IsTheSubscriptionButtonPresent => _ = SubscriptionButton.Displayed;


        public bool IstheSubscriptionButtonPresentAfter10Seconds(int seconds)
        {
            var xpath = "//div[@data-testid='SubscriptionPrompt-false']";
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(seconds));
            IWebElement SubscriptionButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpath)));

            return SubscriptionButton.Displayed;
        }
    }
}
