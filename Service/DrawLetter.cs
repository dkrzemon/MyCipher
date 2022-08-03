using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCipher.Service
{
    internal class DrawLetter : AllChars
    {
        public DrawLetter()
        {
            //Console.WriteLine(alphabet[DrawNumber()]);
        }

        public string DrawLetterFromAToZ()
        {
            Random generator = new Random();
            int number = generator.Next(23);

            AllChars allChars = new AllChars(); //load all arrays from class AllChars

            return allChars.alphabet[number];
        }
    }
}
