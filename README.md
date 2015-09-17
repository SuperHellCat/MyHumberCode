using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            _GameStep._Start();
            
           
            
            Console.ReadLine();
        }




    }

    class _GameStep
    {
        internal static string playerName;
        internal static string playerFirstName;
        internal static string playerLastName;
        internal static short playerAge;
        internal static float playerWeight;

        
      public static void _Start()
        {
            _EachChar._EachC("Welcome to this game, player\n");
            _EachChar._EachC("What's your firstname you want use is this game?\n");

            playerFirstName = Console.ReadLine();

            _EachChar._EachC("OK, then the lastname.\n");

            playerLastName = Console.ReadLine();
            playerName = playerFirstName + " " + playerLastName;

            _EachChar._EachC("So ! this is your name, " + playerName+", not bad\n");
            _EachChar._EachC("next question, What age you are now?\n");

            do
            {
                short.TryParse(Console.ReadLine(), out playerAge);
                Console.WriteLine(playerAge);
                if (playerAge == 0)
                    _EachChar._EachC("it's not fun for me\n");
            } while (playerAge == 0);
            
            _EachChar._EachC("and what about your weight?\n");

            do
            {
                float.TryParse(Console.ReadLine(), out playerWeight);
                if (playerWeight == 0)
                    _EachChar._EachC("it's not fun for me\n");
            } while (playerWeight == 0);
      
            

            _EachChar._EachC("So here is, your personal infomation\n");
            _EachChar._EachC("|\tName:\t" + playerName + "\t\t|\n");
            _EachChar._EachC("|\tAge:\t" + playerAge + "\t\t|\n");
            _EachChar._EachC("|\tWeight:\t" + playerWeight + "\t\t|\n");


        }
    }
    class _EachChar
    {
        public static void _EachC(string _NewString)
        {
            for (int i = 0; i < _NewString.Length; i++)
            {
                string a = _NewString.Substring(i, 1);
               //System.Threading.Thread.Sleep(5);
                Console.Write(a);
            }
        }
    }
}

