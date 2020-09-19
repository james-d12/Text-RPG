using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using Libraries.Item_Library;
using Libraries.NPC_Library;
using Libraries.Buildings;

namespace Libraries.Player_Library
{
    public class Base_Player_Actions
    {
        public static Random randwait = new Random();

        public static bool printoutchoice = true;

        public static Random exp_rand = new Random();
        public static void Action_Handler(Player _player, Enemy _enemy , string _Sentence01, string _Sentence02)
        {
            while (_enemy.Enemy_Health > 0f && _player.Char_Health > 0f)
            {

                Console.Write("What do you do?:  Attack [1] | Defend [2] | View Inventory [3] | Save [4] | Quit [5]");
                string actionchoice = Console.ReadLine();
                if (_enemy.Enemy_Health > 0 && _player.Char_Health > 0)
                {
                    switch (actionchoice)
                    {
                        case "1":
                            Give_Damage(_player, _enemy);
                            break;
                        case "2":
                            Take_Damage(_player, _enemy);
                            break;
                        case "3":
                            Draw_UI.Draw_Inventory_Main(_player, _Sentence01, _Sentence02);
                            break;
                        case "4":
                            Save.Save_Character(_player);
                            break;
                        case "5":
                            Exit.Exit_Main();
                            break;
                    }
                }
                else
                {
                    if (_enemy.Enemy_Health <= 0)
                    {
                        Console.WriteLine("Enemy is dead");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You are dead.");
                        End.End_Method();
                    }
                }

            }
        }
        public static void Take_Damage(Player _player , Enemy _enemy)
        {
            Console.WriteLine("Defending......");
            Thread.Sleep(randwait.Next(1000, 3000));
            foreach (Item item in _player.Char_Inventory)
            {
                _player.Char_Health += (item.Item_Armor_Rating / 2);
                _player.Char_Total_Health += (item.Item_Armor_Rating / 2);
                _player.Char_Total_Damage += item.Item_Damage;
                _player.Char_Stamina -= item.Item_Stamina_Cost;
                _player.Char_Magicka -= item.Item_Magicka_Cost;
            }
            foreach (Item item in _enemy.Enemy_Inventory)
            {
                _enemy.Enemy_Total_Damage += item.Item_Damage;
            }
            _player.Char_Health -= _enemy.Enemy_Total_Damage;
            _enemy.Enemy_Health -= _player.Char_Total_Damage / 3;
            Enemy.Is_Alive_Combat(_enemy, _player);
            Player.Is_Alive_Combat(_player, _enemy);
            
        }
        public static void Give_Damage(Player _player, Enemy _enemy )
        {
            Console.WriteLine("Attacking......");
            Thread.Sleep(randwait.Next(1000, 3000));
            foreach (Item item in _player.Char_Inventory)
            {
                _player.Char_Total_Damage += item.Item_Damage;
                _player.Char_Stamina -= item.Item_Stamina_Cost;
                _player.Char_Magicka -= item.Item_Magicka_Cost;
            }
            foreach (Item item in _enemy.Enemy_Inventory)
            {
                _enemy.Enemy_Health += item.Item_Armor_Rating;
            }
            _enemy.Enemy_Health -= _player.Char_Total_Damage / 1.15f;
            _player.Char_Health -= _enemy.Enemy_Total_Damage / 1.50f;
            Enemy.Is_Alive_Combat(_enemy, _player);
            Player.Is_Alive_Combat(_player, _enemy);

        }
        public static void Search_Building(Player _player, Building _building)
        {
            string search;
            do
            {
                Console.Write("Do you want to search?");
                search = Console.ReadLine();
            } while (search.All(char.IsLetter) == false);
            switch (search)
            {
                case "Yes":
                    Console.WriteLine("Searching............");
                    Thread.Sleep(randwait.Next(1000, 3000));
                    foreach (Item item in _building.Building_Items)
                    {
                        Console.WriteLine("You found " + item.Item_Name);
                        _player.Char_Inventory.Add(item);
                    }
                    Player.Add_Weight(_player);
                    Player.Check_Status(_player);  
                    break;
                case "No":
                    break;

            }
        }
        public static void Equipment_Loadout_Main(Player player , string sentence01 , string sentence02 , string Input)
        {
            switch (Input)
            {
                case "1":
                    Draw_UI.Draw_Inventory_Weapon_Loadout(player, sentence01, sentence02, Input);
                    Equipment_Loadout_Physical(player, sentence01, sentence02);
                    break;
                case "2":
                    Draw_UI.Draw_Inventory_Weapon_Loadout(player, sentence01, sentence02, Input);
                    Equipment_Loadout_Magic(player, sentence01, sentence02);
                    break;
            }
        }
        public static void Equipment_Loadout_Magic(Player player , string sentence01 , string sentence02)
        {
            int x = 0;
            List<string> itemname = new List<string>();
            string inputitemequip;
            while (x < Draw_UI.Player_Items_Equipment.Count())
            {
                do
                {
                    Console.WriteLine("Select Item: ");
                    inputitemequip = Console.ReadLine();
                } while (inputitemequip.All(char.IsLetter) == false);
                if (inputitemequip == "Back" || inputitemequip == "back" || inputitemequip == "BACK")
                {
                }
                else
                {
                    foreach (Item item in Draw_UI.Player_Items_Equipment)
                    {
                        itemname.Add(item.Item_Name);
                    }
                    if (itemname.Contains(inputitemequip))
                    {
                        foreach (Item item in Draw_UI.Player_Items_Equipment)
                        {
                            if (inputitemequip == item.Item_Name)
                            {
                                x = x + 1;
                                Equip_Items(player, item);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Item not found.");
                    }
                }
            }
            
        }
        public static void Equipment_Loadout_Physical(Player player, string sentence01, string sentence02)
        {

        }
        public static void Check_Equip_Capacity(Player _player)
        {
            if(_player.Char_Equipped_Items.Count > 5)
            {
                Console.WriteLine("You have too many items equipped.");
            }
        }
        public static void Equip_Items(Player _player , Item item)
        {
            Check_Equip_Capacity(_player);
            _player.Char_Equipped_Items.Add(item);
        }

    }
}
