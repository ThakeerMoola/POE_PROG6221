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
The user now has the option to add unlimited recipes to the application; each recipe must include a name. This was another feature that was added in Part 2. The storing method that was used in Part 1, which was arrays, has not been changed to generic collections, making use of the Array List (t), which is a better way for storing data. Users also have the option to view all recipes in alphabetical order by selecting the correct option and picking their favourite recipe. 
We also added colour to the program text, making it more eye-catching and visually appealing to the user. The user has the option to clear all recipe data as well, and this will erase the entire data that was stored.
The last option is that the user can exit the application as well. Last but not least, for each ingredient added, the application will prompt the user to enter the number of calories for the specific ingredient as well as the food group for the ingredient. The calories are being calculated using the Delegate method; for each value entered into the calorie method, a message is shown to the user. The calorie method gives the total amount of calories as well as the specific recipe that the ingredient is being used in. This information can be helpful for individuals who are tracking their calorie intake or following a specific diet plan. Additionally, the app allows users to save their favourite recipes and ingredients for easy access in the future. 

