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
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(alphabet[DrawNumber()]);

            }



        }

        private int DrawNumber()
        {
            Random generator = new Random();
            int number = generator.Next(23);
            

            return number;
        }
    }
}
