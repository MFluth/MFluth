using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class ShoppingList
    {
        public List<Ingredient> GenerateList(Recipe recipe) => recipe.Ingredients;
    }
}
