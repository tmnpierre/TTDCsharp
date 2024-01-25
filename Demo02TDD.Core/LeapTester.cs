﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02TDD.Core
{
    public class LeapTester
    {
        public bool IsLeap(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) 
                return true;
            return false;
        }
    }
}
