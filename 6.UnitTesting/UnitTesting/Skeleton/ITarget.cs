﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ITarget
{
    void TakeAttack(int attackPoints);
    int Health { get; }
    int GiveExperience();
    bool IsDead();
}

