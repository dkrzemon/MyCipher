using MyCipher.Common;
using MyCipher.Keys;

namespace MyCipher.Decrypt
{
    internal class Decryption : DecryptionService
    {
        public Decryption()
        {
            #region Load_data
            //Basic variables
            List<string> Cipher = new();
            List<int> ListToDecryption = new();
            List<string> ActiveArraysOfChars = new(); //to detect how many types of chars (consonants, vowels, numbers, specialChars --- 4 types) was used
            List<string> OrderOfKeys = new();

            Key consonant = new();
            Key vowel = new();
            Key number = new();
            Key specialChar = new();

            List<Key> ListKeys = new(){
                consonant,
                vowel,
                number,
                specialChar
            };

            AllChars allChars = new();
            List<List<string>> ListChars = new()
            {
                allChars.consonants,
                allChars.vowels,
                allChars.numbers,
                allChars.specialChars
            };
            //
            #endregion load_data

            Cipher = GetListOfStringsToEncryptDecrypt(Cipher);

            ListToDecryption = GetKeys(Cipher);

            #region Set_Data_of_class_"Key"
            //Setting "Amount"
            for (int i = 0; i < ListKeys.Count; i++)
            {
                ListToDecryption = SetAmount(ListKeys[i], ListToDecryption);
            }

            //Setting "Indexes"
            for (int i = 0; i < ListKeys.Count; i++)
            {
                ListToDecryption = SetIndexes(ListKeys[i], ListToDecryption);
            }
            //
            #endregion set_data_of_class_"Key"

            #region Get_order
            for (int i = 0; i < ListToDecryption.Count; i++)
            {
                OrderOfKeys.Add(CheckTypeOfKey(ListToDecryption[i]));
            }
            #endregion get_order

            #region Set_cipher

            Cipher.Clear();
            string temp; //as OrderOfKeys[x] in normal string (thank to switch, which dont want accept List<string>[x])

            for (int i = 0; i < OrderOfKeys.Count; i++)
            {
                temp = OrderOfKeys[i];

                switch (temp)
                {
                    case "consonant":
                        Cipher.Add(UpdateCipher(ListKeys[0], allChars.consonants));
                        break;
                    case "consonantBig":
                        Cipher.Add(UpdateCipher(ListKeys[0], allChars.consonants, "big"));
                        break;
                    case "vowel":
                        Cipher.Add(UpdateCipher(ListKeys[1], allChars.vowels));
                        break;
                    case "vowelBig":
                        Cipher.Add(UpdateCipher(ListKeys[1], allChars.vowels, "big"));
                        break;
                    case "number":
                        Cipher.Add(UpdateCipher(ListKeys[2], allChars.numbers));
                        break;
                    case "specialChar":
                        Cipher.Add(UpdateCipher(ListKeys[3], allChars.specialChars));
                        break;
                }
            }

            #endregion set_cipher

            #region Show_progress

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            foreach (string key in Cipher)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            #endregion show_progress
        }
    }
}
