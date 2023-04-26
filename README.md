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

the application will then further prompt the user to enter the amount of steps invovled, depending on the number the user enters it will loop for that amount of times, eg. user enter number at steps, the software will run twice asking user to enter step 1 and step 2.

thereafter the application which was built to my design will display the rfecipe details as follows: 
Ingredients:
chips - 3 kg

Instructions:
step 1: add
step 2: wash
step 3: hand

![recipe](https://user-images.githubusercontent.com/102582551/234523577-71f9b97e-2846-473b-9757-b99d1fc6343e.PNG)

thereafter the application will request the user fi they want their recipe halfed, double, or trippled, this was done by using the scalling function. for half we use 0.5, double is 2 and tripple would be 3. we also added 4 to reset the quantites, 5 to clear recipe details and finally 6 to exit the application. which ever number the user enters the application will run it. for some reason the 0.5 which is halfing the recipe details is not working to spec, however the function is corect and all the other scalling numbers works. 

in the following example this recipe was trippled and will display as follow:
![image](https://user-images.githubusercontent.com/102582551/234525234-a926804d-61df-4f9d-9ea7-b0cf67ee1b9d.png)

the clear option which is 4, when the user enters this number the application will clear the details and it would displays as follows: 

![image](https://user-images.githubusercontent.com/102582551/234534596-6445818d-921b-4171-8ad1-5240108df677.png)

this (-0) meaning that the recipe has been cleared successfully and is no longer in memory. the application will then prompt the user to enter in a new recipe.

finally the number 5 which is for resetting all quantyites will be displayed as follows when the user enters 5: 

![image](https://user-images.githubusercontent.com/102582551/234537418-754c78bd-1839-421e-a334-8ca7e32ad484.png)


lastly if the user enters 6, this will exit the application:

![image](https://user-images.githubusercontent.com/102582551/234540068-bb6b0af3-0ba6-401a-bbc8-e5d3bb71e177.png)
















