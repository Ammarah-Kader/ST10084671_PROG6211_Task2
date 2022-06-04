WELCOME TO BUDGET PLANNER
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

CONTENTS OF THIS README FILE:

* PROJECT NAME
* VERSION
* ABOUT
* PREREQUISITES
* RUNNING THE APPLICATION
* START UP INSTRUCTIONS
* BUILT WITH
* VERSIONING
* DESIGN FOCUS
* FUNCTIONAL REQUIREMENTS
* NON-FUNCTIONAL REQUIREMENTS
* BRIEF DESCRIPTION OF WHAT WAS CHANGED
* TROUBLESHOOTING
* FAQ
* AUTHOR
* LAST EDITED
* REFERENCES

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

PROJECT NAME:
-------------
ST10084671-BudgetPlanner2.1

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

VERSION:
--------
V2.01

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

ABOUT:
------
This application was created for personal budget planning. The application starts off by asking the user to enter a value for their gross monthly income. The application will then ask the user to enter values for basic expenses that they have to pay out monthly. The user will then be given an option of whether they will be purchasing an accommodation or if they will be buying. If they choose to purchase a property, their monthly home loan instalment amount will then be calculated. The application also alerts the user if the approval of the home loan is unlikely. The user will then be given the option for either buying a vehicle or not. If the user chooses to buy a vehicle, the application calculates the monthly car instalments. The application outputs all of the expenses in descending order according to price. The application will then calculate the amount of money that the user will have available after all the expenses have been subtracted. The application also alerts the user if their monthly expenses exceeds 75% of their monthly income. 

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

PREREQUISITES:
--------------
- Microsoft Visual Studio Community 2019 or Microsoft Visual Studio Community 2022.
- Any Web Browser (such as Google Chrome, Internet Explorer, Firefox, etc.).
- Internet connection is not required to run and execute the application.

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

RUNNING THE APPLICATION:
------------------------
- Download the zipped folder.
- Open up your file explorer.
- Right click on the zipped folder and click on Extract Here.
- Once the folder is unzipped, double click on the folder.
- You will then see a file that is named ST10084671-BudgetPlanner2.1.sln.
- Double click on that file and the program will open up in the Visual Studio that   you would have downloaded on your laptop prior.
- Once the application is opened up in Visual Studio, the next step would be to run   the application.

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

START UP INSTRUCTIONS:
----------------------
- To run the program, you need to click on the green play button (start) that is     located at the top of your screen. 
- Once the program is running, you will need to follow the instructions of the     program and provide the data that is necessary.

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

BUILT WITH:
-----------
- Visual Studio 2022
- C# Version 7.3
- Console App (.NET Framework) 

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

VERSIONING:
-----------
Version 2 of BudgetPlanner Console App

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

DESIGN FOCUS:
-------------
The Budget Planning application's goal is to provide users with a simple way for them to calculate their monthly expenses. The application is straight forward and easy to use which makes it accessible for people of all ages. The application also performs calculations for the users so that they do not have to manually do it themselves. Users are given an accurate reading as to where they are sitting financially.

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

FUNCTIONAL REQUIREMENTS:
------------------------
As mentioned in the instructions, the application's functional requirements are as follows:

This application must still perform all the functions from Part 1, with the following features added:

- The user shall be able to choose whether to buy a vehicle.
- If the user chooses to buy a vehicle, the user will be required to enter the       following values for vehicle financing.
- The values that are required to be entered are for model and make, purchase       price, total deposit, interest rate and estimated insurance premium.
- The software will then calculate the total monthly cost for buying a car       (insurance plus loan repayment), assuming that the car will be paid over a period   of five years.
- The software will notify the user when the total expenses exceed 75% of their       income (including loan repayments).
- A display message will output the expenses in descending order by value.

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

NON-FUNCTIONAL REQUIREMENTS:
----------------------------
As mentioned in the instructions, the application's non-functional requirements are as follows:

