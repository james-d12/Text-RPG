using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Libraries.Item_Library;
using Libraries.Player_Library;

namespace Libraries.NPC_Library
{
    public class Base_Enemy 
    {

        private const int Enemy_Max_Health = 500;
        private const int Enemy_Min_Health = 0;
        private const int Enemy_Max_Stamina = 300;
        private const int Enemy_Min_Stamina = 0;
        private const int Enemy_Max_Magicka = 300;
        private const int Enemy_Min_Magicka = 0;
        private const int Enemy_Max_Health_Regen = 5;
        private const int Enemy_Max_Magicka_Regen = 10;
        private const int Enemy_Max_Stamina_Regen = 5;
        private const int Enemy_Min_Regen = 0;
        private const int Enemy_Max_Movement = 5;
        private const int Enemy_Min_Movement = 1;
        private const int Enemy_Max_Total_Damage = 100;
        private const int Enemy_Min_Total_Damage = 1;
        public static bool isalive;

        public string Enemy_Name { get; set; }
        public int Enemy_XP_Drop { get; set; }
        public int Enemy_Type { get; set; }
        public float Enemy_Health { get; set; }
        public int Enemy_Stamina { get; set; }
        public int Enemy_Base_Damage { get; set; }
        public int Enemy_Gold_Drop { get; set; }
        public int Enemy_Magicka { get; set; }
        public int Enemy_Movement_Speed { get; set; }
        public float Enemy_Total_Damage { get; set; }
        public List<object> Enemy_Inventory { get; set; }

        public static bool Is_Alive_Neutral(Enemy _Enemy, Player _Player)
        {
            if (_Enemy.Enemy_Health <= 0)
            {
                isalive = false;
                Console.WriteLine("Enemy is dead.");
                Drop_Items_Exp(_Enemy, _Player);
                Player.Is_Level_Up(_Player);
                Thread.Sleep(2000);
                return isalive;
            }
            else
            {
                isalive = true;
                return isalive;
            }
        }
        public static void Is_Alive_Combat(Enemy _enemy, Player _player)
        {
            if (_enemy.Enemy_Health <= 0)
            {
                Is_Alive_Neutral(_enemy, _player);
            }
            else
            {
                Console.WriteLine("Enemy Health: " + Math.Round(_enemy.Enemy_Health));
            }
        }
        public static void Drop_Items_Exp(Enemy _Enemy, Player _player)
        {
            _player.Char_Experience += _Enemy.Enemy_XP_Drop;
            Console.WriteLine("You gained " + _Enemy.Enemy_XP_Drop + " experience points.");
            _player.Char_Inventory.AddRange(_Enemy.Enemy_Inventory);
            foreach (Item item in _Enemy.Enemy_Inventory)
            {
                Console.WriteLine("The enemy dropped a " + item.Item_Name);
            }
            _player.Char_Gold += _Enemy.Enemy_Gold_Drop;
            Console.WriteLine("The enemy dropped " + _Enemy.Enemy_Gold_Drop + " gold coins");
            Player.Add_Weight(_player);
            Player.Is_Encumbered(_player);
        }
    }
}
