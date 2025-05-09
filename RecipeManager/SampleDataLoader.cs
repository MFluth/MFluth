using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public static class SampleDataLoader
    {
        public static void LoadSampleRecipes(RecipeManager manager)
        {
            var categories = new List<Category>
        {
            new Category { Id = 1, Name = "Breakfast" },
            new Category { Id = 2, Name = "Lunch" },
            new Category { Id = 3, Name = "Dinner" },
            new Category { Id = 4, Name = "Dessert" },
            new Category { Id = 5, Name = "Snack" }
        };

            var cups = new MeasurementUnit { UnitName = "cups" };
            var tsp = new MeasurementUnit { UnitName = "tsp" };
            var tbsp = new MeasurementUnit { UnitName = "tbsp" };
            var pcs = new MeasurementUnit { UnitName = "pcs" };

            List<Recipe> sampleRecipes = new List<Recipe>
        {
            new Recipe { Name = "Pancakes", Category = categories[0], Instructions = "Mix and cook on skillet.",
                Ingredients = {
                    new Ingredient { Name = "Flour", Quantity = 1.5, Unit = cups },
                    new Ingredient { Name = "Milk", Quantity = 1, Unit = cups },
                    new Ingredient { Name = "Eggs", Quantity = 2, Unit = pcs }
                }
            },
            new Recipe { Name = "Scrambled Eggs", Category = categories[0], Instructions = "Whisk and cook eggs.",
                Ingredients = {
                    new Ingredient { Name = "Eggs", Quantity = 3, Unit = pcs },
                    new Ingredient { Name = "Butter", Quantity = 1, Unit = tbsp }
                }
            },
            new Recipe { Name = "Grilled Cheese Sandwich", Category = categories[1], Instructions = "Grill cheese between bread slices.",
                Ingredients = {
                    new Ingredient { Name = "Bread", Quantity = 2, Unit = pcs },
                    new Ingredient { Name = "Cheese", Quantity = 2, Unit = pcs },
                    new Ingredient { Name = "Butter", Quantity = 1, Unit = tbsp }
                }
            },
            new Recipe { Name = "Tomato Soup", Category = categories[1], Instructions = "Simmer tomatoes and blend.",
                Ingredients = {
                    new Ingredient { Name = "Tomatoes", Quantity = 4, Unit = pcs },
                    new Ingredient { Name = "Basil", Quantity = 1, Unit = tsp }
                }
            },
            new Recipe { Name = "Spaghetti Bolognese", Category = categories[2], Instructions = "Cook pasta and meat sauce.",
                Ingredients = {
                    new Ingredient { Name = "Spaghetti", Quantity = 2, Unit = cups },
                    new Ingredient { Name = "Ground Beef", Quantity = 1, Unit = cups },
                    new Ingredient { Name = "Tomato Sauce", Quantity = 1, Unit = cups }
                }
            },
            new Recipe { Name = "Chicken Stir Fry", Category = categories[2], Instructions = "Stir fry chicken with vegetables.",
                Ingredients = {
                    new Ingredient { Name = "Chicken Breast", Quantity = 1, Unit = pcs },
                    new Ingredient { Name = "Mixed Veggies", Quantity = 2, Unit = cups },
                    new Ingredient { Name = "Soy Sauce", Quantity = 2, Unit = tbsp }
                }
            },
            new Recipe { Name = "Chocolate Chip Cookies", Category = categories[3], Instructions = "Mix and bake.",
                Ingredients = {
                    new Ingredient { Name = "Flour", Quantity = 2.5, Unit = cups },
                    new Ingredient { Name = "Chocolate Chips", Quantity = 1, Unit = cups },
                    new Ingredient { Name = "Butter", Quantity = 1, Unit = cups }
                }
            },
            new Recipe { Name = "Brownies", Category = categories[3], Instructions = "Bake chocolate brownie batter.",
                Ingredients = {
                    new Ingredient { Name = "Cocoa Powder", Quantity = 0.5, Unit = cups },
                    new Ingredient { Name = "Sugar", Quantity = 1, Unit = cups },
                    new Ingredient { Name = "Flour", Quantity = 1, Unit = cups }
                }
            },
            new Recipe { Name = "Fruit Salad", Category = categories[4], Instructions = "Mix chopped fruits.",
                Ingredients = {
                    new Ingredient { Name = "Apple", Quantity = 1, Unit = pcs },
                    new Ingredient { Name = "Banana", Quantity = 1, Unit = pcs },
                    new Ingredient { Name = "Grapes", Quantity = 1, Unit = cups }
                }
            },
            new Recipe { Name = "Yogurt Parfait", Category = categories[4], Instructions = "Layer yogurt, granola, and fruit.",
                Ingredients = {
                    new Ingredient { Name = "Yogurt", Quantity = 1, Unit = cups },
                    new Ingredient { Name = "Granola", Quantity = 0.5, Unit = cups },
                    new Ingredient { Name = "Berries", Quantity = 0.5, Unit = cups }
                }
            },
            new Recipe { Name = "Quesadilla", Category = categories[1], Instructions = "Grill cheese in tortilla.",
                Ingredients = {
                    new Ingredient { Name = "Tortilla", Quantity = 1, Unit = pcs },
                    new Ingredient { Name = "Cheese", Quantity = 1, Unit = cups }
                }
            },
            new Recipe { Name = "Mac and Cheese", Category = categories[2], Instructions = "Cook pasta and mix with cheese.",
                Ingredients = {
                    new Ingredient { Name = "Macaroni", Quantity = 2, Unit = cups },
                    new Ingredient { Name = "Cheddar", Quantity = 1, Unit = cups }
                }
            },
            new Recipe { Name = "Salad", Category = categories[1], Instructions = "Mix greens and dressing.",
                Ingredients = {
                    new Ingredient { Name = "Lettuce", Quantity = 2, Unit = cups },
                    new Ingredient { Name = "Tomato", Quantity = 1, Unit = pcs },
                    new Ingredient { Name = "Dressing", Quantity = 2, Unit = tbsp }
                }
            },
            new Recipe { Name = "French Toast", Category = categories[0], Instructions = "Dip bread in egg and cook.",
                Ingredients = {
                    new Ingredient { Name = "Bread", Quantity = 2, Unit = pcs },
                    new Ingredient { Name = "Eggs", Quantity = 2, Unit = pcs },
                    new Ingredient { Name = "Milk", Quantity = 0.5, Unit = cups }
                }
            },
            new Recipe { Name = "Smoothie", Category = categories[0], Instructions = "Blend all ingredients.",
                Ingredients = {
                    new Ingredient { Name = "Banana", Quantity = 1, Unit = pcs },
                    new Ingredient { Name = "Milk", Quantity = 1, Unit = cups },
                    new Ingredient { Name = "Yogurt", Quantity = 0.5, Unit = cups }
                }
            }
        };

            foreach (var recipe in sampleRecipes)
            {
                manager.AddRecipe(recipe);
            }
        }
    }
}