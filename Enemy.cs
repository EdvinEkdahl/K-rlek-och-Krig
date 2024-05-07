using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Enemy : Character
{
    public Enemy(string Name__, int Health__, int Streagnth__, int maxHealth__)
    {
        Name = Name__;
        Health = Health__;
        Streagnth = Streagnth__;
        maxHealth = maxHealth__;

        Health = maxHealth;
    }
}

