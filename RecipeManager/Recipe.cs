using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public string Instructions { get; set; }
        public List<Rating> Ratings { get; set; } = new List<Rating>();
        public List<Tag> Tags { get; set; } = new List<Tag>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public void AddIngredient(Ingredient ingredient) => Ingredients.Add(ingredient);
        public void RemoveIngredient(Ingredient ingredient) => Ingredients.Remove(ingredient);
        public double GetAverageRating() => Ratings.Count > 0 ? Ratings.Average(r => r.Score) : 0.0;
        public string DisplayRecipe() => $"{Name} ({Category.GetCategoryName()}): {Instructions}";
    }
}
