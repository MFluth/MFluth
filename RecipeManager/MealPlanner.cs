using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class MealPlanner
    {
        private List<Recipe> _plannedMeals = new List<Recipe>();

        public void AddToPlan(Recipe recipe)
        {
            _plannedMeals.Add(recipe);
        }

        public string GetPlan()
        {
            if (!_plannedMeals.Any()) return "Meal plan is empty.";

            var plan = "Weekly Meal Plan:\n";
            for (int i = 0; i < _plannedMeals.Count; i++)
            {
                plan += $"Day {i + 1}: {_plannedMeals[i].Name}\n";
            }
            return plan;
        }

        internal void AddRecipe(Recipe selectedRecipe)
        {
            throw new NotImplementedException();
        }

        internal bool PlanMeal()
        {
            throw new NotImplementedException();
        }
    }

}
