using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public MeasurementUnit Unit { get; set; }

        public string GetFormattedIngredient() => $"{Quantity} {Unit.GetUnitName()} {Name}";
    }
}
