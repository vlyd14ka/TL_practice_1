using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Weapons;
public class NoWeapon: IWeapon
{
    public string Name => "No Weapon";
    public int Damage => 0;
}
