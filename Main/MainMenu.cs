using System;
using MyCipher.Decrypt;
using MyCipher.Encrypt;
using MyCipher.Common;

namespace MyCipher.Main
{
    internal class MainMenu : Colors
    {
        public MainMenu()
        {
            int loop = 0;

            do
            {
                Console.Clear();
                changeTextColor("darkYellow");
                Console.WriteLine("MAIN MENU");
                Console.WriteLine("*********");
                changeTextColor("yellow");
                Console.WriteLine("1. Encryption");
                Console.WriteLine("2. Decryption");
                Console.Write("3.");
                changeTextColor("red");
                Console.Write(" EXIT");

                changeTextColor("yellow");
                Console.Write("\n\nYOUR CHOICE: ");

                changeTextColor("white");
                char choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        loop = 1;
                        Encryption encryption = new();
                        BackToMenu();
                        break;
                    case '2':
                        loop = 1;
                        Decryption decryption = new();
                        BackToMenu();
                        break;
                    case '3':
                        loop = 0;
                        return;
                    default:
                        loop = 1;
                        break;
                }
            } while (loop == 1);
        }

        private void BackToMenu()
        {
            Console.WriteLine("\n\n");
            changeTextColor("darkYellow");
            Console.WriteLine("WHAT NEXT");
            Console.WriteLine("*********");
            changeTextColor("yellow");
            Console.WriteLine("1. Back to menu");

            changeTextColor("yellow");
            Console.Write("\n\nYOUR CHOICE: ");
            char choice = Console.ReadKey().KeyChar;
            changeTextColor("white");

            if(choice == null)
            {
                BackToMenu();
            }

            switch (choice)
            {
                case '1':
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
    }
}
