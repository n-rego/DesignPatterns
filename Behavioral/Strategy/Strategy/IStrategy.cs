﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    public interface IStrategy
    {
        public int Execute(int a, int b);
    }
}
