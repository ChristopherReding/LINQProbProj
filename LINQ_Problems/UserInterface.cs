﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    public static class UserInterface
    {
        public static List<string> HandleCommas(string input)
        {
            return input.Split(',').ToList();
        }
    }
}
