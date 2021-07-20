Feature: Check Site Pop Up
	As a user
	I want to verify that the subscription pop-up appears and disappears


Scenario: Subscription Pop-up Appears
	Given that I go to the site
	When scroll down at the bottom of the page
	Then the subscription pop-up appears

Scenario: Subscription Pop-up Disappears after 10 seconds
	Given that I go to the site
	When scroll down at the bottom of the page
	Then after 10 seconds the pop-up should disppear