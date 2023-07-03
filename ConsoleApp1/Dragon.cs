using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dragon
    {
        public int HealthPoints { get; set; }
        public int Gun { get; set; }
        public int Food { get; set; }
        public int Reputation { get; set; }
        public int Hunger { get; set; }
        public Dragon() 
        {
            HealthPoints = 0;
            Gun = 0;
            Food = 0;
            Reputation = 0;
            Hunger = 0;
        }
        public Dragon(int healthPoints, int gun, int food)
        {
            HealthPoints = healthPoints;
            Gun = gun;
            Food = food;
            Reputation = 0;
            Hunger = 0;
        }
    }
    public class MyLittleDragon : Dragon
    {
        public MyLittleDragon() : base(70, 15, 25)
        {}
    }
    public class OrdinaryDragon : Dragon
    {
        public OrdinaryDragon() : base(50, 10, 40)
        {}
    }
    public class VillageNightmare : Dragon
    {
        public VillageNightmare() : base(150, 25, 30)
        {}
    }
}