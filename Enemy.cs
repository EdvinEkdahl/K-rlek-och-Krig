using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Enemy : Character
{
    public int HitChance; //A value to see whether a attack lands or not based of

    public Enemy(string Name__, int Health__, int minStrength__, int maxStrength__, int maxHealth__, int HitChance__)
    {
        Name = Name__;
        Health = Health__;
        minStrength = minStrength__;
        maxStrength = maxStrength__;
        maxHealth = maxHealth__;
        HitChance = HitChance__;
    }
}

