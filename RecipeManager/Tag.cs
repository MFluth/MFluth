﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GetTagName() => Name;
    }
}
