using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class RecipeUI
    {
        private RecipeManager _manager;
        private ShoppingList _shoppingList;
        private MealPlanner _mealPlanner;
        private RecipeManager recipeManager;

        public RecipeUI(RecipeManager manager, ShoppingList shoppingList, MealPlanner mealPlanner)
        {
            _manager = manager;
            _shoppingList = shoppingList;
            _mealPlanner = mealPlanner;
        }

        public RecipeUI(RecipeManager recipeManager)
        {
            this.recipeManager = recipeManager;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nRecipe App Menu:");
                Console.WriteLine("1. List Recipes");
                Console.WriteLine("2. Filter by Category");
                Console.WriteLine("3. Sort by Name");
                Console.WriteLine("4. Sort by Rating");
                Console.WriteLine("5. Search Recipes");
                Console.WriteLine("6. View Shopping List");
                Console.WriteLine("7. View Meal Plan");
                Console.WriteLine("8. Exit");
                Console.Write("Select an option: ");

                var input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        DisplayRecipes(_manager.Recipes);
                        break;
                    case "2":
                        SelectCategory();
                        break;
                    case "3":
                        DisplayRecipes(_manager.SortByName());
                        break;
                    case "4":
                        DisplayRecipes(_manager.SortByRating());
                        break;
                    case "5":
                        SearchRecipes();
                        break;
                    case "6":
                        ViewShoppingList();
                        break;
                    case "7":
                        ViewMealPlan();
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        private void DisplayRecipes(List<Recipe> recipes)
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes found.");
                return;
            }

            int index = 1;
            foreach (var recipe in recipes)
            {
                Console.WriteLine($"{index++}. {recipe.Name} ({recipe.Category.GetCategoryName()})");
                Console.WriteLine($"   Average Rating: {recipe.GetAverageRating():0.0} ({recipe.Ratings.Count} rating{(recipe.Ratings.Count == 1 ? "" : "s")})");
                Console.WriteLine($"   Instructions: {recipe.Instructions}");
                Console.WriteLine();
            }
        }

        private void SelectCategory()
        {
            var categories = _manager.Recipes.Select(r => r.Category.Name).Distinct().ToList();
            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {categories[i]}");
            }

            Console.Write("Select a category number: ");
            if (int.TryParse(Console.ReadLine(), out int selected) && selected > 0 && selected <= categories.Count)
            {
                string category = categories[selected - 1];
                var filtered = _manager.FilterByCategory(category);
                DisplayRecipes(filtered);
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }

        private void SearchRecipes()
        {
            Console.Write("Enter search keyword: ");
            string keyword = Console.ReadLine();
            var results = _manager.SearchRecipe(keyword);
            if (results.Count == 0)
            {
                Console.WriteLine("No recipes found.");
                return;
            }

            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {results[i].Name} ({results[i].Category.GetCategoryName()}) | Avg Rating: {results[i].GetAverageRating():0.0}");
            }

            Console.Write("Select a recipe number to view ingredients (or press Enter to skip): ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= results.Count)
            {
                var selectedRecipe = results[choice - 1];
                Console.WriteLine($"\nIngredients for {selectedRecipe.Name}:");
                foreach (var ingredient in selectedRecipe.Ingredients)
                {
                    Console.WriteLine($"- {ingredient.GetFormattedIngredient()}");
                }

                Console.Write("\nAdd ingredients to shopping list? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    _shoppingList.AddIngredients(selectedRecipe.Ingredients);
                    Console.WriteLine("Ingredients added to shopping list.");
                }

                Console.Write("Add recipe to meal planner? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    _mealPlanner.AddRecipe(selectedRecipe);
                    Console.WriteLine("Recipe added to meal planner.");
                }
            }
        }

        private void ViewShoppingList()
        {
            var list = _shoppingList.GetList();
            if (list.Count == 0)
            {
                Console.WriteLine("Shopping list is empty.");
            }
            else
            {
                Console.WriteLine("Shopping List:");
                foreach (var item in list)
                {
                    Console.WriteLine($"- {item.GetFormattedIngredient()}");
                }
            }
        }

        private void ViewMealPlan()
        {
            Console.WriteLine(_mealPlanner.PlanMeal());
        }
    }
}
