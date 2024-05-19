using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Character
{
    public int Health; //Amount of health
    public int minStrength; //The minimum damage a character can deal
    public int maxStrength; //The maximum damage a character can deal
    public int maxHealth; //The value health should not excced
    public string Name; //Name of the character
    public bool IsAlive = true; //Changes if character dies

}

