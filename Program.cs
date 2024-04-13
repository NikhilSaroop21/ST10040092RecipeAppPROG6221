namespace ST10040092RecipeAppPROG6221
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Recipe recipe = new Recipe();

			while (true)
			{
				Console.WriteLine("\nChoose an option:");
				Console.WriteLine("1. Enter Recipe Details");
				Console.WriteLine("2. Display Recipe");
				Console.WriteLine("3. Scale Recipe / Reset to Original");
				Console.WriteLine("4. Clear Recipe");
				Console.WriteLine("5. Exit");

				int choice;
				if (!int.TryParse(Console.ReadLine(), out choice))
				{
					Console.WriteLine("Invalid input. Please enter a number.");
					continue;
				}

				switch (choice)
				{
					case 1:
						// Set text color to green
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("\nEnter Recipe Details:");
						Console.ResetColor();

						// Call the method to enter recipe details
						recipe.EnterRecipeDetails();
						break;

				
					case 2:
					
						break;
					case 3:
				
						break;
					case 4:
					
						break;
					case 5:
						Console.WriteLine("Exiting the Recipe App.");
						return;
					default:
						Console.WriteLine("Invalid choice. Please try again.");
						break;
				}
			}
		}
	}
}
