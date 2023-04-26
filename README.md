# PoePart1
[image](https://user-images.githubusercontent.com/102582551/234572085-9747f9d1-8604-492f-85e3-9a1ea0151e86.png)

--------------
Introductions
--------------
First and foremost, I have programmed a simple C# command-line application that allows users to enter their specified amount of ingredients, units of measurement, quantities, and the number of steps involved. This application saves users data in arrays, so when displayed, it will output what the user has entered. Screenshots of this will be included below.

------------------
Software overview
------------------
This software is straight-forward and follows good coding standards as well as excellent indentation style, making it visible and neat for the user who's working on the code. The code itself has comments on it that are detailed, which means the next coder or programmer can understand what was done on the code and does not need further assistance as to what is going on in this code. Each method, loop, statement, if, and else, has comments on it.

This is a C# console application that allows the user to input ingredients and steps involved in a recipe, and then scales the recipe based on the user's input. The program begins with a welcome message and prompts the user to input the number of ingredients and steps involved in the recipe. The user then inputs the details for each ingredient and step. The program then displays the list of ingredients and steps for the user to review. The program prompts the user to input a scaling factor for the recipe. If the user enters "4," the program clears the recipe; if "5," the program resets the quantities; and if "6," the program exits. Otherwise, the program scales the recipe based on the user's input and displays the scaled recipe.


The following is based on how the application was built by me, following my own unique design structure.

![image](https://user-images.githubusercontent.com/102582551/234549014-8a481f76-c9d4-4a73-9369-ba09c6238126.png)




The class is called Recipe.

First, we have the method recipe().
This method only displays a welcoming message to the user, which will display as, "Welcome to Recipe World, your house to tasty foods!".

The second method we have is IngredientDetails().
This method is where all the magic happens. This method has the bulk of the code in, such as the prompts to the user, how many ingredients are needed, the quantity, the units of measurement, the steps, and the calling, clearing, and resetting options for this application.

Last but not least, we have our main class:
In this class, we call all our methods from our Recipe class. This is where the application will run; without the main class, the application won't run!


-------------
Instructions
-------------
This application works as follows:

When the user executes the code, the first thing the application will ask or prompt the fuser is for output. It will ask the user to enter the amount of ingredients. When the amount is entered, it will loop for that amount of times so that the user can enter that amount of ingredients. For example, if 4 is entered, it will ask the user to enter an ingredient four times. Note that the readline outputs are integer-sensitive, which means the user can only enter an integer; if a letter is entered, the application will crash.

Afterward, the application will prompt the user to enter the quantity for each of the ingredients, e.g., quantity is 2. Note that the readline outputs are integer-sensitive, which means the user can only enter an integer; if a letter is entered, the application will crash.

The application will prompt the user to enter the units of measurement for each ingredient as well, e.g., kg, ml, and liter. This will later be added to the quantity, e.g., 2kg.

The application will then further prompt the user to enter the number of steps involved; depending on the number the user enters, it will loop for that number of times; e.g., if the user enters the number of steps, the software will run twice, asking the user to enter steps 1 and 2.

Afterward, the application, which was built to my design, will display the recipe details as follows:
Ingredients:
chips, 3 kg

Instructions:
Step 1: Add
Step 2: Wash
Step 3: Hand
![recipe](https://user-images.githubusercontent.com/102582551/234523577-71f9b97e-2846-473b-9757-b99d1fc6343e.PNG)

Afterwards, the application will ask the user if they want their recipe halfed, doubled, or trippled; this was done by using the scaling function. For half, we use 0.5, double is 2, and tripple would be 3. We also added 4 to reset the quantities, 5 to clear recipe details, and finally 6 to exit the application. Whichever number the user enters, the application will run. For some reason, the 0.5, which is halfing the recipe details, is not working to specification; however, the function is correct and all the other scaling numbers work.

in the following example this recipe was trippled and will display as follow:
![image](https://user-images.githubusercontent.com/102582551/234525234-a926804d-61df-4f9d-9ea7-b0cf67ee1b9d.png)


the clear option, which is 4, when the user enters this number, the application will clear the details, and it would display as follows:
![image](https://user-images.githubusercontent.com/102582551/234534596-6445818d-921b-4171-8ad1-5240108df677.png)

this (-0), meaning that the recipe has been cleared successfully and is no longer in memory. The application will then prompt the user to enter a new recipe.

Finally, the number 5, which is for resetting all quantities, will be displayed as follows when the user enters 5:

![image](https://user-images.githubusercontent.com/102582551/234537418-754c78bd-1839-421e-a334-8ca7e32ad484.png)


Last but not least, if the user enters 6, this will exit the application:

![image](https://user-images.githubusercontent.com/102582551/234540068-bb6b0af3-0ba6-401a-bbc8-e5d3bb71e177.png)

--------------
Conclusion:
--------------
Overall, the program is a useful tool for creating and scaling recipes and could be expanded upon to include additional functionality, such as allowing the user to edit existing recipes, add unlimmited recipes, and add different food groups and calories, which will all be added in at a later stage.

















