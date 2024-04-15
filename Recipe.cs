using System;

namespace ST10040092RecipeAppPROG6221
{
	internal class Recipe
	{
		// Private fields to store recipe details
		private string[] ingredientStoredNames; // Array to store ingredient names
		private double[] StoredIngredientQuantities; // Array to store ingredient quantities
		private string[] StoredingredientUnits; // Array to store ingredient units
		private string[] recordedIngredientsSteps; // Array to store recipe steps
		private double[] originalIngredientQuantities; // Array to store original ingredient quantities (not currently used)

		// Method to input recipe details
		public void EnterRecipeDetails()
		{
			try
			{
				// Variable to store the number of ingredients
				int NumberOFIngredientsCount;

				// Input validation loop for the number of ingredients
				while (true)
				{
					Console.ForegroundColor = ConsoleColor.White; //setting the colour for the text to be white
					Console.WriteLine("Please enter number of ingredients");// asking user to enter their number of ingredients as a int value
					Console.ResetColor();// resets the texts color

					if (!int.TryParse(Console.ReadLine(), out NumberOFIngredientsCount))
					{
						Console.ForegroundColor = ConsoleColor.Magenta;//setting the colour for the text to be Magenta
						Console.WriteLine("Invalid input, an error has occured. Please enter a number for the number of ingredients."); // validation to makw the user enter a integer
						Console.ResetColor();// resets the texts color
					}
					else if (NumberOFIngredientsCount <= 0)
					{
						Console.ForegroundColor = ConsoleColor.Magenta;//setting the colour for the text to be Magenta
						Console.WriteLine("Invalid input,an error has occured. The number of ingredients must be a positive integer.");//asking the user to input a positive integer not justany integer 
						Console.ResetColor();// resets the texts color
					}
					else
					{
						break; // Exit the loop if input is valid
					}
				}

				// Initialize arrays based on the number of ingredients
				ingredientStoredNames = new string[NumberOFIngredientsCount];
				StoredIngredientQuantities = new double[NumberOFIngredientsCount];
				StoredingredientUnits = new string[NumberOFIngredientsCount];

				// Loop to input details for each ingredient
				for (int D = 0; D < NumberOFIngredientsCount; D++)
				{
					Console.WriteLine($"\n Please enter details for ingredient {D + 1}:");
					Console.Write("Name of Ingredient: ");
					ingredientStoredNames[D] = Console.ReadLine();

					// Input validation loop for ingredient quantity
					while (true)
					{
						Console.Write("Quantity of ingredients: ");
						if (!double.TryParse(Console.ReadLine(), out double measurementQauntity))
						{
							Console.ForegroundColor = ConsoleColor.Magenta;//setting the colour for the text to be Magenta
							Console.WriteLine("Invalid inputan error has occured. Please enter a numeric value for quantity.");//error message to make the user enter a number
							Console.ResetColor();// resets the texts color
						}
						else if (measurementQauntity <= 0)
						{
							Console.ForegroundColor = ConsoleColor.Magenta;//setting the colour for the text to be Magenta
							Console.WriteLine("Invalid inputan error has occured. Quantity must be a positive number.");
							Console.ResetColor();// resets the texts color
						}
						else
						{
							StoredIngredientQuantities[D] = measurementQauntity;
							break; // Exit the loop if input is valid
						}
					}

					Console.Write(" Please enter correct unit for that quantity: ");
					StoredingredientUnits[D] = Console.ReadLine();
				}

				// Variable to store the number of steps
				int numberOfStepsCount;

				// Input validation loop for the number of steps
				while (true)
				{
					Console.WriteLine("\n Please enter the number of steps:");

					if (!int.TryParse(Console.ReadLine(), out numberOfStepsCount))
					{
						Console.ForegroundColor = ConsoleColor.Magenta;//setting the colour for the text to be Magenta
						Console.WriteLine("Invalid input an error has occured. Please enter a number for the number of steps.");//error message to make the user enter a number
						Console.ResetColor();// resets the texts color
					}
					else if (numberOfStepsCount <= 0)
					{
						Console.ForegroundColor = ConsoleColor.Magenta;//setting the colour for the text to be Magenta
						Console.WriteLine("Invalid inputan error has occured. The number of steps must be a positive integer.");//error message to make the user enter a number that is a number
						Console.ResetColor();// resets the texts color
					}
					else
					{
						break; // Exiting the loop when the users input  is valid
					}
				}

				// We want to initialize the  array so it stores  the recipe steps
				recordedIngredientsSteps = new string[numberOfStepsCount];

				// Loop to input recipe steps
				for (int a = 0; a < numberOfStepsCount; a++)
				{
					Console.WriteLine($"\n Please Enter step {a + 1}:");
					recordedIngredientsSteps[a] = Console.ReadLine();
				}

				Console.ForegroundColor = ConsoleColor.Yellow;//setting the colour for the text to be yellow
				Console.WriteLine("Recipe details entered were successful!");
				Console.ResetColor();// resets the texts color
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red; // Set text color to red for error
				Console.WriteLine($"An error occurred: {ex.Message}");
				Console.ResetColor(); // Reset text color
			}
		}


