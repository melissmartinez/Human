using System;

namespace Human
{
    class Human  
    {
        //fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        //add a public getter property to access heath
        public int health
        {
            get { return health; }
        }

        //add constrcutor that takes a value to set Name, and set the remanining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        //add constructor to assign custom values to all fields
        public Human(string name, int strength, int intelligence, int dexterity, int hp)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = hp;
        }
        //attack method
        public int Attack(Human target)
        {
            int dmg = Strength * 5;
            target.health -= dmg;
            return target.health;  
        }
    }
}
