using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class FavoritesManager
    {
        public Dictionary<User, List<Recipe>> Favorites { get; set; } = new Dictionary<User, List<Recipe>>();

        public void AddToFavorites(User user, Recipe recipe)
        {
            if (!Favorites.ContainsKey(user)) Favorites[user] = new List<Recipe>();
            Favorites[user].Add(recipe);
        }

        public void RemoveFromFavorites(User user, Recipe recipe)
        {
            if (Favorites.ContainsKey(user)) Favorites[user].Remove(recipe);
        }
    }
}
