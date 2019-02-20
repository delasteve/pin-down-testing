# Financial Calculator

An example application for learning how to write a pin down test.

## Scenario

In a recent audit, our auditors found an error in one of the reports generated. When they calculated the billions of transactions total by hand, the number was wildly different from the one in the report. This report has been stable in the past. It seems there has been some recent code changes that have effected the total.

## Goal

Write a pin down test that characterizes the current behavior. Ensure a green test. Then write a test that fails for how the application should work. Ensure this test is red while the first test is still green. Change the production code to make the red test green and the green test red. Then delete the original pin down test.