using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    internal class Program
    {
        static int health;
        static int score;
        static void Main(string[] args)
        {
            health = 100;
            ShowHUD();

            Console.WriteLine("Press any key to see the effects of taking damage from an enemy and then defeating it.");
            Console.ReadKey(true);


            TakeDamage(5);
            AddScore(10, 1);
            ShowHUD();

            Console.WriteLine("Press any key to recieve a score multiplier of 3.");

            Console.ReadKey(true);

            AddScore(0, 3);
            ShowHUD();

            Console.WriteLine("Press Any Key to recieve health depending on the enemy you defeated.");

            Console.ReadKey(true);

            EnemyKill(1, 0);
            ShowHUD();

            Console.WriteLine("Good job! Press any key to close.");
            
            Console.ReadKey(true);
        }

        static void ShowHUD()
        {

            Console.WriteLine("---------");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("---------");


        }

        static void TakeDamage(int damage)
        {
            health = health - damage;
        }

        static void AddScore(int pointsearned, int scoremp)
        {
            score = pointsearned + score * scoremp;

        }
        static void EnemyKill(int enemy1, int enemy2)
        {
            health = health + enemy1 * 3;
            health = health + enemy2 * 5;
        }

    }
}
