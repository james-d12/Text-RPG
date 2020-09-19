using System;
using System.Collections.Generic;
using System.Text;

namespace Libraries.NPC_Library
{
    public class Base_Friendly
    {
        public int NPC_Type { get; set; }//1 = shopkeeper // 2 = Random NPC

        public List<object> NPC_Inventory { get; set; }
        public int Shop_Gold { get; set; }
        public int NPC_Health { get; set; }
        public int NPC_Damage { get; set; }
        public int NPC_Magicka { get; set; }
        public string NPC_Name { get; set; }
    }
}
