using MyCipher.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCipher.Encrypt
{
    internal class EncryptThirdStage : DrawLetter //ORDER OF SINGLE KEYS
    {
        public List<string> AddOrder(List<string> cipher, List<string> IndexesOfSth)
        {
            if(IndexesOfSth != null)
            {
                foreach (string key in IndexesOfSth)
                {
                    //Console.WriteLine("****");
                    //foreach (string t in IndexesOfSth)
                    //{
                    //    Console.Write(t);
                    //}
                    //Console.WriteLine("****");

                    cipher.Add(key);
                    cipher.Add(AddLetter());
                }

                return cipher;
            }
            
            return cipher;
        }

        public string AddLetter()
        {
            string temp;

            DrawLetter drawLetter = new();
            temp = drawLetter.DrawLetterFromAToZ();

            return temp;
        }
    }
}
