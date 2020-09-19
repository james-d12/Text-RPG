using System;
using System.Collections.Generic;
using System.Text;
using Libraries.Player_Library;
using Libraries.NPC_Library;
using Libraries.Buildings;

namespace Libraries.Story
{
    public class Forest
    {
        public static void Forest_Start(Player _player)
        {
            string sentence01;
            string sentence02;
            Random Rand = new Random();
            Enemy _enemy;

            Draw_UI.Draw_UI_Stat_start(_player);
            _enemy = Enemy.Hound_List[Rand.Next(0, 2)];
            sentence01 = ("You wake up from a cold sleep, only to hear the howling screams ");
            sentence02 = ("of " + _enemy.Enemy_Name + " from behind a tree.");
            Console.WriteLine(sentence01);
            Console.WriteLine(sentence02);
            Base_Player_Actions.Action_Handler(_player, _enemy, sentence01, sentence02);

            Draw_UI.Draw_UI_Stat_start(_player);
            _enemy = Enemy.Other_Animal_List[1];
            sentence01 = ("After Battling " + _enemy.Enemy_Name +  " you manage to win however as you recover,");
            sentence02 = ("you see standing in front of you a terrifying bear, preparing to attack.");
            Console.WriteLine(sentence01);
            Console.WriteLine(sentence02);
            Base_Player_Actions.Action_Handler(_player, _enemy, sentence01, sentence02);

            Friendly _Friendly = Friendly.Merchant_List[0];
            Console.Clear();
            Draw_UI.Draw_UI_Stat_start(_player);
            sentence01 = ("After battling with the bear, you manage to overcome it. You rest, but see on the dirt path ahead a figure.");
            sentence02 = ("He approaches you, you then realise that it is a shopkeeper selling his wares.");
            Console.WriteLine(sentence01);
            Console.WriteLine(sentence02);
            Shop.Shop_Handler(_player, _Friendly, sentence01, sentence02);

            Building building = Building.Easy_Buildings[Rand.Next(1, Building.Easy_Buildings.Count)];
            sentence01 = "You see a nearby " + building.Building_Name  + ", and night is approaching.Do you ";
            sentence02 = "want to search the " + building.Building_Name + "?";
            Draw_UI.Draw_UI_Stats(_player, sentence01, sentence02);
            Base_Player_Actions.Search_Building(_player, building);
            

            Console.ReadKey();

        }
    }
}
