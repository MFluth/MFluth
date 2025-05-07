using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class Rating
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public string User { get; set; }
        public string Comment { get; set; }
        public string GetRatingDetails() => $"{User} rated {Score}/5 - {Comment}";
    }
}
