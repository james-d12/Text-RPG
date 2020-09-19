using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Libraries
{
    public class Main_Menu
    {

        public static string Choice;

        public static void Main_Menu_Start()
        {
            do
            {
                Console.Write("New [1] || Load [2]");
                Choice = Console.ReadLine();
            } while (Choice.All(char.IsDigit) == false);
            switch (Choice)
            {
                case "1": 
                    Console.Clear();
                    Story.Character_Creation.Start();
                    break;
                case "2":
                    Console.Clear();
                    Load.Load_Character();
                    break;
                default:
                    Main_Menu_Start();
                    break;
            }
        }
    }
}
