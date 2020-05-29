Feature: Login: Login Functionality Feature
    In order to place the orders
    As a user of the website
    I want to log into the website

@web
Scenario Outline: Successful Login with Valid Credentials
	Given I open the "<site>" website's login page
	Then I Navigate to MyAccount Login Page
	When I log in using Username as "<UserName>" and Password "<Password>" on the login page
	Then I should be logged in
Examples: 
| Description   | site          | UserName                    | Password   |
| Online Portal | Monoprice Web | jayakumart@unitedtechno.com | Welcome@88 |


@web
Scenario Outline: UnSuccessful Login with InValid Credentials
	Given I open the "<site>" website's login page
	Then I Navigate to MyAccount Login Page
	When I log in using Username as "<UserName>" and Password "<Password>" on the login page
	Then I should not be logged in
Examples: 
| Description      | site          | UserName                  | Password |
| Invalid Username | Monoprice Web | jayakuma@unitedtechno.com | Welcome  |

@web
Scenario Outline: Place an Order
	Given I open the "<site>" website's login page
	Then I Navigate to MyAccount Login Page
	When I log in using Username as "<UserName>" and Password "<Password>" on the login page
	Then I Open any Product Page
Examples: 
| Description   | site          | UserName                    | Password   |
| Online Portal | Monoprice Web | jayakumart@unitedtechno.com | Welcome@88 |
