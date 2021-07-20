using System;
using SpecFlowNunit.Drivers;
using SpecFlowNunit.PageObjects;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowNunit.Steps
{
    
    [Binding]
    public class CheckSitePopUp
    {
        private readonly CheckSitePopUpPageObjects _checkSitePopUpPageObjects;

        public CheckSitePopUp(BrowserDriver browserDriver)
        {
            _checkSitePopUpPageObjects = new CheckSitePopUpPageObjects(browserDriver.Current);
        }

        [Given(@"that I go to the site")]
        public void GivenThatIGoToTheSite() => _checkSitePopUpPageObjects.GoToSite();

        [When(@"scroll down at the bottom of the page")]
        public void WhenScrollDownAtTheBottomOfThePage() => _checkSitePopUpPageObjects.ScrollToTheBottomOfThePage();

        [Then(@"the subscription pop-up appears")]
        public void ThenTheSubscriptionPop_UpAppears()
        {
            _checkSitePopUpPageObjects.IsTheSubscriptionButtonPresent.Should().BeTrue();
        }

        [Then(@"after (.*) seconds the pop-up should disppear")]
        public void ThenAfterSecondsThePop_UpShouldDisppear(int p0)
        {

            _checkSitePopUpPageObjects.IstheSubscriptionButtonPresentAfter10Seconds(p0).Should().BeTrue();
        }

    }
}
