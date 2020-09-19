using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using Libraries.NPC_Library;
using Libraries.Item_Library;
using Libraries.Story;

namespace Libraries.Player_Library
{
    public class Base_Player
    {
        //Variables
        private static bool Encumbered;
        private static bool isalive;
        private static double expafter;
        public static double Current_Level_Xp = 20;
        public static int Char_Max_Items_Inventory = 15;

        //properties
        public float Char_Health { get; set; }
        public float Char_Total_Health{ get; set; }
        public float Char_Stamina { get; set; }
        public float Char_Total_Stamina { get; set; }
        public float Char_Magicka { get; set; }
        public float Char_Total_Magicka { get; set; }
        public double Char_Experience { get; set; }
        public int Char_Level { get; set; }
        public int Char_Capacity { get; set; }
        public int Char_Occupied_Space { get; set; }
        public int Char_Gold { get; set; }
        public float Char_Total_Damage { get; set; }
        public string Char_Name { get; set; }
        public string Char_Class { get; set; }
        public List<object> Char_Inventory { get; set; }
        public List<object> Char_Equipped_Items { get; set; }

        //methods
        public static void Check_Status(Player _Player)
        {
            Is_Alive_Neutral(_Player);
            Is_Encumbered(_Player);
        }
        public static void Is_Alive_Neutral(Player _player)
        {
            if(_player.Char_Health <= 0)
            {
                isalive = false;
                Console.WriteLine("You are dead.");
                End.End_Method();
            }
            else
            {
                isalive = true;
            }
        }
        public static void Is_Alive_Combat(Player _player, Enemy _enemy)
        {
            if(_player.Char_Health <= 0 || _enemy.Enemy_Health <= 0)
            {
                Is_Alive_Neutral(_player);
            }
            else
            {
                Console.WriteLine("Your Health: " + Math.Round(_player.Char_Health));
            }
        }
        public static void Is_Encumbered(Base_Player _player)
        {
            if (_player.Char_Occupied_Space > _player.Char_Capacity)
            {
                Console.WriteLine("You are over encumbered.");
                Encumbered = true;
            }
            else
            {
                Encumbered = false;
            }
        }
        public static void Is_Inventory_Full(Player _player)
        {
            if (_player.Char_Inventory.Count > Char_Max_Items_Inventory)
            {
                foreach (Item item in _player.Char_Inventory)
                {
                    for (int i = Player.Char_Max_Items_Inventory; i < _player.Char_Inventory.Count(); i++)
                    {
                        if (_player.Char_Inventory.ElementAt(i) != null)
                        {
                            _player.Char_Inventory.Remove(item);

                        }
                    }

                }
            }
        }
        public static void Add_Weight(Player _Player)
        {
            foreach (Item item in _Player.Char_Inventory)
            {
                _Player.Char_Occupied_Space += item.Item_Weight;
            }
        }
        public static void Is_Level_Up(Player _Player)
        {
            //fix this
            if(_Player.Char_Experience >= Current_Level_Xp)
            {
                expafter = _Player.Char_Experience - Current_Level_Xp;
                Current_Level_Xp = Math.Pow((_Player.Char_Level * 2), 2) + 25;
                _Player.Char_Experience += expafter;
                _Player.Char_Level += 1;
            }
            else
            {

            }

        }
    }
}
