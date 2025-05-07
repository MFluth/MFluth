using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class DatabaseHandler
    {
        public void SaveRecipe(Recipe recipe)
        {
            // Placeholder for file or DB write logic
            Console.WriteLine($"Saving recipe: {recipe.Name}");
        }

        public List<Recipe> LoadRecipes()
        {
            // Placeholder for file or DB load logic
            return new List<Recipe>();
        }
    }

}
