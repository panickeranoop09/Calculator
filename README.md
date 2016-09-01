# Calculator
C# Console Application for Number Sequence calculator using LINQ and OOPS concepts.

-------INSTRUCTIONS-------

This application has a console application which has the user input screen. The Folder structure is as follows:
1. Calculator.Core - Contains two sub folders(Repository and Validation) - Repository will hold the business logic for the number sequence calculator and Validation will hold the validation messages for input screen.
2. Calculator.Main - Main console application which has the user input screen.
3. Calculator.Test - The unit test cases using VSTS(TDD approach). THere are 14 test cases and all the test cases are passed.

Note:- This application is build using .NET Framework 4.0, LINQ and OOPs concepts.

DOwnload the project and run the solution for executing the project.

The user input screen, which is the console application will show the list of operations. User has to select the operations for further processing. There are 5 operations and when the user is prompted to select the operation, please type or key in(1 or 2 or 3 or 4 or 5). Any other selection will throw "Invalid Input" message.

There are 5 operations as listed below:
1. Fibnonacci Series
2. Fizz Buzz Series
3. Odd Number Sequence
4. Even Number Sequence
5. Print Numbers

For Fibnonacci series - Screen will prompt to enter the length of the series - For example if the entered value is 10, it will return the series from the 1-10.

For Fizz Buzz Series - Screen will prompt to enter two input values: "Begin series from" and "End series at". For example you have begin series as: 1 and End series as: 10, then the output displayed will be from 1-10.

For Odd Number Sequence - Screen will prompt to enter the length of the series - For example if the entered value is 10, it will return the odd numbers from 1-10. If you enter 20, it will return the odd numbers from 1-20.

For Even Number Sequence - Screen will prompt to enter the length of the series - For example if the entered value is 10, it will return the even numbers from 1-10. If you enter 20, it will return the even numbers from 1-20.

For Print Numbers - Screen will prompt to enter the length of the series - For example if the entered value is 10, it will print the numbers from 1-10.

Note:- Validations are applied if the input is not correct.
Note:- 14 Unit Test cases are tested and passed.
