using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Races;
public interface IRace
{

    string Name { get; }
    int Health { get; }
    int Damage { get; }
    int Defense { get; }

}
