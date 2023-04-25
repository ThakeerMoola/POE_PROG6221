# PoePart1
--------------
Introductions
--------------
Fisrt and foremost i have programmed a simple c# command line application, which allows users to enter their specified amount of ingredients, units of measurements, quantities and the number of steps involved. this application saves users data in arrays, so when displayed it will output what the user has entered, screenshoots of this will be included below. 

------------------
software overview
------------------
this software built is straight forward and follows good coding standards as well as excellent indentation style, making it visible and neat for the user whos working on the code. the code itself has comments on it detailed whihch means the next coder/programmer can understand what was done on the code and does not need further assistance as to what is going on in this code. each method, loop, statements, if and else, all has comments on them. 


the following is based on how the application was built by me, following my own unique design structure. 

the class is called Recipe

firstly we have the method recipe(){}
this method only has a welcoming message to the user which will display as, "Welcome to Recipe World, your house to tasty foods!".

second method we have is IngredientDetails(){}
this method is where all the magic happens, this method has bulk of the code in, suchs as the prompts to the user, how manhy ingredients needed, the quantity, the units of measurement, the steps, scalling, clearing and resetting option for this application.

lastly we have our main class:
in this class we call all our methods in from our Recipe class. this is where the application will run, without the main class the application wont run!


-------------
Instructions
-------------
this application works as follows:

when user executes the code, thi first thing the application will ask/propmt the fuser is for output, it weill ask the user to enter the amount of ingredients, when the amount is entered, it will loop for that amount of times, so that the user can enter that amount of ingredients in, for eg. 4 is enterd in it will ask user to enter a ingredient in 4 times each. note that the readline outputs are sinteger sensitive, which menas the user can only enter in an integer, if a letter is enter the application will crash.

thereafter, the application will prompt the user to enter the quantity for each of the ingredient, eg. quantity is 2. note that the readline outputs are sinteger sensitive, which menas the user can only enter in an integer, if a letter is enter the application will crash.

the application will prompt the user to enter the units of measurement for each ingredient as well for eg. kgs, ml, litre. this will later be added to the quantity , eg. 2kg.




c

