using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class RecipeUI
    {
        public RecipeUI(RecipeManager recipeManager)
        {
            RecipeManager = recipeManager;
        }

        public RecipeManager RecipeManager { get; }

        public static void ShowMainMenu(List<Recipe> recipes)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("🍽 Recipe Management System 🍽");
                Console.WriteLine("1. View All Recipes");
                Console.WriteLine("2. Search Recipes");
                Console.WriteLine("3. Filter Recipes by Category");
                Console.WriteLine("4. Sort Recipes");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        DisplayAllRecipes(recipes);
                        break;
                    case "2":
                        SearchRecipes(recipes);
                        break;
                    case "3":
                        FilterRecipesByCategory(recipes);
                        break;
                    case "4":
                        SortRecipes(recipes);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Press any key to try again...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void DisplayAllRecipes(List<Recipe> recipes)
        {
            Console.Clear();
            Console.WriteLine("🍽 Recipe List:");
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipes[i].Name} ({recipes[i].Category.GetCategoryName()})");
            }

            Console.Write("\nEnter the number of a recipe to view details, or press Enter to return: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int index) && index > 0 && index <= recipes.Count)
            {
                DisplayRecipe(recipes[index - 1]);
            }
        }

        public static void DisplayRecipe(Recipe recipe)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine($"📌 Recipe: {recipe.Name}");
            Console.WriteLine($"📂 Category: {recipe.Category.GetCategoryName()}");
            Console.WriteLine("🥕 Ingredients:");
            foreach (var ingredient in recipe.Ingredients)
            {
                Console.WriteLine($"   - {ingredient.GetFormattedIngredient()}");
            }
            Console.WriteLine("\n📜 Instructions:");
            Console.WriteLine($"{recipe.Instructions}");

            Console.WriteLine("\n⭐ Ratings:");
            if (recipe.Ratings.Count > 0)
            {
                foreach (var rating in recipe.Ratings)
                {
                    Console.WriteLine($"   - {rating.GetRatingDetails()}");
                }
                Console.WriteLine($"🔢 Average Rating: {recipe.GetAverageRating():0.0}/5");
            }
            else
            {
                Console.WriteLine("   No ratings yet.");
            }

            Console.WriteLine("\n🍿 Tags:");
            Console.WriteLine(recipe.Tags.Count > 0 ? string.Join(", ", recipe.Tags.Select(tag => tag.GetTagName())) : "   No tags.");

            Console.WriteLine("\n💬 Comments:");
            if (recipe.Comments.Count > 0)
            {
                foreach (var comment in recipe.Comments)
                {
                    Console.WriteLine($"   - {comment.GetCommentDetails()}");
                }
            }
            else
            {
                Console.WriteLine("   No comments yet.");
            }

            Console.WriteLine("========================================\n");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }

        public static void SearchRecipes(List<Recipe> recipes)
        {
            Console.Clear();
            Console.Write("🔍 Enter search term: ");
            string query = Console.ReadLine().ToLower();

            var results = recipes.Where(r => r.Name.ToLower().Contains(query) || r.Tags.Any(t => t.GetTagName().ToLower().Contains(query))).ToList();

            if (results.Count == 0)
            {
                Console.WriteLine("No recipes found.");
            }
            else
            {
                DisplayAllRecipes(results);
            }
        }

        public static void FilterRecipesByCategory(List<Recipe> recipes)
        {
            Console.Clear();
            var categories = recipes.Select(r => r.Category.GetCategoryName()).Distinct().ToList();

            Console.WriteLine("📂 Available Categories:");
            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {categories[i]}");
            }

            Console.Write("\nSelect a category by number: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= categories.Count)
            {
                string selectedCategory = categories[index - 1];
                var filteredRecipes = recipes.Where(r => r.Category.GetCategoryName() == selectedCategory).ToList();
                DisplayAllRecipes(filteredRecipes);
            }
            else
            {
                Console.WriteLine("Invalid selection. Press any key to return...");
                Console.ReadKey();
            }
        }

        public static void SortRecipes(List<Recipe> recipes)
        {
            Console.Clear();
            Console.WriteLine("📊 Sort Recipes By:");
            Console.WriteLine("1. Name (A-Z)");
            Console.WriteLine("2. Name (Z-A)");
            Console.WriteLine("3. Highest Rated");
            Console.WriteLine("4. Lowest Rated");

            Console.Write("\nSelect an option: ");
            string choice = Console.ReadLine();

            List<Recipe> sortedRecipes = recipes;
            switch (choice)
            {
                case "1":
                    sortedRecipes = recipes.OrderBy(r => r.Name).ToList();
                    break;
                case "2":
                    sortedRecipes = recipes.OrderByDescending(r => r.Name).ToList();
                    break;
                case "3":
                    sortedRecipes = recipes.OrderByDescending(r => r.GetAverageRating()).ToList();
                    break;
                case "4":
                    sortedRecipes = recipes.OrderBy(r => r.GetAverageRating()).ToList();
                    break;
                default:
                    Console.WriteLine("Invalid option. Press any key to return...");
                    Console.ReadKey();
                    return;
            }

            DisplayAllRecipes(sortedRecipes);
        }

        internal void Run()
        {
            throw new NotImplementedException();
        }
    }

}
