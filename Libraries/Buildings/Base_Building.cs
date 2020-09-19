using System;
using System.Collections.Generic;
using System.Text;
using Libraries.NPC_Library;

namespace Libraries.Buildings
{
    public class Base_Building
    {
        public List<object> Building_Items { get; set; }
        public List<Enemy> Building_Enemies { get; set; }
        public List<Friendly> Building_Friendlies { get; set; }
        public string Building_Name { get; set; }
    }
}
