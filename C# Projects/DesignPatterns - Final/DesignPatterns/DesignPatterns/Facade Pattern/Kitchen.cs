﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade_Pattern
{
    /// <summary>
    /// Each kitchen section must implement this
    /// </summary>
    interface Kitchen
    {
        FoodItem PrepDish(string dishName);
    }
}
