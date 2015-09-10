using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    class FirstClass
    {
        static void Main(string[] args)
        {
            string _Start = "Hello, C#\n";
            string _Name;
            string _Age;
            string _Location;
            string _Sure;
            //System.Text.ASCIIEncoding Acs = new System.Text.ASCIIEncoding();     
            //int _ASCIINumber = Acs.GetBytes(_Start)[2];       
            //Console.Write(_ASCIINumber);         
            _EachC(_Start);
            System.Threading.Thread.Sleep(500);
            _EachC("Hi, What's Your Name?\n");
            _Name = Console.ReadLine();
            _EachC("And Your Age?\n");
            _Age = Console.ReadLine();
            _EachC("Where are you from?\n");
            _Location = Console.ReadLine();
            _EachC("OK, " + _Name + ", " + "You are " + _Age + " " + "and you come from " + _Location + "\n" + "Is it?\n");

            _Sure = Console.ReadLine();
            if (_Sure == "y" || _Sure == "yes")
            {
                _EachC("Cool!\n");
            }
            System.Threading.Thread.Sleep(500);

            Console.ReadKey();
            System.Threading.Thread.Sleep(80000);
        }
        static void _EachC(string _NewString)
        {
            for (int i = 0; i < _NewString.Length; i++)
            {
                string a = _NewString.Substring(i, 1);
                System.Threading.Thread.Sleep(25);
                Console.Write(a);
            }
        }
    }
}


