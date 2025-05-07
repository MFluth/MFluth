using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class RecipeManager
    {
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();

        public void AddRecipe(Recipe recipe) => Recipes.Add(recipe);
        public void RemoveRecipe(Recipe recipe) => Recipes.Remove(recipe);
        public List<Recipe> SearchRecipe(string query) => Recipes.Where(r => r.Name.ToLower().Contains(query.ToLower())).ToList();
        public List<Recipe> GetTopRated() => Recipes.OrderByDescending(r => r.GetAverageRating()).ToList();
        public List<Recipe> FilterByCategory(string categoryName) => Recipes.Where(r => r.Category.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase)).ToList();
        public List<Recipe> SortByName() => Recipes.OrderBy(r => r.Name).ToList();
        public List<Recipe> SortByRating() => Recipes.OrderByDescending(r => r.GetAverageRating()).ToList();
    }
}
