using System;

namespace Klasser
{
  public class Player
  {
    public int x;
    public int y;
    public float speed;

    public int hp = 600;
    public int mp;
    public int weaponDamage;

    public string name;

    public Player(int y)
    {
      Random generator = new Random();

      if (generator.Next(100) < 20)
      {
        name = "Herbert";
      }
      else
      {
        name = "Anna";
      }

      x = generator.Next(100);
      hp = 500;
    }

    public void Move()
    {
      x += (int)speed;
      y += (int)speed;
      // SayHello();
    }

    public static void SayHello()
    {

    }
  }
}