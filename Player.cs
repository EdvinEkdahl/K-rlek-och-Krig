using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class Player : Character
{
    public Player(string Name__, int Health__, int minStrength__, int maxStrength__, int maxHealth__)
    {
        Name = Name__;
        Health = Health__;
        minStrength = minStrength__;
        maxStrength = maxStrength__;
        maxHealth = maxHealth__;
    }
}

