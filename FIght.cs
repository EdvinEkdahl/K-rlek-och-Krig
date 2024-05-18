using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

class FIght
{
    int D6;
    int playerDamage;
    int enemyDamage;
    int playerHeal;
    Random random = new Random();

    void EnemyTurn(Player player, Enemy enemy)
    {
        D6 = random.Next(1, 7); //Rolls a D6 (Randomizes a value between 1 - 6)
        enemyDamage = random.Next(enemy.minStrength, enemy.maxStrength + 1); //Randomizes damage

        if (D6 >= enemy.HitChance) //Checks if the enemy rolled equal or higher than their hit chance
        {
            player.Health -= enemyDamage; //Player takes damage equal to enemy damage
            Console.WriteLine(enemy.Name + " gjorde " + enemyDamage + " skada\n");

            if (player.Health <= 0) //Checks if the player is dead
            {
                Console.WriteLine(player.Name + " har blivit besegrad");
                player.IsAlive = false; //Player is now considered dead
            }
        }
        else //If enemy rolls the D6 lower than their hit chance
        {
            Console.WriteLine(enemy.Name + " missade sin attack\n");
        }
    }

    public void Battle(Player player, Enemy enemy)
    {
        Console.Clear();
        Console.WriteLine(player.Name + ": HP: " + player.Health + "/" + player.maxHealth + "\n" +
                          enemy.Name + ": HP: " + enemy.Health + "/" + enemy.maxHealth + "\n");

        playerDamage = random.Next(player.minStrength, player.maxStrength + 1); //Randomizes damage

        enemy.Health -= playerDamage; //Enemy takes damage equal to player damage
        Console.WriteLine(player.Name + " gjorde " + playerDamage + " skada");

        if (enemy.Health <= 0) //Checks if enemy is dead
        {
            Console.WriteLine(enemy.Name + " har blivit besegrad\n");
            enemy.IsAlive = false; //Enemy is considred dead
        }
        else //Enemy gets to do their turn
        {
            EnemyTurn(player, enemy);
        }

        Console.WriteLine(player.Name + ": HP: " + player.Health + "/" + player.maxHealth + "\n" +
                          enemy.Name + ": HP: " + enemy.Health + "/" + enemy.maxHealth + "\n");
    }

    public void Block(Player player, Enemy enemy)
    {
        Console.Clear();
        Console.WriteLine(player.Name + ": HP: " + player.Health + "/" + player.maxHealth + "\n" +
                          enemy.Name + ": HP: " + enemy.Health + "/" + enemy.maxHealth + "\n");

        //Player gains a random amount of health
        playerHeal = random.Next(0,4);
        player.Health += playerHeal;

        //Sets player health to max health it excceds max health
        if(player.Health > player.maxHealth)
        {
            player.Health = player.maxHealth;
        }

        Console.WriteLine(player.Name + " fick tillbaka " + playerHeal + " HP");
        EnemyTurn(player, enemy);

        Console.WriteLine(player.Name + ": HP: " + player.Health + "/" + player.maxHealth + "\n" +
                          enemy.Name + ": HP: " + enemy.Health + "/" + enemy.maxHealth + "\n");
    }
}

