﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Armors;
public class NoArmor:IArmor
{
    public string Name => "No Armor";
    public int DefenseDamage => 0;
}

