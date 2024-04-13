using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10040092RecipeAppPROG6221
{
	internal class Recipe
	{

		private string[] ingredientStoredNames;
		private double[] StoredIngredientQuantities;
		private string[] StoredingredientUnits;
		private string[] recordedIngredientsSteps;
		private double[] originalIngredientQuantities;


		public void EnterRecipeDetails()
		{
			int NumberOFIngredientsCount;
			while (true)
			{
				Console.WriteLine("Enter number of ingredients");



				if (!int.TryParse(Console.ReadLine(), out NumberOFIngredientsCount))
				{

					Console.WriteLine("Invalid , error has occured  from input. Please enter a number for the number of ingredients.");


				}
				else if (NumberOFIngredientsCount <= 0)

				{

					Console.WriteLine("Invalid , error has occured  from input.The number of ingredients must be a positive integer.");

				}
				else
				{
					break; // Exit the loop if input is valid
				}
			}






















		}
	}
}
