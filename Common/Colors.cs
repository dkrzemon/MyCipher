using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCipher.Common
{
    internal class Colors
    {
        public void changeTextColor(string nameColor)
        {
            switch (nameColor)
            {
                case "darkYellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed; //for mistake
                    break;
            }
        }
    }
}
