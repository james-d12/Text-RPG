using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using Libraries.NPC_Library;
using Libraries.Player_Library;
using Libraries.Item_Library;

namespace Libraries
{
    public class Save
    {
        public static void Save_Character(Player _player)
        {
            string filepath = @"C:\Users\James Durban\Documents\Real Documents\Coding\C#\Main\Save\Character_Save.txt";

            Console.WriteLine("Saving......");
            Thread.Sleep(2000);
            using (StreamWriter Save_Character_SW = new StreamWriter(filepath))
            {
                Save_Character_SW.WriteLine(_player.Char_Capacity);
                Save_Character_SW.WriteLine(_player.Char_Class);
                Save_Character_SW.WriteLine(_player.Char_Experience);
                Save_Character_SW.WriteLine(_player.Char_Gold);
                Save_Character_SW.WriteLine(_player.Char_Health);
                foreach (Item item in _player.Char_Inventory)
                {
                    Save_Character_SW.Write(item.Item_Name + ",");
                }
                Save_Character_SW.WriteLine(_player.Char_Level);
                Save_Character_SW.WriteLine(_player.Char_Magicka);
                Save_Character_SW.WriteLine(_player.Char_Name);
                Save_Character_SW.WriteLine(_player.Char_Occupied_Space);
                Save_Character_SW.WriteLine(_player.Char_Stamina);
                Save_Character_SW.WriteLine(_player.Char_Total_Damage);
            }
        }
    }
}
