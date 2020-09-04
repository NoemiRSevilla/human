using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human alpha = new Human("Joe", 3, 10, 10, 100);
            Human beta = new Human ("Jack", 3, 3, 3, 50);
            alpha.Attack(beta);
        }
    }
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public Human (string val)
        {
            Name = val;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public Human (string name, int strength, int intelligence, int dexterity, int health_again)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health_again;
        }
        public int Attack(Human target)
        {
            int damage = 5*Strength;
            target.health = target.health - damage;
            return target.health;
        }
    }
}
