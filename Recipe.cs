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
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("Enter number of ingredients");
				Console.ResetColor();

				if (!int.TryParse(Console.ReadLine(), out NumberOFIngredientsCount))
				{
					Console.ForegroundColor = ConsoleColor.Magenta;
					Console.WriteLine("Invalid input. Please enter a number for the number of ingredients.");
					Console.ResetColor();
				}
				else if (NumberOFIngredientsCount <= 0)
				{
					Console.ForegroundColor = ConsoleColor.Magenta;
					Console.WriteLine("Invalid input. The number of ingredients must be a positive integer.");
					Console.ResetColor();
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
						Console.ForegroundColor = ConsoleColor.Magenta;
						Console.WriteLine("Invalid input. Please enter a numeric value for quantity.");
						Console.ResetColor();
					}
					else if (measurementQauntity <= 0)
					{
						Console.ForegroundColor = ConsoleColor.Magenta;
						Console.WriteLine("Invalid input. Quantity must be a positive number.");
						Console.ResetColor();
					}
					else
					{
						StoredIngredientQuantities[D] = measurementQauntity;
						break; // Exit the loop if input is valid
					}
				}


			}
		}
	}
}
