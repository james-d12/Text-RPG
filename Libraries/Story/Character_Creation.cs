using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Libraries.Item_Library;
using Libraries.NPC_Library;
using Libraries.Buildings;
using Libraries.Player_Library;

namespace Libraries.Story
{
    public class Character_Creation
    {
        static void Main(string[] args)
        {
            Start();
        }
        public static void Start()
        {
            Draw_UI.Draw_Loading();
            Console.Clear();
            Draw_UI.Draw_UI_Method();
            Character_FirstName();
        }

        public static void Character_FirstName()
        {
            string Character_FName;

            do
            {
                Console.Write("Character First Name: ");
                Character_FName = Console.ReadLine();
            } while (!Character_FName.All(char.IsLetter));
            if (Character_FName.Length > 12)
            {
                Console.WriteLine("Name is too long.");
                Character_Creation.Character_FirstName();
            }
            else
            {
                Character_LastName(Character_FName);
            }

        }
        public static void Character_LastName(string _character_Fname)
        {
            string Character_LName;
            string Character_Name;

            do
            {
                Console.Write("Character Last Name: ");
                Character_LName = Console.ReadLine();
            } while (!Character_LName.All(char.IsLetter));
            if (Character_LName.Length > 12)
            {
                Console.WriteLine("Name is too long.");
                Character_Creation.Character_LastName(_character_Fname);
            }
            else
            {
                Character_Name = _character_Fname + " " + Character_LName;
                Character_Class(Character_Name);
            }

        }
        public static void Character_Class(string _Character_Name)
        {
            string Character_Class;

            do
            {
                Console.WriteLine("Mage | Warrior | Thief");
                Console.Write("Character Class: ");
                Character_Class = Console.ReadLine();
            }
            while ((Character_Class == "Mage" || Character_Class == "Warrior" || Character_Class == "Thief") == false);
            Player._Player(_Character_Name, Character_Class);

        }
    }
}
