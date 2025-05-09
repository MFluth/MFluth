using RecipeManager;
using System;
using System.Collections;
using System.Collections.Generic;

namespace RecipeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipeManager = new RecipeManager();
            var shoppingList = new ShoppingList();
            var mealPlanner = new MealPlanner();

            SampleDataLoader.LoadSampleRecipes(recipeManager); // Make sure you have this class with 15 recipes

            var ui = new RecipeUI(recipeManager, shoppingList, mealPlanner);
            ui.Run();
        }
    }
}
