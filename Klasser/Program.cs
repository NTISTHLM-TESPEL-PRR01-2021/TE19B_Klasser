using System;
using System.Collections.Generic;

namespace Klasser
{
  class Program
  {
    static void Main(string[] args)
    {
      MySeriousStuff.SayHello();

      // List<Player> players = new List<Player>();

      // players.Add(new Player());

      Player hero = new Player(100);
      Player hero2 = new Player(200);



      Hurt(hero, 30);

      hero.Move();

      hero.x = 150;
      hero2.x = 50;

      Console.WriteLine(hero.x);

      Console.ReadLine();

      // Position (x, y / vector)
      // HP
      // MP
      // HPmax
      // Speed
      // Name
      // WeaponDamage
      // Rectangle
      // Texture2D

      // (int, int, float, Rectangle) PlayerMovement(x, y, speed, rectangle)
    }

    static void Hurt(Player player, int amount)
    {
      player.hp -= amount;
    }
  }
}