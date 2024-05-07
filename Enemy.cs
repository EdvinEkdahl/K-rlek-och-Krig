using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Enemy : Character
{
    public int HitChance;

    public Enemy(string Name__, int Health__, int Streagnth__, int maxHealth__, int HitChance__)
    {
        Name = Name__;
        Health = Health__;
        Streagnth = Streagnth__;
        maxHealth = maxHealth__;
        HitChance = HitChance__;

        Health = maxHealth;
    }
}

