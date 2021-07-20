using System;
using SpecFlowNunit.Drivers;
using SpecFlowNunit.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowNunit.Hooks
{
    [Binding]
    public class CheckPopUpSiteHook
    {
        [BeforeScenario("CheckSitePopUp")]
        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var checkPopUpSiteObject = new CheckSitePopUpPageObjects(browserDriver.Current);
            checkPopUpSiteObject.GoToSite();
        }
    }
}
