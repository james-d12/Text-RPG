using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Libraries.Item_Library
{
    public class Item : Base_Item
    {

        private static Random randitem = new Random();

        //enemy list
        public static List<object> Basic_Enemy_Equipment_List = new List<object>();
        public static List<object> Animal_Equipment_List = new List<object>();
        public static List<object> Fire_Wizard_Equipment_List = new List<object>();
        public static List<object> Frost_Wizard_Equipment_List = new List<object>();
        public static List<object> Spark_Wizard_Equipment_List = new List<object>();

        //class lists
        public static List<object> Mage_List = new List<object>();
        public static List<object> Warrior_List = new List<object>();
        public static List<object> Thief_List = new List<object>();

        //building lists
        public static List<object> Basic_Building_List = new List<object>();
        public static List<object> Advanced_Building_List = new List<object>();

        //Friendlies Inventores
        public static List<object> Merchant_List_01 = new List<object>();

        //specific item lists
        public static List<object> Swords_List = new List<object>();
        public static List<object> Axes_List = new List<object>();
        public static List<object> Hammer_List = new List<object>();
        public static List<object> Greatsword_List = new List<object>();
        public static List<object> Warhammer_List = new List<object>();
        public static List<object> Crossbow_List = new List<object>();
        public static List<object> Bow_List = new List<object>();
        public static List<object> Light_Armor_List = new List<object>();
        public static List<object> Heavy_Armor_List = new List<object>();
        public static List<object> Spells_List = new List<object>();
        public static List<object> Staves_List = new List<object>();
        public static List<object> Valuables_List = new List<object>();
        public static void Initialise_Items()
        {
            Items();
        }
        public static void Items()
        {
            //swords
            Item CopperSword = new Item();
            Item IronSword = new Item();
            Item BronzeSword = new Item();
            Item SteelSword = new Item();

            //axes
            Item CopperAxe = new Item();
            Item IronAxe = new Item();
            Item BronzeAxe = new Item();
            Item SteelAxe = new Item();

            //greatswords
            Item CopperGreatsword = new Item();
            Item IronGreatsword = new Item();
            Item BronzeGreatsword = new Item();
            Item SteelGreatsword = new Item();

            //warhammers
            Item CopperWarhammer = new Item();
            Item IronWarhammer = new Item();
            Item BronzeWarhammer = new Item();
            Item SteelWarhammer = new Item();

            //Hammer
            Item CopperHammer = new Item();
            Item IronHammer = new Item();
            Item BronzeHammer = new Item();
            Item SteelHammer = new Item();

            //bows
            Item CopperBow = new Item();
            Item IronBow = new Item();
            Item BronzeBow = new Item();
            Item SteelBow = new Item();

            Item CopperCrossbow = new Item();
            Item BronzeCrossbow = new Item();
            Item IronCrossbow = new Item();
            Item SteelCrossbow = new Item();

            //arrows
            Item CopperArrow = new Item();
            Item IronArrow = new Item();
            Item BronzeArrow = new Item();
            Item SteelArrow = new Item();

            //Light Armor
            Item HideArmor = new Item();
            Item LeatherArmor = new Item();

            //Heavy Armor
            Item CopperArmor = new Item();
            Item IronArmor = new Item();
            Item BronzeArmor = new Item();
            Item SteelArmor = new Item();

            //Potions
            Item Healing_1 = new Item();
            Item Healing_2 = new Item();
            Item Magicka_1 = new Item();
            Item Magicka_2 = new Item();
            Item Stamina_1 = new Item();
            Item Stamina_2 = new Item();

            //Gems and Valuables
            Item Amethyst_Gem = new Item();
            Item Sapphire_Gem = new Item();
            Item Diamond_Gem = new Item();

            //spells
            Item Fire_01 = new Item();
            Item Fire_02 = new Item();
            Item Frost_01 = new Item();
            Item Frost_02 = new Item();
            Item Spark_01 = new Item();
            Item Spark_02 = new Item();

            //staves
            Item FireStave_01 = new Item();
            Item FireStave_02 = new Item();
            Item FrostStave_01 = new Item();
            Item FrostStave_02 = new Item();
            Item SparkStave_01 = new Item();
            Item SparkStave_02 = new Item();

            //robes
            Item MageRobes = new Item();

            CopperSword.Item_Name = "A Copper Sword";
            CopperSword.Item_Buy = 10;
            CopperSword.Item_Sell = 3;
            CopperSword.Item_Weight = 4;
            CopperSword.Item_Type = 1;
            CopperSword.Item_Damage = 3;
            CopperSword.Item_Stamina_Cost = 5;
            CopperSword.Item_Amount = 1;

            BronzeSword.Item_Name = "A Bronze Sword";
            BronzeSword.Item_Buy = 14;
            BronzeSword.Item_Sell = 5;
            BronzeSword.Item_Weight = 5;
            BronzeSword.Item_Type = 1;
            BronzeSword.Item_Damage = 5;
            BronzeSword.Item_Stamina_Cost = 5;
            BronzeSword.Item_Amount = 1;

            IronSword.Item_Name = "An Iron Sword";
            IronSword.Item_Buy = 18;
            IronSword.Item_Sell = 8;
            IronSword.Item_Weight = 8;
            IronSword.Item_Type = 1;
            IronSword.Item_Damage = 7;
            IronSword.Item_Stamina_Cost = 5;
            IronSword.Item_Amount = 1;

            SteelSword.Item_Name = "A Steel Sword";
            SteelSword.Item_Buy = 25;
            SteelSword.Item_Sell = 10;
            SteelSword.Item_Weight = 10;
            SteelSword.Item_Type = 1;
            SteelSword.Item_Damage = 11;
            SteelSword.Item_Stamina_Cost = 5;
            SteelSword.Item_Amount = 1;

            CopperAxe.Item_Name = "A Copper Axe";
            CopperAxe.Item_Buy = 13;
            CopperAxe.Item_Sell = 4;
            CopperAxe.Item_Weight = 6;
            CopperAxe.Item_Type = 1;
            CopperAxe.Item_Damage = 4;
            CopperAxe.Item_Stamina_Cost = 8;
            CopperAxe.Item_Amount = 1;

            BronzeAxe.Item_Name = "A Bronze Axe";
            BronzeAxe.Item_Buy = 16;
            BronzeAxe.Item_Sell = 6;
            BronzeAxe.Item_Weight = 8;
            BronzeAxe.Item_Type = 1;
            BronzeAxe.Item_Damage = 7;
            BronzeAxe.Item_Stamina_Cost = 8;
            BronzeAxe.Item_Amount = 1;

            IronAxe.Item_Name = "An Iron Axe";
            IronAxe.Item_Buy = 23;
            IronAxe.Item_Sell = 11;
            IronAxe.Item_Weight = 9;
            IronAxe.Item_Type = 1;
            IronAxe.Item_Damage = 13;
            IronAxe.Item_Stamina_Cost = 8;
            IronAxe.Item_Amount = 1;

            SteelAxe.Item_Name = "A Steel Axe";
            SteelAxe.Item_Buy = 30;
            SteelAxe.Item_Sell = 13;
            SteelAxe.Item_Weight = 10;
            SteelAxe.Item_Type = 1;
            SteelAxe.Item_Damage = 14;
            SteelAxe.Item_Stamina_Cost = 8;
            SteelAxe.Item_Amount = 1;

            CopperHammer.Item_Name = "A Copper Hammer";
            CopperHammer.Item_Buy = 15;
            CopperHammer.Item_Sell = 6;
            CopperHammer.Item_Weight = 9;
            CopperHammer.Item_Type = 1;
            CopperHammer.Item_Damage = 7;
            CopperHammer.Item_Stamina_Cost = 11;
            CopperHammer.Item_Amount = 1;

            BronzeHammer.Item_Name = "A Bronze Hammer";
            BronzeHammer.Item_Buy = 19;
            BronzeHammer.Item_Sell = 9;
            BronzeHammer.Item_Weight = 9;
            BronzeHammer.Item_Type = 1;
            BronzeHammer.Item_Damage = 11;
            BronzeHammer.Item_Stamina_Cost = 11;
            BronzeHammer.Item_Amount = 1;

            IronHammer.Item_Name = "An Iron Hammer";
            IronHammer.Item_Buy = 25;
            IronHammer.Item_Sell = 13;
            IronHammer.Item_Weight = 9;
            IronHammer.Item_Type = 1;
            IronHammer.Item_Damage = 16;
            IronHammer.Item_Stamina_Cost = 11;
            IronHammer.Item_Amount = 1;

            SteelHammer.Item_Name = "A Steel Hammer";
            SteelHammer.Item_Buy = 29;
            SteelHammer.Item_Sell = 17;
            SteelHammer.Item_Weight = 10;
            SteelHammer.Item_Type = 1;
            SteelHammer.Item_Damage = 16;
            SteelHammer.Item_Stamina_Cost = 11;
            SteelHammer.Item_Amount = 1;

            CopperGreatsword.Item_Name = "A Copper Greatsword";
            CopperGreatsword.Item_Buy = 16;
            CopperGreatsword.Item_Sell = 8;
            CopperGreatsword.Item_Weight = 12;
            CopperGreatsword.Item_Type = 1;
            CopperGreatsword.Item_Damage = 8;
            CopperGreatsword.Item_Stamina_Cost = 13;
            CopperGreatsword.Item_Amount = 1;

            BronzeGreatsword.Item_Name = "A Bronze Greatsword";
            BronzeGreatsword.Item_Buy = 19;
            BronzeGreatsword.Item_Sell = 10;
            BronzeGreatsword.Item_Weight = 13;
            BronzeGreatsword.Item_Type = 1;
            BronzeGreatsword.Item_Damage = 11;
            BronzeGreatsword.Item_Stamina_Cost = 13;
            BronzeGreatsword.Item_Amount = 1;

            IronGreatsword.Item_Name = "An Iron Greatsword";
            IronGreatsword.Item_Buy = 25;
            IronGreatsword.Item_Sell = 15;
            IronGreatsword.Item_Weight = 13;
            IronGreatsword.Item_Type = 1;
            IronGreatsword.Item_Damage = 14;
            IronGreatsword.Item_Stamina_Cost = 13;
            IronGreatsword.Item_Amount = 1;

            SteelGreatsword.Item_Name = "A Steel Greatsword";
            SteelGreatsword.Item_Buy = 34;
            SteelGreatsword.Item_Sell = 17;
            SteelGreatsword.Item_Weight = 14;
            SteelGreatsword.Item_Type = 1;
            SteelGreatsword.Item_Damage = 16;
            SteelGreatsword.Item_Stamina_Cost = 13;
            SteelGreatsword.Item_Amount = 1;

            CopperWarhammer.Item_Name = "A Copper Warhammer";
            CopperWarhammer.Item_Buy = 19;
            CopperWarhammer.Item_Sell = 10;
            CopperWarhammer.Item_Weight = 20;
            CopperWarhammer.Item_Type = 1;
            CopperWarhammer.Item_Damage = 13;
            CopperWarhammer.Item_Stamina_Cost = 19;
            CopperWarhammer.Item_Amount = 1;

            BronzeWarhammer.Item_Name = "A Bronze Warhammer";
            BronzeWarhammer.Item_Buy = 24;
            BronzeWarhammer.Item_Sell = 14;
            BronzeWarhammer.Item_Weight = 20;
            BronzeWarhammer.Item_Type = 1;
            BronzeWarhammer.Item_Damage = 15;
            BronzeWarhammer.Item_Stamina_Cost = 19;
            BronzeWarhammer.Item_Amount = 1;

            IronWarhammer.Item_Name = "An Iron Warhammer";
            IronWarhammer.Item_Buy = 31;
            IronWarhammer.Item_Sell = 17;
            IronWarhammer.Item_Weight = 20;
            IronWarhammer.Item_Type = 1;
            IronWarhammer.Item_Damage = 17;
            IronWarhammer.Item_Stamina_Cost = 19;
            IronWarhammer.Item_Amount = 1;

            SteelWarhammer.Item_Name = "A Steel Warhammer";
            SteelWarhammer.Item_Buy = 41;
            SteelWarhammer.Item_Sell = 19;
            SteelWarhammer.Item_Weight = 20;
            SteelWarhammer.Item_Type = 1;
            SteelWarhammer.Item_Damage = 20;
            SteelWarhammer.Item_Stamina_Cost = 19;
            SteelWarhammer.Item_Amount = 1;

            CopperBow.Item_Name = "A Copper Bow";
            CopperBow.Item_Buy = 8;
            CopperBow.Item_Sell = 4;
            CopperBow.Item_Weight = 6;
            CopperBow.Item_Type = 2;
            CopperBow.Item_Damage = 6;
            CopperBow.Item_Stamina_Cost = 5;
            CopperBow.Item_Amount = 1;

            BronzeBow.Item_Name = "A Bronze Bow";
            BronzeBow.Item_Buy = 11;
            BronzeBow.Item_Sell = 6;
            BronzeBow.Item_Weight = 6;
            BronzeBow.Item_Type = 2;
            BronzeBow.Item_Damage = 9;
            BronzeBow.Item_Stamina_Cost = 5;
            BronzeBow.Item_Amount = 1;

            IronBow.Item_Name = "An Iron Bow";
            IronBow.Item_Buy = 14;
            IronBow.Item_Sell = 7;
            IronBow.Item_Weight = 8;
            IronBow.Item_Type = 2;
            IronBow.Item_Damage = 13;
            IronBow.Item_Stamina_Cost = 5;
            IronBow.Item_Amount = 1;

            SteelBow.Item_Name = "A Steel Bow";
            SteelBow.Item_Buy = 17;
            SteelBow.Item_Sell = 11;
            SteelBow.Item_Weight = 8;
            SteelBow.Item_Type = 2;
            SteelBow.Item_Damage = 15;
            SteelBow.Item_Stamina_Cost = 5;
            SteelBow.Item_Amount = 1;

            CopperCrossbow.Item_Name = "A Copper Crossbow";
            CopperCrossbow.Item_Buy = 12;
            CopperCrossbow.Item_Sell = 6;
            CopperCrossbow.Item_Weight = 10;
            CopperCrossbow.Item_Type = 2;
            CopperCrossbow.Item_Damage = 8;
            CopperCrossbow.Item_Stamina_Cost = 8;
            CopperCrossbow.Item_Amount = 1;

            BronzeCrossbow.Item_Name = "A Bronze Crossbow";
            BronzeCrossbow.Item_Buy = 14;
            BronzeCrossbow.Item_Sell = 10;
            BronzeCrossbow.Item_Weight = 10;
            BronzeCrossbow.Item_Type = 2;
            BronzeCrossbow.Item_Damage = 11;
            BronzeCrossbow.Item_Stamina_Cost = 8;
            BronzeCrossbow.Item_Amount = 1;

            IronCrossbow.Item_Name = "An Iron Crossbow";
            IronCrossbow.Item_Buy = 16;
            IronCrossbow.Item_Sell = 9;
            IronCrossbow.Item_Weight = 10;
            IronCrossbow.Item_Type = 2;
            IronCrossbow.Item_Damage = 15;
            IronCrossbow.Item_Stamina_Cost = 9;
            IronCrossbow.Item_Amount = 1;

            SteelCrossbow.Item_Name = "A Steel Crossbow";
            SteelCrossbow.Item_Buy = 24;
            SteelCrossbow.Item_Sell = 14;
            SteelCrossbow.Item_Weight = 10;
            SteelCrossbow.Item_Type = 2;
            SteelCrossbow.Item_Damage = 17;
            SteelCrossbow.Item_Stamina_Cost = 8;
            SteelCrossbow.Item_Amount = 1;

            CopperArrow.Item_Name = "A Copper Arrow";
            CopperArrow.Item_Damage = 1;
            CopperArrow.Item_Buy = 2;
            CopperArrow.Item_Sell = 1;
            CopperArrow.Item_Type = 3;
            CopperArrow.Item_Amount = 1;

            BronzeArrow.Item_Name = "A Bronze Arrow";
            BronzeArrow.Item_Damage = 3;
            BronzeArrow.Item_Buy = 4;
            BronzeArrow.Item_Sell = 2;
            BronzeArrow.Item_Type = 3;
            BronzeArrow.Item_Amount = 1;

            IronArrow.Item_Name = "AnIron Arrow";
            IronArrow.Item_Damage = 6;
            IronArrow.Item_Buy = 5;
            IronArrow.Item_Sell = 3;
            IronArrow.Item_Type = 3;
            IronArrow.Item_Amount = 1;

            SteelArrow.Item_Name = "A Steel Arrow";
            SteelArrow.Item_Damage = 7;
            SteelArrow.Item_Buy = 8;
            SteelArrow.Item_Sell = 4;
            SteelArrow.Item_Type = 3;
            SteelArrow.Item_Amount = 1;

            HideArmor.Item_Name = "Hide Armor";
            HideArmor.Item_Buy = 25;
            HideArmor.Item_Sell = 10;
            HideArmor.Item_Weight = 10;
            HideArmor.Item_Type = 4;
            HideArmor.Item_Armor_Rating = 8;
            HideArmor.Item_Amount = 1;

            LeatherArmor.Item_Name = "Leather Armor";
            LeatherArmor.Item_Buy = 35;
            LeatherArmor.Item_Sell = 15;
            LeatherArmor.Item_Type = 4;
            LeatherArmor.Item_Weight = 15;
            LeatherArmor.Item_Armor_Rating = 15;
            LeatherArmor.Item_Amount = 1;

            CopperArmor.Item_Name = "Copper Armor";
            CopperArmor.Item_Buy = 45;
            CopperArmor.Item_Sell = 20;
            CopperArmor.Item_Weight = 25;
            CopperArmor.Item_Type = 5;
            CopperArmor.Item_Armor_Rating = 20;
            CopperArmor.Item_Amount = 1;

            BronzeArmor.Item_Name = "Bronze Armor";
            BronzeArmor.Item_Buy = 55;
            BronzeArmor.Item_Sell = 24;
            BronzeArmor.Item_Weight = 35;
            BronzeArmor.Item_Type = 5;
            BronzeArmor.Item_Armor_Rating = 25;
            BronzeArmor.Item_Amount = 1;


            IronArmor.Item_Name = "Iron Armor";
            IronArmor.Item_Buy = 55;
            IronArmor.Item_Weight = 40;
            IronArmor.Item_Sell = 30;
            IronArmor.Item_Type = 5;
            IronArmor.Item_Armor_Rating = 35;
            IronArmor.Item_Amount = 1;

            SteelArmor.Item_Name = "Steel Armor";
            SteelArmor.Item_Buy = 85;
            SteelArmor.Item_Sell = 45;
            SteelArmor.Item_Weight = 50;
            SteelArmor.Item_Type = 5;
            SteelArmor.Item_Armor_Rating = 50;
            SteelArmor.Item_Amount = 1;

            Healing_1.Item_Name = "A Basic Healing Potion";
            Healing_1.Item_Buy = 10;
            Healing_1.Item_Sell = 5;
            Healing_1.Item_Type = 6;
            Healing_1.Item_Weight = 1;
            Healing_1.Item_Restore = 25;
            Healing_1.Item_Amount = 1;

            Healing_2.Item_Name = "An Advanced Healing Potion";
            Healing_2.Item_Buy = 30;
            Healing_2.Item_Sell = 10;
            Healing_2.Item_Type = 6;
            Healing_2.Item_Weight = 2;
            Healing_2.Item_Restore = 50;
            Healing_2.Item_Amount = 1;


            Stamina_1.Item_Name = "A Basic Stamina Potion";
            Stamina_1.Item_Buy = 10;
            Stamina_1.Item_Sell = 5;
            Stamina_1.Item_Type = 6;
            Stamina_1.Item_Weight = 1;
            Stamina_1.Item_Restore = 25;
            Stamina_1.Item_Amount = 1;

            Stamina_2.Item_Name = "An Advanced Stamina Potion";
            Stamina_2.Item_Buy = 30;
            Stamina_2.Item_Sell = 10;
            Stamina_2.Item_Type = 6;
            Stamina_2.Item_Weight = 2;
            Stamina_2.Item_Restore = 50;
            Stamina_2.Item_Amount = 1;

            Magicka_1.Item_Name = "A Basic Magicka Potion";
            Magicka_1.Item_Buy = 10;
            Magicka_1.Item_Sell = 5;
            Magicka_1.Item_Type = 6;
            Magicka_1.Item_Weight = 1;
            Magicka_1.Item_Restore = 25;
            Magicka_1.Item_Amount = 1;

            Magicka_2.Item_Name = "An Advanced Magicka Potion";
            Magicka_2.Item_Buy = 30;
            Magicka_2.Item_Sell = 10;
            Magicka_2.Item_Type = 6;
            Magicka_2.Item_Weight = 2;
            Magicka_2.Item_Restore = 50;
            Magicka_2.Item_Amount = 1;

            Amethyst_Gem.Item_Name = "An Amethyst Gem";
            Amethyst_Gem.Item_Buy = 25;
            Amethyst_Gem.Item_Sell = 5;
            Amethyst_Gem.Item_Weight = 2;
            Amethyst_Gem.Item_Type = 7;
            Amethyst_Gem.Item_Amount = 1;

            Sapphire_Gem.Item_Name = "A Sapphire Gem";
            Sapphire_Gem.Item_Buy = 45;
            Sapphire_Gem.Item_Sell = 15;
            Sapphire_Gem.Item_Weight = 4;
            Sapphire_Gem.Item_Type = 7;
            Sapphire_Gem.Item_Amount = 1;

            Diamond_Gem.Item_Name = "A Diamond Gem";
            Diamond_Gem.Item_Buy = 100;
            Diamond_Gem.Item_Sell = 45;
            Diamond_Gem.Item_Weight = 8;
            Diamond_Gem.Item_Type = 7;
            Diamond_Gem.Item_Amount = 1;

            Fire_01.Item_Name = "Fire Gout";
            Fire_01.Item_Magicka_Cost = 8;
            Fire_01.Item_Damage = 2;
            Fire_01.Item_Buy = 10;
            Fire_01.Item_Sell = 5;
            Fire_01.Item_Type = 8;
            Fire_01.Item_Amount = 1;

            Fire_02.Item_Name = "Fire Blast";
            Fire_02.Item_Magicka_Cost = 15;
            Fire_02.Item_Damage = 10;
            Fire_02.Item_Type = 8;
            Fire_02.Item_Buy = 25;
            Fire_02.Item_Sell = 12;
            Fire_02.Item_Amount = 1;

            Frost_01.Item_Name = "Frost Gout";
            Frost_01.Item_Magicka_Cost = 11;
            Frost_01.Item_Damage = 3;
            Frost_01.Item_Type = 8;
            Frost_01.Item_Buy = 12;
            Frost_01.Item_Sell = 6;
            Frost_01.Item_Amount = 1;

            Frost_02.Item_Name = "Frost Blast";
            Frost_02.Item_Magicka_Cost = 17;
            Frost_02.Item_Damage = 12;
            Frost_02.Item_Type = 8;
            Frost_02.Item_Buy = 30;
            Frost_02.Item_Sell = 15;
            Frost_02.Item_Amount = 1;

            Spark_01.Item_Name = "Spark Gout";
            Spark_01.Item_Magicka_Cost = 13;
            Spark_01.Item_Damage = 5;
            Spark_01.Item_Type = 8;
            Spark_01.Item_Buy = 15;
            Spark_01.Item_Sell = 8;
            Spark_01.Item_Amount = 1;

            Spark_02.Item_Name = "Spark Blast";
            Spark_02.Item_Magicka_Cost = 18;
            Spark_02.Item_Damage = 18;
            Spark_02.Item_Type = 8;
            Frost_02.Item_Buy = 50;
            Frost_02.Item_Sell = 20;
            Spark_02.Item_Amount = 1;

            //add staves.
            FireStave_01.Item_Name = "Fire Gout Stave";
            FireStave_01.Item_Type = 8;
            FireStave_01.Item_Charge = 50;
            FireStave_01.Item_Charge_Use = 2;
            FireStave_01.Item_Damage = 5;
            FireStave_01.Item_Weight = 10;
            FireStave_01.Item_Buy = 10;
            FireStave_01.Item_Sell = 5;
            FireStave_01.Item_Amount = 1;

            //add staves.
            FireStave_02.Item_Name = "Fire Blast Stave";
            FireStave_02.Item_Type = 8;
            FireStave_02.Item_Charge = 75;
            FireStave_02.Item_Charge_Use = 5;
            FireStave_02.Item_Damage = 10;
            FireStave_02.Item_Weight = 10;
            FireStave_02.Item_Buy = 30;
            FireStave_02.Item_Sell = 15;
            FireStave_02.Item_Amount = 1;

            FrostStave_01.Item_Name = "Frost Gout Stave";
            FrostStave_01.Item_Type = 8;
            FrostStave_01.Item_Charge = 50;
            FrostStave_01.Item_Charge_Use = 2;
            FrostStave_01.Item_Damage = 6;
            FrostStave_01.Item_Weight = 10;
            FrostStave_01.Item_Buy = 15;
            FrostStave_01.Item_Sell = 7;
            FrostStave_01.Item_Amount = 1;

            FrostStave_02.Item_Name = "Frost Blast Stave";
            FrostStave_02.Item_Type = 8;
            FrostStave_02.Item_Charge = 75;
            FrostStave_02.Item_Charge_Use = 5;
            FrostStave_02.Item_Damage = 12;
            FrostStave_02.Item_Weight = 10;
            FrostStave_02.Item_Buy = 40;
            FrostStave_02.Item_Sell = 20;
            FrostStave_02.Item_Amount = 1;

            SparkStave_01.Item_Name = "Spark Gout Stave";
            SparkStave_01.Item_Type = 8;
            SparkStave_01.Item_Charge = 50;
            SparkStave_01.Item_Charge_Use = 2;
            SparkStave_01.Item_Damage = 8;
            SparkStave_01.Item_Weight = 10;
            SparkStave_01.Item_Buy = 25;
            SparkStave_01.Item_Sell = 12;
            SparkStave_01.Item_Amount = 1;

            SparkStave_02.Item_Name = "Spark Blast Stave";
            SparkStave_02.Item_Type = 8;
            SparkStave_02.Item_Charge = 75;
            SparkStave_02.Item_Charge_Use = 5;
            SparkStave_02.Item_Damage = 15;
            SparkStave_02.Item_Weight = 10;
            SparkStave_02.Item_Buy = 50;
            SparkStave_02.Item_Sell = 25;
            SparkStave_02.Item_Amount = 1;

            MageRobes.Item_Name = "Mage Robes";
            MageRobes.Item_Buy = 15;
            MageRobes.Item_Type = 9;
            MageRobes.Item_Armor_Rating = 5;
            MageRobes.Item_Sell = 5;
            MageRobes.Item_Weight = 8;
            MageRobes.Item_Amount = 1;

            Swords_List.Add(CopperSword);
            Swords_List.Add(BronzeSword);
            Swords_List.Add(IronSword);
            Swords_List.Add(SteelSword);

            Axes_List.Add(CopperAxe);
            Axes_List.Add(BronzeAxe);
            Axes_List.Add(IronAxe);
            Axes_List.Add(SteelAxe);

            Hammer_List.Add(CopperHammer);
            Hammer_List.Add(BronzeHammer);
            Hammer_List.Add(IronHammer);
            Hammer_List.Add(SteelHammer);

            Warhammer_List.Add(CopperWarhammer);
            Warhammer_List.Add(BronzeWarhammer);
            Warhammer_List.Add(IronWarhammer);
            Warhammer_List.Add(SteelWarhammer);

            Greatsword_List.Add(CopperGreatsword);
            Greatsword_List.Add(BronzeWarhammer);
            Greatsword_List.Add(IronGreatsword);
            Greatsword_List.Add(SteelGreatsword);

            Crossbow_List.Add(CopperCrossbow);
            Crossbow_List.Add(BronzeCrossbow);
            Crossbow_List.Add(IronCrossbow);
            Crossbow_List.Add(SteelCrossbow);

            Bow_List.Add(CopperBow);
            Bow_List.Add(BronzeBow);
            Bow_List.Add(IronBow);
            Bow_List.Add(SteelBow);

            Heavy_Armor_List.Add(CopperArmor);
            Heavy_Armor_List.Add(BronzeArmor);
            Heavy_Armor_List.Add(IronArmor);
            Heavy_Armor_List.Add(SteelArmor);

            Light_Armor_List.Add(HideArmor);
            Light_Armor_List.Add(LeatherArmor);

            Staves_List.Add(FireStave_01);
            Staves_List.Add(FireStave_02);
            Staves_List.Add(FrostStave_01);
            Staves_List.Add(FrostStave_02);
            Staves_List.Add(SparkStave_01);
            Staves_List.Add(SparkStave_02);

            Spells_List.Add(Fire_01);
            Spells_List.Add(Fire_02);
            Spells_List.Add(Frost_01);
            Spells_List.Add(Frost_02);
            Spells_List.Add(Spark_01);
            Spells_List.Add(Spark_02);

            Valuables_List.Add(Amethyst_Gem);
            Valuables_List.Add(Sapphire_Gem);
            Valuables_List.Add(Diamond_Gem);

            Mage_List.Add(MageRobes);
            Mage_List.Add(Fire_01);
            Mage_List.Add(Healing_1);
            Mage_List.Add(Magicka_1);

            Warrior_List.Add(CopperSword);
            Warrior_List.Add(HideArmor);
            Warrior_List.Add(Healing_1);

            Thief_List.Add(CopperSword);
            Thief_List.Add(CopperArrow);
            Thief_List.Add(CopperCrossbow);
            Thief_List.Add(Healing_1);
            Thief_List.Add(Stamina_1);

            //regular items for enemies
            Basic_Enemy_Equipment_List.Add(BronzeSword);
            Basic_Enemy_Equipment_List.Add(Fire_01);
            Basic_Enemy_Equipment_List.Add(Healing_1);
            Basic_Enemy_Equipment_List.Add(CopperArmor);
            Basic_Enemy_Equipment_List.Add(Healing_1);
            Basic_Enemy_Equipment_List.Add(Stamina_1);
            Basic_Enemy_Equipment_List.Add(Healing_1);
            Basic_Enemy_Equipment_List.Add(Healing_1);
            Basic_Enemy_Equipment_List.Add(Healing_1);
            //more specific equipment lists
            Animal_Equipment_List.Add(Amethyst_Gem);

            Fire_Wizard_Equipment_List.Add(Fire_01);
            Fire_Wizard_Equipment_List.Add(Fire_02);
            Fire_Wizard_Equipment_List.Add(Magicka_2);
            Fire_Wizard_Equipment_List.Add(Magicka_1);
            Fire_Wizard_Equipment_List.Add(Healing_1);
            Fire_Wizard_Equipment_List.Add(MageRobes);
            
            Frost_Wizard_Equipment_List.Add(Frost_01);
            Frost_Wizard_Equipment_List.Add(Frost_02);
            Frost_Wizard_Equipment_List.Add(Magicka_2);
            Frost_Wizard_Equipment_List.Add(Magicka_1);
            Frost_Wizard_Equipment_List.Add(Healing_1);
            Frost_Wizard_Equipment_List.Add(MageRobes);
            
            Spark_Wizard_Equipment_List.Add(Spark_01);
            Spark_Wizard_Equipment_List.Add(Spark_02);
            Spark_Wizard_Equipment_List.Add(Magicka_2);
            Spark_Wizard_Equipment_List.Add(Magicka_1);
            Spark_Wizard_Equipment_List.Add(Healing_1);
            Spark_Wizard_Equipment_List.Add(MageRobes);


            //friendlies equipment lists
            Merchant_List_01.Add(IronArmor);
            Merchant_List_01.Add(IronSword);
            Merchant_List_01.Add(Diamond_Gem);
            Merchant_List_01.Add(Healing_2);
            Merchant_List_01.Add(Magicka_2);
            Merchant_List_01.Add(SparkStave_01);
            Merchant_List_01.Add(Frost_02);


            //loot for buildings
            Basic_Building_List.Add(Amethyst_Gem);
            Basic_Building_List.Add(Swords_List[randitem.Next(1, Swords_List.Count)]);
            Basic_Building_List.Add(Heavy_Armor_List[randitem.Next(1, Heavy_Armor_List.Count)]);

        }

    }
}
