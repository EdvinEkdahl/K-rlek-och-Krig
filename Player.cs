using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class Player : Character
{
    public Player(string Name__, int Health__, int Streagnth__, int maxHealth__)
    {
        Name = Name__;
        Health = Health__;
        Streagnth = Streagnth__;
        maxHealth = maxHealth__;

        Health = maxHealth;
    }

}

