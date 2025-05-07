using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class Comment
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public string GetCommentDetails() => $"{User} on {Timestamp}: {Content}";
    }
}