		//method to diplay the recipe on the appliction , we call this method into the main
		public void DisplayRecipe()
		{
			try
			{
				Console.ForegroundColor = ConsoleColor.DarkYellow; // Set text color to darkyellow
				Console.WriteLine("\nRecipe Details:");
				Console.WriteLine("---------------");

				if (ingredientStoredNames == null || recordedIngredientsSteps == null)
				{
					Console.ForegroundColor = ConsoleColor.Magenta; // Set text color to Magenta
					Console.WriteLine("Recipe details are not entered yet.");
					Console.ResetColor(); // Reset text color
					return;
				}

				// Display ingredients
				Console.WriteLine("\nIngredients:");
				for (int c = 0; c < ingredientStoredNames.Length; c++)
				{
					Console.WriteLine($"{ingredientStoredNames[c]} - {StoredIngredientQuantities[c]} {StoredingredientUnits[c]}");
				}

				// Display steps
				Console.WriteLine("\n Steps:");
				for (int b = 0; b < recordedIngredientsSteps.Length; b++)
				{
					Console.WriteLine($"{b + 1}. {recordedIngredientsSteps[b]}");
				}

				Console.ResetColor(); // Reset text color
			}
			catch (Exception exChoice)
			{
				Console.ForegroundColor = ConsoleColor.Red; // Set text color to red for error
				Console.WriteLine($"An error occurred: {exChoice.Message}");
				Console.ResetColor(); // Reset text color
			}
		}




		// Scaling the quanity method and reseting the values to original values
		public void ScaleRecipe()
		{
			try
			{
				if (recordedIngredientsSteps == null || ingredientStoredNames == null)
				{
					Console.ForegroundColor = ConsoleColor.Magenta; // Set text color to Magenta
					Console.WriteLine("Recipe details are not entered yet.");
					Console.ResetColor(); // Reset text color
					return;
				}
				Console.ForegroundColor = ConsoleColor.Green; // Set text color to green
				Console.WriteLine("    Please enter the scaling factor (0.5, 2, or 3) to upscale the recipe, or 'reset' to revert to original values:");
				Console.ResetColor(); // Reset text color
				string input = Console.ReadLine();

				if (input.Equals("reset", StringComparison.OrdinalIgnoreCase))
				{
					if (originalIngredientQuantities == null)
					{
						Console.ForegroundColor = ConsoleColor.Magenta; // Set text color to pMagenta
						Console.WriteLine("Recipe has not been upscaled yet. Original values are already displayed.");
						Console.ResetColor(); // Reset text color
						return;
					}

					// Reset recipe to original values
					StoredIngredientQuantities = originalIngredientQuantities.ToArray();

					Console.ForegroundColor = ConsoleColor.Green; // Set text color to green
					Console.WriteLine("\nRecipe reset to original values:"); // message outputted when they reseting the new values back to the original ones
					Console.ResetColor(); // Reset text color
					DisplayRecipe();
					return;
				}

				if (!double.TryParse(input, out double scaleFactor) || (scaleFactor != 0.5 && scaleFactor != 2 && scaleFactor != 3))
				{
					Console.ForegroundColor = ConsoleColor.Magenta; // Set text color to Magenta
					Console.WriteLine("Invalid input an error occured. Please enter 0.5, 2, 3, or 'reset'.");
					Console.ResetColor(); // Reset text color
					return;
				}

				// Store original ingredient quantities if not already stored
				if (originalIngredientQuantities == null)
				{
					originalIngredientQuantities = StoredIngredientQuantities.ToArray();
				}
				
				for (int a = 0; a < StoredIngredientQuantities.Length; a++) // loop through each all elements within the storedIngredients
				{
					
					StoredIngredientQuantities[a] *= scaleFactor; // multiply each of the users elements by the scalfactor choosen
				}

				Console.WriteLine($"\nScaled Recipe (Factor: {scaleFactor}):");
				DisplayRecipe(); // call method to display the users recipe

				Console.ForegroundColor = ConsoleColor.Cyan; // Set text color to cyan
				Console.WriteLine("Quantity scaled successfully!"); //outputs when the user has chosen their output and the application scales it up
				Console.ResetColor(); // Reset text colors
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red; // Set text color to red for error
				Console.WriteLine($"An error occurred: {ex.Message}");
				Console.ResetColor(); // Reset text color
			}
		}
		//clearing the recipe for the stored recipe in the application 
		//made use of a try ,catch, if else and else if 
		//
		public void ClearRecipe()
		{
			try
			{
				Console.ForegroundColor = ConsoleColor.DarkRed; // Set text color to darkRed
				Console.WriteLine("Are you sure you want to clear the recipe? (yes/no)");
				Console.ResetColor(); // Reset text color

				string confirmed = Console.ReadLine();

				if (confirmed.Equals("yes", StringComparison.OrdinalIgnoreCase))
				{
					ingredientStoredNames = null;
					StoredIngredientQuantities = null;
					StoredingredientUnits = null;
					recordedIngredientsSteps = null;

					Console.ForegroundColor = ConsoleColor.Blue; // Set text color to blue
					Console.WriteLine("Recipe cleared. You can now enter a new recipe.");
					Console.ResetColor(); // Reset text color
				}
				else if (confirmed.Equals("no", StringComparison.OrdinalIgnoreCase))
				{
					Console.ForegroundColor = ConsoleColor.Blue; // Set text color to blue
					Console.WriteLine("Clearing recipe canceled. Recipe data remains unchanged.");// a message to show that there is no change in the recipe when they choose no
					Console.ResetColor(); // Reset text color
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Magenta; // Set text color to Magenta
					Console.WriteLine("Invalid input, an error occured. Please enter 'yes' or 'no'."); //error message to make the user choose one of the following given options , either yes or no
					Console.ResetColor(); // Reset text color
				}
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red; // Set text color to red for error
				Console.WriteLine($"An error occurred: {ex.Message}");
				Console.ResetColor(); // Reset text color
			}
		}
	}
}

