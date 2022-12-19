using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCipher.Common
{
    internal class CryptService : Colors
    {
        public List<string> GetListOfStringsToEncryptDecrypt(List<string> list)
        {
            Console.Clear();
            changeTextColor("yellow");
            Console.Write("Enter some text: ");
            changeTextColor("white");
            string stringToList = Console.ReadLine();

            if(stringToList == "")
            {
                changeTextColor("darkRed");
                Console.Write("Empty data");
                Thread.Sleep(1250);

                GetListOfStringsToEncryptDecrypt(list);
            }
            //string stringToList = "3y2U0g0H2P15o2S0t2t2y7r2J6B0H"; //encrypted string - "dawid"
            list.AddRange(stringToList.Select(c => c.ToString())); //convert type of TextToEncryption from string to list

            return list;
        }
    }
}
