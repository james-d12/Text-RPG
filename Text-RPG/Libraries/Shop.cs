using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Libraries.Item_Library;
using Libraries.NPC_Library;
using Libraries.Player_Library;

namespace Libraries
{
    public class Shop
    {
        private static List<string> Item_Names = new List<string>();

        public static void Shop_Handler(Player _player, Friendly _Merchant, string sentence01, string sentence02)
        {
            Shop_Get_Items(_Merchant);
            string choice;
            List<string> Validinput = new List<string>
            {
                "Yes",
                "yes",
                "YES",
                "No",
                "no",
                "NO"
            };
            do
            {
                Console.WriteLine("Do you want to see their wares?");
                choice = Console.ReadLine();
            } while (Validinput.Contains(choice) == false);

            if (choice == "Yes" || choice == "yes" || choice == "YES")
            {
                Shop_Show_Items(_player, _Merchant, sentence01, sentence02);
            }
            else if (choice == "NO" || choice == "No" || choice == "no")
            {

            }
        }
        public static void Shop_Get_Items(Friendly _Merchant)
        {
            foreach (Item item in _Merchant.NPC_Inventory)
            {
                Item_Names.Add(item.Item_Name);
            }
        }
        public static void Shop_Show_Items(Player _player, Friendly _Merchant, string sentence01, string sentence02)
        {
            Draw_UI.Draw_UI_Shop_Main(_Merchant, _player);
            string Input;
            do
            {
                Console.Write("Input: ");
                Input = Console.ReadLine();
            } while (Input.All(char.IsDigit) == false);
            switch (Input)
            {
                case "1":
                    Shop_Purchase(_player, _Merchant, sentence01, sentence02);
                    break;
                case "2":
                    Shop_Sell(_Merchant, _player, sentence01, sentence02);
                    break;
                case "3":
                    break;
            }
        }
        public static void Shop_Purchase(Player _player, Friendly _Merchant, string sentence01, string sentence02)
        {
            int x = 0;
            List<string> item_names = new List<string>();
            string itemchoice;
            Console.Clear();
            Draw_UI.Draw_UI_Shop_Buy(_Merchant, _player);
            Console.WriteLine("Back - (Type 'back')");
            while (x < _Merchant.NPC_Inventory.Count())
            {
               do
               {
                    Console.Write("Purchase Item:  ");
                    itemchoice = Console.ReadLine();
               } while (itemchoice.Any(char.IsLetter) == false);
               if (itemchoice == "Back" || itemchoice == "back" || itemchoice == "BACK")
               {
                    Shop_Show_Items(_player, _Merchant, sentence01, sentence02);
               }
               else
               {
                    foreach(Item item in _Merchant.NPC_Inventory)
                    {
                        item_names.Add(item.Item_Name);
                    }
                    if (item_names.Contains(itemchoice))
                    {
                        foreach (Item item in _Merchant.NPC_Inventory)
                        {
                            if (itemchoice == item.Item_Name)
                            {
                                x = x + 1;
                                if (_player.Char_Gold >= item.Item_Buy)
                                {
                                    Console.WriteLine("You have purchased " + item.Item_Name + " for " + item.Item_Buy + " Gold coins");
                                    Remove_Merchant_Items(_Merchant, itemchoice);
                                    _player.Char_Gold -= item.Item_Buy;
                                    _Merchant.Shop_Gold += item.Item_Buy;
                                }
                                else
                                {
                                    Console.WriteLine("You do not have enough gold.");
                                }
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
        public static void Shop_Sell(Friendly _Merchant, Player _player, string sentence01, string sentence02)
        {
            int x = 0;
            List<string> item_names = new List<string>();
            string itemchoice;
            Console.Clear();
            Draw_UI.Draw_UI_Shop_Sell(_player, _Merchant);
            Console.WriteLine("Back - (Type 'back')");
            while (x < _player.Char_Inventory.Count())
            {
                do
                {
                    Console.Write("Sell Item:  ");
                    itemchoice = Console.ReadLine();
                } while (itemchoice.Any(char.IsLetter) == false);
                if (itemchoice == "Back" || itemchoice == "back" || itemchoice == "BACK")
                {
                    Shop_Show_Items(_player, _Merchant, sentence01, sentence02);
                }
                else
                {
                    foreach (Item item in _player.Char_Inventory)
                    {
                        item_names.Add(item.Item_Name);
                    }
                    if (item_names.Contains(itemchoice))
                    {
                        foreach (Item item in _player.Char_Inventory)
                        {
                            if (itemchoice == item.Item_Name)
                            {
                                x = x + 1;
                                if (_Merchant.Shop_Gold >= item.Item_Buy)
                                {
                                    Console.WriteLine("You have Sold " + item.Item_Name + " for " + item.Item_Buy + " Gold coins");
                                    Remove_Player_Items(_player, itemchoice);
                                    _player.Char_Gold += item.Item_Buy;
                                    _Merchant.Shop_Gold -= item.Item_Buy;
                                }
                                else
                                {
                                    Console.WriteLine("Merchant does not have enough gold.");
                                }
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
        public static void Remove_Merchant_Items(Friendly _Merchant, string itemchoice)
        {
            List<object> items = new List<object>();
            foreach (Item item in _Merchant.NPC_Inventory)
            {
                if (item.Item_Name != itemchoice)
                {
                    items.Add(item);
                }
            }
            _Merchant.NPC_Inventory = items;
        }
        public static void Remove_Player_Items(Player _Player, string itemchoice)
        {
            List<object> items = new List<object>();
            foreach (Item item in _Player.Char_Inventory)
            {
                if(item.Item_Name != itemchoice)
                {
                    items.Add(item);
                }
            }
            _Player.Char_Inventory = items;
        }
    }
}
