using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Libraries.Story;
using Libraries.Item_Library;

namespace Libraries.Player_Library
{
    public class Player : Base_Player
    {
        public static void _Player(string Character_Name, string Character_Class)
        {
            Player _Player = new Player();
            switch (Character_Class)
            {
                case "Mage":
                    _Player.Char_Name = Character_Name;
                    _Player.Char_Class = "Mage";
                    _Player.Char_Experience = 0;
                    _Player.Char_Level = 1;
                    _Player.Char_Gold = 25;
                    _Player.Char_Inventory = (Item.Mage_List);
                    _Player.Char_Equipped_Items = null;
                    _Player.Char_Capacity = 100;
                    _Player.Char_Health = 75;
                    _Player.Char_Total_Health = 75;
                    _Player.Char_Magicka = 200;
                    _Player.Char_Total_Magicka = 200;
                    _Player.Char_Stamina = 50;
                    _Player.Char_Total_Stamina = 50;
                    Add_Weight(_Player);
                    break;
                case "Warrior":
                    _Player.Char_Name = Character_Name;
                    _Player.Char_Class = "Warrior";
                    _Player.Char_Capacity = 200;
                    _Player.Char_Equipped_Items = null;
                    _Player.Char_Experience = 0;
                    _Player.Char_Level = 1;
                    _Player.Char_Gold = 1000;
                    _Player.Char_Health = 150;
                    _Player.Char_Total_Health = 150;
                    _Player.Char_Magicka = 75;
                    _Player.Char_Total_Magicka = 75;
                    _Player.Char_Stamina = 100;
                    _Player.Char_Inventory = (Item.Warrior_List);
                    Add_Weight(_Player);
                    break;
                case "Thief":
                    _Player.Char_Name = Character_Name;
                    _Player.Char_Class = "Thief";
                    _Player.Char_Capacity = 150;
                    _Player.Char_Equipped_Items = null;
                    _Player.Char_Experience = 0;
                    _Player.Char_Level = 1;
                    _Player.Char_Gold = 25;
                    _Player.Char_Health = 125;
                    _Player.Char_Total_Health = 125;
                    _Player.Char_Magicka = 50;
                    _Player.Char_Total_Magicka = 50;
                    _Player.Char_Stamina = 200;
                    _Player.Char_Total_Stamina = 200;
                    _Player.Char_Inventory = (Item.Thief_List);
                    Add_Weight(_Player);
                    break;

            }
            Draw_UI.Begin_Adventures();
            Forest.Forest_Start(_Player);   
        }
    }
}
