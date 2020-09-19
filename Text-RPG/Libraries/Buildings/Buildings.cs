using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Libraries.Item_Library;
using Libraries.NPC_Library;

namespace Libraries.Buildings
{
    public class Building : Base_Building
    {
        private static Random randenemy = new Random();

        public static List<Building> Easy_Buildings = new List<Building>();

        public static void Initialise_Buildings()
        {
            Building Shack = new Building();
            Building House = new Building();
            Building Camp = new Building();


            Shack.Building_Items = Item.Basic_Building_List;
            Shack.Building_Enemies = Enemy.Easy_Building_List;
            Shack.Building_Name = "Old Shack";

            House.Building_Items = Item.Basic_Building_List;
            House.Building_Enemies = Enemy.Easy_Building_List;
            House.Building_Name = "Old House";

            Camp.Building_Items = Item.Basic_Building_List;
            Camp.Building_Enemies = Enemy.Easy_Building_List;
            Camp.Building_Name = "Camp Site";


            Easy_Buildings.Add(Shack);
            Easy_Buildings.Add(House);
            Easy_Buildings.Add(Camp);
        }
    }
}
