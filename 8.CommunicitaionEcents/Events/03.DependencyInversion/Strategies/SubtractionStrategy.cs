﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SubtractionStrategy : IStrategy
{
    public int Calculate(int firstOperand, int secondOperand)
    {
        return firstOperand - secondOperand;
    }
}

