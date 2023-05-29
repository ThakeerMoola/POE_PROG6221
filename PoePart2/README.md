   ![image](https://user-images.githubusercontent.com/102582551/234572619-b6a24bc3-16bc-4fb6-ab84-b2d86f0719b5.png)
------------
INTRODUCTION
------------
First and foremost, I have programmed a simple C# command-line application that allows users to enter their specified amount of ingredients, units of measurement, quantities, and the number of steps involved. This application saves users data in Array List(T), so when displayed, the foolowing hass been updated on the program;

-------------
INSTRUCTIONS
-------------
First of all, we will start by creating a new C# project in your preferred Integrated Development Environment (IDE) for C# development (e.g., Visual Studio and Netbeans) etc, and go ahead and create a new C# project.

Pay careful attention to the names of the classes when naming it;

Add the following classes Inside your project, create three new classes named Program.cs (which is the main class, this class is going to run the entire program from start to finish), Recipe.cs (this has most of the code inside the class, and is linked to the main class), Calories.cs (this class is used to calculate the total calories for each ingredient), and UnitTest1.cs (This class contain the Unit Testing for the Calories). Copy all the provided code for each class into their respective files.

Build the project: Build the project to ensure that there are no compilation errors. This step generates the executable file for your program.

Run the program: Once the project is successfully built and error free, you can run the program by executing the compiled executable program and clicking run.

Note: The entry point of the program is in the Program.cs file, which contains the Main method. This method is responsible for starting the program and displaying the menu for recipe options.

That's it! Now you should be able to compile and run the software successfully. Follow the menu prompts to add recipes, display all recipes, clear recipes, or exit the program. Enjoy using Recipe World!

------
ESSAY
------
The user now has the option to add unlimited recipes to the application; each recipe must include a name. This was another feature that was added in Part 2. The storing method that was used in Part 1, which was arrays, has now been changed to generic collections, making use of the Array List (t), which is a better way for storing data. 

Users also have the option to view all recipes in alphabetical order by selecting the correct option and picking their favourite recipe. 
We also added colour to the program text, making it more eye-catching and visually appealing to the user. The user has the option to clear all recipe data as well, and this will erase the entire data that was stored.

The last option is that the user can exit the application as well. Last but not least, for each ingredient added, the application will prompt the user to enter the number of calories for the specific ingredient as well as the food group for the ingredient.

The calories are being calculated using the Delegate method; for each value entered into the calorie method, a message is shown to the user. The calorie method gives the total amount of calories as well as the specific recipe that the ingredient is being used in. This information can be helpful for individuals who are tracking their calorie intake or following a specific diet plan. The application has exception handling as well incase an inccorect value is entered, the application wont crash, it will re-run.

Additionally, the app allows users to save their favourite recipes and ingredients for easy access in the future.

-----------------------
SCREENSHOTS AND CHANGES
-----------------------
![image](https://github.com/ThakeerMoola/POE_PROG6221/assets/102582551/5b0fc8a2-e5aa-4ba5-9551-1fdc34cc67dc)

![image](https://github.com/ThakeerMoola/POE_PROG6221/assets/102582551/f78a1b56-45e5-4097-a2c9-202164914ba3)

The above is the Array List<T> which was chaged from arrays. this is used to save user data. I also made use of generic collections which is can be seen above as well.
   
![image](https://github.com/ThakeerMoola/POE_PROG6221/assets/102582551/b9b3ec4a-9bd0-4518-a064-b9c1e87ecfea)
User cal add the name of each recipe which was implemented in this part.

![image](https://github.com/ThakeerMoola/POE_PROG6221/assets/102582551/67f037e2-b286-4550-be62-09cebb0d8a7c)
Users are able to enter and add recipes. after each recipe is entered the program will run again to prompt user if they want to add another recipe, display or exit the application.
   
![image](https://github.com/ThakeerMoola/POE_PROG6221/assets/102582551/cdfb66ca-d4d2-4873-befa-310df2c3abc2)
![image](https://github.com/ThakeerMoola/POE_PROG6221/assets/102582551/7da34b7d-c1b0-4677-9e01-ec761019ac3d)
![image](https://github.com/ThakeerMoola/POE_PROG6221/assets/102582551/ca6d106a-53eb-470d-8020-118918eb1c2b)

In the above screenshot a User is entering values that are inccorect and the application is making use of exception handling, meaning the application wont crash.
   
![image](https://github.com/ThakeerMoola/POE_PROG6221/assets/102582551/e9500368-a56a-4bc7-9834-466b4c588c8e)
Recipes are being displayed in aphabetical order for the user.
   
   
![image](https://github.com/ThakeerMoola/POE_PROG6221/assets/102582551/9810e5db-198d-453b-b010-544ec6cc7075)
as one can see the recipe is being displayed and the calorie counter has been totaled correctly. For testing purposes one can see that this is a high calorie intake, hence the red text.
   











