using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Weapons;
public class Fork: IWeapon
{
    public string Name => "Fork";
    public int Damage => 1;
}

