using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Weapons;
public class Pistol: IWeapon
{
    public string Name => "Pistol ";
    public int Damage => 20;

}
