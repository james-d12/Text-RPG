using System;
using System.Collections.Generic;
using System.Text;

namespace Libraries.NPC_Library
{
    public class Friendly : Base_Friendly
    {

        public static List<Friendly> Merchant_List = new List<Friendly>();

        public static void Initialise_Friendlies()
        {
            New_Friendlies();
        }
        public static void New_Friendlies()
        {
            Friendly WanderingMerchant = new Friendly();
            Friendly BlackSmith = new Friendly();
            Friendly Clothier = new Friendly();
            Friendly Wizard = new Friendly();

            WanderingMerchant.NPC_Name = "Wandering Merchant";
            WanderingMerchant.NPC_Health = 200;
            WanderingMerchant.NPC_Magicka = 100;
            WanderingMerchant.Shop_Gold = 500;
            WanderingMerchant.NPC_Type = 1;
            WanderingMerchant.NPC_Inventory = Item_Library.Item.Merchant_List_01;
            
            Merchant_List.Add(WanderingMerchant);
        }
    }
}
