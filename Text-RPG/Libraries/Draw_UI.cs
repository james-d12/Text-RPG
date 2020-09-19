using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using Libraries.Player_Library;
using Libraries.NPC_Library;
using Libraries.Item_Library;
using Libraries.Buildings;

namespace Libraries
{
    public class Draw_UI
    {
        public static List<Item> Player_Items_Equipment = new List<Item>();
        public static Random randwait = new Random();

        public static void Draw_Loading()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("|||                                                                                                  ");
            Thread.Sleep(200);
            Console.WriteLine("|||                                                                                                    ");
            Thread.Sleep(200);
            Console.WriteLine("|||             |||||               |||           |||||||||||||  000  |||        |||  |||||||||||||   ");
            Thread.Sleep(200);
            Console.WriteLine("|||             |||||               |||           |||       |||   |   ||||       |||  |||             ");
            Thread.Sleep(200);
            Console.WriteLine("|||          |||      |||         ||| |||         |||       |||  |||  |||||      |||  |||             ");
            Thread.Sleep(200);
            Console.WriteLine("|||          |||      |||        |||   |||        |||       |||  |||  ||| ||     |||  |||             ");
            Thread.Sleep(200);
            Console.WriteLine("|||          |||      |||       |||     |||       |||       |||  |||  |||  ||    |||  |||             ");
            Thread.Sleep(200);
            Console.WriteLine("|||          |||      |||      |||       |||      |||       |||  |||  |||   ||   |||  |||      |||||  ");
            Thread.Sleep(200);
            Console.WriteLine("|||          |||      |||     ||| ||||||| |||     |||       |||  |||  |||    ||  |||  |||      |||    ");
            Thread.Sleep(200);
            Console.WriteLine("|||          |||      |||    |||           |||    |||       |||  |||  |||     || |||  |||      |||    ");
            Thread.Sleep(200);
            Console.WriteLine("||||||||||      ||||||      |||             |||   |||       |||  |||  |||      |||||  |||      |||   ");
            Thread.Sleep(200);
            Console.WriteLine("||||||||||      ||||||     |||               |||  |||||||||||||  |||  |||       ||||  ||||||||||||   ..................");
            Console.ResetColor();
            Item.Initialise_Items();
            Friendly.Initialise_Friendlies();
            Building.Initialise_Buildings();
            Enemy.Initialise_Enemies();
            Thread.Sleep(2500);

        }
        public static void Begin_Adventures()
        {
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your Adventure Begins!");
            Thread.Sleep(2000);
            Console.ResetColor();
        }
        public static void Draw_UI_Method()
        {
            Console.Title = "Text Based RPG";

            for (int i = 0; i < 120; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("");
            for (int i = 0; i < 120; i++)
            {
                Console.Write("_");
            }

        }
        public static void Draw_UI_Stat_start(Player _Player)
        {
            Console.Clear();
            for (int i = 0; i < 120; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("Character Name: " + _Player.Char_Name + "     " + "Class: " + _Player.Char_Class + "    " + "Level: " + _Player.Char_Level + "   " + "Experience: " + _Player.Char_Experience + "/" + Player.Current_Level_Xp);
            Console.WriteLine("Health:" + Math.Round(_Player.Char_Health) + " " + "Stamina:" + _Player.Char_Stamina + " " + "Magicka:" + _Player.Char_Magicka + " " + "Carry Weight:" + _Player.Char_Occupied_Space + "/" + _Player.Char_Capacity + " " + "Player Gold: " + _Player.Char_Gold);
            Console.ResetColor();
            for (int i = 0; i < 120; i++)
            {
                Console.Write("_");
            }
        }
        public static void Draw_UI_Stats(Player _Player, string _Sentence01, string _Sentence02)
        {
            Console.Clear();
            for (int i = 0; i < 120; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("Character Name: " + _Player.Char_Name + "     " + "Class: " + _Player.Char_Class + "    " + "Level: " + _Player.Char_Level + "   " + "Experience: " + _Player.Char_Experience + "/" + Player.Current_Level_Xp);
            Console.WriteLine("Health:" + Math.Round(_Player.Char_Health) + " " + "Stamina:" + _Player.Char_Stamina + " " + "Magicka:" + _Player.Char_Magicka + " " + "Carry Weight:" + _Player.Char_Occupied_Space + "/" + _Player.Char_Capacity + "Player Gold: " + _Player.Char_Gold);
            for (int i = 0; i < 120; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine(_Sentence01);
            Console.WriteLine(_Sentence02);
        }
        public static void Draw_Inventory_Main(Player _player, string _Sentence01, string _Sentence02)
        {
            Console.Clear();
            string Input;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2);
            Console.Write("Getting Inventory......");
            Console.ResetColor();
            Thread.Sleep(randwait.Next(1000, 3000));
            Console.Clear();
            do
            {
                Console.WriteLine("Weapon Loadout [1] | Magic Loadout [2] | View Bag Contents [3] | Exit Inventory [4]");
                Console.Write("Input : ");
                Input = Console.ReadLine();
            } while (Input.All(char.IsDigit) == false);
            switch (Input)
            {
                case "1":

                    Base_Player_Actions.Equipment_Loadout_Main(_player, _Sentence01, _Sentence02, Input);
                    break;
                case "2":
                    Base_Player_Actions.Equipment_Loadout_Main(_player, _Sentence01, _Sentence02 , Input);
                    break;
                case "3":
                    Draw_Inventory_Contents(_player, _Sentence01, _Sentence02);
                    break;
                case "4":
                    Draw_UI_Stats(_player , _Sentence01 , _Sentence02);
                    break;
                default:
                    break;
            }
        }
        public static void Draw_Inventory_Contents(Player _player, string _Sentence01, string _Sentence02)
        {
            Console.Clear();
            string Input;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2);
            Console.Write("Opening Bag......");
            Console.ResetColor();
            Thread.Sleep(randwait.Next(1000, 1500));
            Console.Clear();
            Draw_UI_Stat_start(_player);
            Console.WriteLine("Item          " + "     " + "       Quantity");
            Console.WriteLine("--------------------------------------------");
            foreach (Item item in _player.Char_Inventory)
            {
                Console.WriteLine(item.Item_Name + "  :" + item.Item_Amount);
            }
            do
            {
                Console.Write("Back - 1: ");
                Input = Console.ReadLine();
            } while (Input != "1");
            Console.Clear();
            Draw_Inventory_Main(_player , _Sentence01 , _Sentence02);
        }
        public static void Draw_Inventory_Magic_Loadout(Player _player, string _Sentence01, string _Sentence02, string Input)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2);
            Console.Write("Getting Magical Weapons......");
            Console.ResetColor();
            Thread.Sleep(randwait.Next(1000 , 1500));
            Console.Clear();
            Player_Items_Equipment.Clear();
            foreach (Item item in _player.Char_Inventory)
            {
                switch (item.Item_Type)
                {
                    case 8:
                        Player_Items_Equipment.Add(item);
                        break;
                    case 6:
                        Player_Items_Equipment.Add(item);
                        break;
                    default:
                        break;
                }
            }

        }
        public static void Draw_Inventory_Weapon_Loadout(Player _player, string _Sentence01, string _Sentence02, string Input)
        {
          
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2);
            Console.Write("Getting Physical Weapons......");
            Console.ResetColor();
            Thread.Sleep(randwait.Next(1000, 1500));
            Console.Clear();
            Player_Items_Equipment.Clear();
            foreach (Item item in _player.Char_Inventory)
            {
                if(item.Item_Type >= 5)
                {
                    Player_Items_Equipment.Add(item);
                }
            }
        }
        public static void Draw_UI_Equipment_Items()
        {
            foreach (Item item in Player_Items_Equipment)
            {
                Console.WriteLine("Item: " + item.Item_Name);
            }
        }
        public static void Draw_UI_Shop_Main(Friendly _Merchant , Player _Player)
        {
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2);
            Console.Write("Getting Merchant Wares...........");
            Thread.Sleep(1000);
            Console.Clear();

            for (int i = 0; i < 120 ; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("Character Name: " + _Player.Char_Name + "     " + "Class: " + _Player.Char_Class + "    " + "Level: " + _Player.Char_Level + "   " + "Experience: " + _Player.Char_Experience + "/" + Player.Current_Level_Xp);
            Console.WriteLine("Player Gold: " + _Player.Char_Gold);
            for (int i = 0; i < 120; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("Buy - 1");
            Console.WriteLine("Sell - 2");
            Console.WriteLine("Leave - 3");
        }
        public static void Draw_UI_Shop_Buy(Friendly _merchant, Player _player)
        {
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2);
            Console.Write("Getting Merchant Wares...........");
            Thread.Sleep(1000);
            Console.Clear();

            for (int i = 0; i < 120; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("Character Name: " + _player.Char_Name + "     " + "Class: " + _player.Char_Class + "    " + "Level: " + _player.Char_Level + "   " + "Experience: " + _player.Char_Experience + "/" + Player.Current_Level_Xp);
            Console.WriteLine("Player Gold: " + _player.Char_Gold + " " + "Merchant Gold:" + _merchant.Shop_Gold);
            for (int i = 0; i < 120; i++)
            {
                Console.Write("_");
            }
            foreach (Item item in _merchant.NPC_Inventory)
            {
                Console.WriteLine("Item: " + item.Item_Name + "     Price: " + item.Item_Buy + " Gold Coins");
            }
        }
        public static void Draw_UI_Shop_Sell(Player _player, Friendly _merchant)
        {
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2);
            Console.Write("Getting Player Items...........");
            Thread.Sleep(1000);
            Console.Clear();
            for (int i = 0; i < 120; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("Character Name: " + _player.Char_Name + "     " + "Class: " + _player.Char_Class + "    " + "Level: " + _player.Char_Level + "   " + "Experience: " + _player.Char_Experience + "/" + Player.Current_Level_Xp);
            Console.WriteLine("Player Gold: " + _player.Char_Gold + " " +  "Merchant Gold:" + _merchant.Shop_Gold);
            for (int i = 0; i < 120; i++)
            {
                Console.Write("_");
            }
            foreach (Item item in _player.Char_Inventory)
            {
                Console.WriteLine("Item: " + item.Item_Name + "     Sell Price: " + item.Item_Buy + " Gold Coins");
            }
        }
    }
}