- The use of internationally acceptable coding standards.
- Having comprehensive comments explaining variable names, methods, and the logic     of programming code.
- Use of classes and inheritance.
- Must make use of a generic collection to store the expenses.
- Must make use of a delegate to notify the user when expenses exceed 75% of their    income.

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

BRIEF DESCRIPTION OF WHAT WAS CHANGED
-------------------------------------
In Part 1, the following comments were made:

- Input values – tax, exps, income – done and handled well. Allows full input
- Rental and home loan - allows input and does calcs. Retains info from other     classes.
- Warnings – Calcs and check done fairly well.
- Classes and inheritance – multiple classes with good use of code
- Arrays / lists - List T can be used instead. Done well
- Abstraction - used with a abstract methods- can be better
- Comments - done in places. No exception handling.
- Readme file – Added - fair format -missing info- Can add specs / author details/    faqs.
- Bonus - github / use of color/ used. Fair overall logic and application of code. - Design is nice with use of background colors/ threads. Code attribution not   added. Nice housekeeping. Add kanban boards 

From the lecturer's feedback, I have made quite a few changes to my code. The first change that I had made was to my array. In Part 1, I did not make use of an array list. Therefore, in part 2, I made sure to use an array list to store the expenses. 
In Part 1, I made use of abstract methods. In Part 2, I changed a few things around to try and better the code and make it more efficient by adding more classes and methods. In Part 1, I was lacking Exception handling. In Part 2, I made sure to use the appropiate exception handling to fix this problem. In Part 1, the readme file that I had done was very simple and was missing a lot of details. In Part 2, I made sure the incorporate all the necessary details and to make it complete. In Part 1, I did not use GitHub as an advanced feature. In Part 2, I had made sure to use GitHub and incorporate it into my POE. In Part 1, I did not use Kanban boards as an advanced feature. In Part 2, I had made sure to use Kanban boards and incorporate it into my POE.

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

TROUBLESHOOTING:
----------------
This application has been tested thoroughly for any errors or bugs during use. It is recommended that the system in which the user is running this application, has all of the software that is mentioned in the prerequisite along with the correct project files. If a problem still occurs, try rebooting the system and run the application once more. If a problem still occurs after doing so, drop me an email at ST10084671@vcconnect.edu.za and I will be able to assist you further.

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

FAQ:
----
Q: What general user features can I perform using the Budget Planning application?
A: 1. Calculate monthly home loan instalments.
   2. Calculate monthly car instalments.
   3. Outputs an alert message to alert the user if the home loan is unlikely to be    approved.
   4. Calculates the user’s total available money that is left after all the          expenses have been added.
   5. Outputs an alert message to alert the user when the total expense amount         exceeds 75% of their income.

Q: What is the currency of the values that are entered into the application?
A: South African Rand.

Q: Can I use the application multiple times during one sitting?
A: Yes, once a full calculation has been done, the application will allow for a       user to enter a value if they wish to continue and use the application again. 

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

AUTHOR:
-------
Ammarah Kader - ST10084671

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

LAST EDITED:
------------
04.06.2022

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------

REFERENCES:
-----------
•Andrew Troelsen, P. J., 2021. Pro C# 9 with .NET 5 Foundational Principles and Practices in Programming. 10th ed. New York: Apress Media.

•Anon., 2018. Basic Error Handling with Exceptions. [Online] 
Available at: https://www.informit.com/articles/article.aspx?p=2923212&seqNum=9
[Accessed 02 June 2022].

•Anon., 2021. C# | Delegates. [Online] 
Available at: https://www.geeksforgeeks.org/c-sharp-delegates/#:~:text=A%20delegate%20is%20an%20object,when%20an%20event%20is%20triggered.
[Accessed 30 May 2022].

•Anon., n.d. C# - ArrayList. [Online] 
Available at: https://www.tutorialsteacher.com/csharp/csharp-arraylist
[Accessed 28 May 2022].

•DOYLE, B., 2014. C# PROGRAMMING: FROM PROBLEM ANALYSIS TO PROGRAM DESIGN. 5th ed. Boston: Cengage Learning.

-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------


