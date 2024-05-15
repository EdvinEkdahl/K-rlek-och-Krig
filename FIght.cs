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
        D6 = random.Next(1, 7);
        enemyDamage = random.Next(enemy.minStrength, enemy.maxStrength + 1);

        if (D6 >= enemy.HitChance)
        {
            player.Health -= enemyDamage;
            Console.WriteLine(enemy.Name + " dealt " + enemyDamage + " damage");

            if (player.Health <= 0)
            {
                Console.WriteLine(player.Name + " has been defeated");
                player.IsAlive = false;
            }
        }
        else
        {
            Console.WriteLine(enemy.Name + " missed their attack");
        }
    }

    public void Battle(Player player, Enemy enemy)
    {
        Console.Clear();
        Console.WriteLine(player.Name + ": HP: " + player.Health + "/" + player.maxHealth + "\n" +
                          enemy.Name + ": HP: " + enemy.Health + "/" + enemy.maxHealth);

        playerDamage = random.Next(player.minStrength, player.maxStrength + 1);

        enemy.Health -= playerDamage;
        Console.WriteLine(player.Name + " dealt " + playerDamage + " damage");

        if (enemy.Health <= 0)
        {
            Console.WriteLine(enemy.Name + " has been defeated");
            enemy.IsAlive = false;
        }
        else
        {
            EnemyTurn(player, enemy);
        }

        Console.WriteLine(player.Name + ": HP: " + player.Health + "/" + player.maxHealth + "\n" +
                          enemy.Name + ": HP: " + enemy.Health + "/" + enemy.maxHealth);
    }

    public void Block(Player player, Enemy enemy)
    {
        Console.Clear();
        Console.WriteLine(player.Name + ": HP: " + player.Health + "/" + player.maxHealth + "\n" +
                          enemy.Name + ": HP: " + enemy.Health + "/" + enemy.maxHealth);

        playerHeal = random.Next(0,4);
        player.Health += playerHeal;
        if(player.Health > player.maxHealth)
        {
            player.Health = player.maxHealth;
        }
        Console.WriteLine(player.Name + " healed " + playerHeal + " HP");
        EnemyTurn(player, enemy);

        Console.WriteLine(player.Name + ": HP: " + player.Health + "/" + player.maxHealth + "\n" +
                          enemy.Name + ": HP: " + enemy.Health + "/" + enemy.maxHealth);
    }
}

