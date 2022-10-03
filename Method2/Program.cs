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
            ShowHUD();

            Console.ReadKey(true);

            Console.WriteLine("After taking damage from an enemy and then defeating it.");

            TakeDamage(5);
            AddScore(10, 1);
            ShowHUD();
            Console.ReadKey(true);
            Console.ReadKey(true);
        }

        static void ShowHUD()
        {
            health = 100;
            Console.WriteLine("---------");
            Console.WriteLine("Health"+ health);
            Console.WriteLine("Score"+ score);
            Console.WriteLine("---------");


        }

        static void TakeDamage(int damage)
        {
            health = health - damage;
        }

        static void AddScore(int pointsearned, int scoremp)
        {
            score = pointsearned * scoremp;
        }


    }
}
