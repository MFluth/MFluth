using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class MealPlanner
    {
        public string PlanMeal(List<Recipe> recipes)
        {
            var plan = "Weekly Meal Plan:\n";
            for (int i = 0; i < 7 && i < recipes.Count; i++)
            {
                plan += $"Day {i + 1}: {recipes[i].Name}\n";
            }
            return plan;
        }
    }
}
