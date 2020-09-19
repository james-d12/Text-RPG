using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Libraries.Item_Library;

namespace Libraries.NPC_Library
{
    public class Enemy : Base_Enemy
    {

        private static Random RandEnemy = new Random();
        private static Random RandAmount = new Random();

        //lists
        public static List<Enemy> Easy_Enemy_List = new List<Enemy>();
        public static List<Enemy> Medium_Enemy_List = new List<Enemy>();
        public static List<Enemy> Hard_Enemy_List = new List<Enemy>();
        //building lists
        public static List<Enemy> Easy_Building_List = new List<Enemy>();


        public static List<Enemy> Enemy_List = new List<Enemy>();
        public static List<Enemy> Hound_List = new List<Enemy>();
        public static List<Enemy> Other_Animal_List = new List<Enemy>();
        public static void Initialise_Enemies()
        {
            Enemies();
        }
        public static List<Enemy> Enemies()
        {
            Random Rand = new Random();
            Enemy MutatedHound = new Enemy();
            Enemy FatFuck = new Enemy();
            Enemy SickHound = new Enemy();
            Enemy UndeadHound = new Enemy();

            Enemy Wolf = new Enemy();
            Enemy Bear = new Enemy();

            Enemy Necromancer = new Enemy();
            Enemy FireSorcerer = new Enemy();
            Enemy FrostSorcerer = new Enemy();
            Enemy SparkSorcerer = new Enemy();

            Enemy Goblin = new Enemy();

            MutatedHound.Enemy_Health = 25;
            MutatedHound.Enemy_Magicka = 0;
            MutatedHound.Enemy_Movement_Speed = 5;
            MutatedHound.Enemy_Name = "a Mutated Hound";
            MutatedHound.Enemy_Stamina = 45;
            MutatedHound.Enemy_Gold_Drop = 5;
            MutatedHound.Enemy_XP_Drop = 20;
            MutatedHound.Enemy_Total_Damage = 10;
            MutatedHound.Enemy_Type = 1;
            MutatedHound.Enemy_Base_Damage = 3;
            MutatedHound.Enemy_Total_Damage += MutatedHound.Enemy_Base_Damage;
            MutatedHound.Enemy_Inventory = Item.Animal_Equipment_List;

            SickHound.Enemy_Health = 35;
            SickHound.Enemy_Magicka = 15;
            SickHound.Enemy_Movement_Speed = 4;
            SickHound.Enemy_Name = "a Sick Hound";
            SickHound.Enemy_Stamina = 25;
            SickHound.Enemy_XP_Drop = 35;
            SickHound.Enemy_Gold_Drop = 7;
            SickHound.Enemy_Total_Damage = 15;
            SickHound.Enemy_Type = 1;
            SickHound.Enemy_Base_Damage = 4;
            SickHound.Enemy_Total_Damage += SickHound.Enemy_Base_Damage;
            SickHound.Enemy_Inventory = Item.Animal_Equipment_List;

            UndeadHound.Enemy_Health = 45;
            UndeadHound.Enemy_Magicka = 0;
            UndeadHound.Enemy_Movement_Speed = 5;
            UndeadHound.Enemy_Name = "an Undead Hound";
            UndeadHound.Enemy_Stamina = 55;
            UndeadHound.Enemy_XP_Drop = 45;
            UndeadHound.Enemy_Total_Damage = 12;
            UndeadHound.Enemy_Type = 1;
            UndeadHound.Enemy_Gold_Drop = 10;
            UndeadHound.Enemy_Base_Damage = 5;
            UndeadHound.Enemy_Total_Damage += UndeadHound.Enemy_Base_Damage;
            UndeadHound.Enemy_Inventory = Item.Animal_Equipment_List;

            Wolf.Enemy_Health = 10;
            Wolf.Enemy_Magicka = 0;
            Wolf.Enemy_Movement_Speed = 5;
            Wolf.Enemy_Name = "a Wolf";
            Wolf.Enemy_Stamina = 25;
            Wolf.Enemy_XP_Drop = 15;
            Wolf.Enemy_Gold_Drop = 4;
            Wolf.Enemy_Total_Damage = 4;
            Wolf.Enemy_Type = 1;
            Wolf.Enemy_Base_Damage = 2;
            Wolf.Enemy_Total_Damage += Wolf.Enemy_Base_Damage;
            Wolf.Enemy_Inventory = Item.Animal_Equipment_List;

            Bear.Enemy_Health = 65;
            Bear.Enemy_Magicka = 0;
            Bear.Enemy_Movement_Speed = 3;
            Bear.Enemy_Name = "a Bear";
            Bear.Enemy_XP_Drop = 25;
            Bear.Enemy_Stamina = 50;
            Bear.Enemy_Gold_Drop = 11;
            Bear.Enemy_Total_Damage = 8;
            Bear.Enemy_Type = 1;
            Bear.Enemy_Base_Damage = 6;
            Bear.Enemy_Total_Damage += Bear.Enemy_Base_Damage;
            Bear.Enemy_Inventory = Item.Animal_Equipment_List;

            Necromancer.Enemy_Health = 50;
            Necromancer.Enemy_Magicka = 100;
            Necromancer.Enemy_Movement_Speed = 2;
            Necromancer.Enemy_Name = "a Necromancer";
            Necromancer.Enemy_XP_Drop = 60;
            Necromancer.Enemy_Gold_Drop = 12;
            Necromancer.Enemy_Stamina = 25;
            Necromancer.Enemy_Base_Damage = 0;
            Necromancer.Enemy_Type = 2;

            FireSorcerer.Enemy_Health = 65;
            FireSorcerer.Enemy_Magicka = 125;
            FireSorcerer.Enemy_Movement_Speed = 2;
            FireSorcerer.Enemy_Name = "a Fire Sorcerer";
            FireSorcerer.Enemy_XP_Drop = 55;
            FireSorcerer.Enemy_Gold_Drop = 13;
            FireSorcerer.Enemy_Stamina = 25;
            FireSorcerer.Enemy_Base_Damage = 0;
            FireSorcerer.Enemy_Type = 2;

            FrostSorcerer.Enemy_Health = 65;
            FrostSorcerer.Enemy_Magicka = 125;
            FrostSorcerer.Enemy_Movement_Speed = 2;
            FrostSorcerer.Enemy_Name = "a Frost Sorcerer";
            FrostSorcerer.Enemy_Stamina = 25;
            FrostSorcerer.Enemy_Gold_Drop = 12;
            FrostSorcerer.Enemy_XP_Drop = 55;
            FrostSorcerer.Enemy_Base_Damage =0;
            FrostSorcerer.Enemy_Type = 2;

            SparkSorcerer.Enemy_Health = 65;
            SparkSorcerer.Enemy_Magicka = 125;
            SparkSorcerer.Enemy_Movement_Speed = 2;
            SparkSorcerer.Enemy_Name = "a Spark Sorcerer";
            SparkSorcerer.Enemy_Stamina = 25;
            SparkSorcerer.Enemy_Gold_Drop = 11;
            SparkSorcerer.Enemy_Base_Damage = 0;
            SparkSorcerer.Enemy_XP_Drop = 55;
            SparkSorcerer.Enemy_Type = 2;

            Enemy_List.Add(MutatedHound);
            Enemy_List.Add(SickHound);
            Enemy_List.Add(UndeadHound);
            Enemy_List.Add(Wolf);
            Enemy_List.Add(Bear);
            Enemy_List.Add(Necromancer);
            Enemy_List.Add(FireSorcerer);
            Enemy_List.Add(FrostSorcerer);
            Enemy_List.Add(SparkSorcerer);
            Enemy_List.Add(Goblin);

            Hound_List.Add(MutatedHound); 
            Hound_List.Add(SickHound);
            Hound_List.Add(UndeadHound);

            Other_Animal_List.Add(Wolf);
            Other_Animal_List.Add(Bear);

            Easy_Enemy_List.AddRange(Hound_List);

            for (int i = 0; i < RandAmount.Next(1,4); i++)
            {
                Easy_Building_List.Add(Easy_Enemy_List[RandEnemy.Next(0, Easy_Enemy_List.Count)]);
            }

            return Enemy_List;
        }
    }
}
