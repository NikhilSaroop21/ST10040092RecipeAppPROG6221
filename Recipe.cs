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
			// Variable to store the number of ingredients
			int NumberOFIngredientsCount;

			// Input validation loop for the number of ingredients
			while (true)
			{
				Console.ForegroundColor = ConsoleColor.White; //setting the colour for the text to be white
				Console.WriteLine("Please enter number of ingredients");
				Console.ResetColor();// resets the texts color

				if (!int.TryParse(Console.ReadLine(), out NumberOFIngredientsCount))
				{
					Console.ForegroundColor = ConsoleColor.Magenta;//setting the colour for the text to be Magenta
					Console.WriteLine("Invalid input, an error has occured. Please enter a number for the number of ingredients.");
					Console.ResetColor();// resets the texts color
				}
				else if (NumberOFIngredientsCount <= 0)
				{
					Console.ForegroundColor = ConsoleColor.Magenta;//setting the colour for the text to be Magenta
					Console.WriteLine("Invalid input,an error has occured. The number of ingredients must be a positive integer.");
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
						Console.WriteLine("Invalid inputan error has occured. Please enter a numeric value for quantity.");
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
					Console.WriteLine("Invalid input an error has occured. Please enter a number for the number of steps.");
					Console.ResetColor();// resets the texts color
				}
				else if (numberOfStepsCount <= 0)
				{
					Console.ForegroundColor = ConsoleColor.Magenta;//setting the colour for the text to be Magenta
					Console.WriteLine("Invalid inputan error has occured. The number of steps must be a positive integer.");
					Console.ResetColor();// resets the texts color
				}
				else
				{
					break; // Exit the loop if input is valid
				}
			}

			// Initialize array to store recipe steps
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

		public void DisplayRecipe()
		{
			
			Console.WriteLine("\nRecipe Details:");
			Console.WriteLine("---------------");

			if (ingredientStoredNames == null || recordedIngredientsSteps == null)
			{
				
				Console.WriteLine("Recipe details are not entered yet.");
			
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

		
		}

	}
}
