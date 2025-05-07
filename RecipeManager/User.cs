using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<Recipe> SavedRecipes { get; set; } = new List<Recipe>();
        public List<Recipe> FavoriteRecipes { get; set; } = new List<Recipe>();

        public void SaveRecipe(Recipe recipe) => SavedRecipes.Add(recipe);
        public void RemoveSavedRecipe(Recipe recipe) => SavedRecipes.Remove(recipe);
        public void AddToFavorites(Recipe recipe) => FavoriteRecipes.Add(recipe);
    }

}
