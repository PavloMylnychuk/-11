namespace InfernoInfinity
{
    using System;
    using System.Collections.Generic;

    public abstract class Weapon
    {
        public string Name { get; set; }
        public int MinDamage { get; protected set; }
        public int MaxDamage { get; protected set; }
        public int Sockets { get; protected set; }
    }

    public class Axe : Weapon
    {
        public Axe()
        {
            MinDamage = 5;
            MaxDamage = 10;
            Sockets = 4;
        }
    }

    public class Sword : Weapon
    {
        public Sword()
        {
            MinDamage = 4;
            MaxDamage = 6;
            Sockets = 3;
        }
    }

    public class Knife : Weapon
    {
        public Knife()
        {
            MinDamage = 3;
            MaxDamage = 4;
            Sockets = 2;
        }
    }

    public class Gem
    {
        // Реалізація класу коштовності
    }
}
