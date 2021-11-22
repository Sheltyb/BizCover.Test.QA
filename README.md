# Bizcover QA Practical Test
Selenium Test for new QA Applicants

This solution contains a test framework which is built from Specflow, Nunit3, and Selenium WebDriver.

The framework utilises:
1. Gherkin language for the test/feature files
2. Page-Object-Model - Each Page of the website has it's own class
3. Uses the open-for-testing website: http://automationpractice.com

The solution has one test/feature file which basically tests the log in flow for a valid user.

# Prerequisites - Getting your machine ready
You would need to install Visual Studio (Community Edition) if you don�t have it already and open the .sln file. 
After that, install the NUnit3 Test Adapter and Specflow for Visual Studio 20xx extensions via (Tools->) Extensions And Updates.

# Test Brief for the Candidate

Problem: QA Candidate is required to write a test to register a new user. Registration of a new user can be found in http://automationpractice.com/index.php?controller=authentication&back=my-account.
         Any email address can be used for registration as there is no email validation in place.

Expectations:
1. New user should be registered. Would be great if the email address is randomly generated so as for the test to be reuseable.
2. The user should be able to log in to the system after a successful registration.
3. Please upload your solution to your github account and provide us the link. It is also desirable if you can attach a Test Report which shows the test result.

# Troubleshooting

## Tests wont run but they will compile

It could be that SpecFlow isnt activated. Check the logs in .\TestResults\....log

```
Info;Checking activation
Error;****************************************************************************************************************
Error;*                                           SpecFlow+ Runner                                                   *
Error;****************************************************************************************************************
Error;Please sign-up for your free SpecFlow account or sign-in with your already existing account here:
Error;https://account.specflow.org/clientactivation/welcome/Runner/FB5491DCF1A9488096AA2A15E01DD1330162D13278973C3880B5DE9EA256872F55CC7DD0/NotActivatedYet
Error;to execute your Scenarios again.
Error;If you are reading this message on a build agent, we couldn't recognize the agent.
Error;Please get in touch with us at support@specflow.org.
Error;****************************************************************************************************************
Error;No tests executed (activation needed)
```

### To fix this

1. Click on the link in the log file
2. Sign in with any microsoft account and once its done you will get a success message on the SpecFlow site
3. No need to re-open Visual Studio, it will just run the test now. 
