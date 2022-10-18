Feature: product

A short summary of the feature

@tag1
Scenario: AddProductToCart
	Given user gives prodname as "Coffee"
	 Given User gives qty as 10
	When prodname not null or empty and qty >0
	Then successfully added