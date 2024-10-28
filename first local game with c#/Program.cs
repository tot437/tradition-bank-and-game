using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy1 zombie = new Enemy1();
            Enemy2 hero = new Enemy2("RODE",200);
          

            Console.WriteLine(zombie.EnemyName);
            Console.WriteLine(zombie.Health);
            Console.WriteLine(hero.EnemyName);
            Console.WriteLine(hero.Health);
            
            

            Console.ReadLine();
            Console.ReadKey();
        }
    }

    class Enemy1
    {
        public int Id { get; set; }
        public string EnemyName { get; set; }
        public double Health { get; set; }

        public Enemy1()
        {
            Console.WriteLine("New Enemy is Created. ");
            EnemyName = "shapah";
            Health = 100;
        }
    }

    class Enemy2
    {
        public int Id { get; set; }
        public string EnemyName { get; set; }
        public double Health { get; set; }

        public Enemy2(string enemyName, double health)
        {
            Console.WriteLine("New Enemy is Created from parameterized constructor. ");
            EnemyName = enemyName;
            Health = health;
        }

        
    }
}
