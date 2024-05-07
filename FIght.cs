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
    Random random = new Random();

    void EnemyTurn(Player player, Enemy enemy)
    {
        D6 = random.Next(1, 7);

        if (D6 >= enemy.HitChance)
        {
            player.Health -= enemy.Streagnth;
            Console.WriteLine(player.Name + "dealt" + player.Streagnth + "damage");

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

        enemy.Health -= player.Streagnth;
        Console.WriteLine(player.Name + "dealt" + player.Streagnth + "damage");

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

        player.Health += 3;
        Console.WriteLine(player.Name + " healed 3 HP");
        EnemyTurn(player, enemy);

        Console.WriteLine(player.Name + ": HP: " + player.Health + "/" + player.maxHealth + "\n" +
                          enemy.Name + ": HP: " + enemy.Health + "/" + enemy.maxHealth);
    }
}

