using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class ShoppingList
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public void AddIngredients(List<Ingredient> newIngredients)
        {
            foreach (var newItem in newIngredients)
            {
                var existing = _ingredients.FirstOrDefault(i =>
                    i.Name.Equals(newItem.Name, StringComparison.OrdinalIgnoreCase) &&
                    i.Unit.UnitName.Equals(newItem.Unit.UnitName, StringComparison.OrdinalIgnoreCase));

                if (existing != null)
                {
                    existing.Quantity += newItem.Quantity;
                }
                else
                {
                    _ingredients.Add(new Ingredient
                    {
                        Name = newItem.Name,
                        Quantity = newItem.Quantity,
                        Unit = newItem.Unit
                    });
                }
            }
        }

        public List<Ingredient> GetList() => _ingredients;
    }
}
