using MyCipher.Encrypt.Keys;
using MyCipher.Service;

namespace MyCipher.Encrypt
{
    internal class Encryption : EncryptService
    {
        public Encryption()
        {
            #region LoadData
            //Variables
            List<string> Cipher = new();
            List<string> ListToEncryption = new();


            //Classes of keys
            Consonants consonant = new();
            Vowels vowel = new();
            Numbers number = new();
            SpecialChars specialChar = new();

            //Service to creating crypt
            KeysService keysService = new();
            AllChars allChars = new AllChars();
            #endregion LoadData

            ListToEncryption = GetListOfStringsToEncrypt(ListToEncryption);

            #region SetIndexesAndAmountOfKeys
            keysService.SetIndexesAndAmount(consonant, allChars.consonants, ListToEncryption);
            keysService.SetIndexesAndAmount(vowel, allChars.vowels, ListToEncryption);
            keysService.SetIndexesAndAmount(number, allChars.numbers, ListToEncryption);
            keysService.SetIndexesAndAmount(specialChar, allChars.specialChars, ListToEncryption);
            #endregion

            #region CreatingCipher
            Cipher = AddAmountOfKeyToCipher(consonant, Cipher);
            Cipher = AddAmountOfKeyToCipher(vowel, Cipher);
            Cipher = AddAmountOfKeyToCipher(number, Cipher);
            Cipher = AddAmountOfKeyToCipher(specialChar, Cipher);

            Cipher = AddIndexesOfKeyToCipher(consonant, Cipher);
            Cipher = AddIndexesOfKeyToCipher(vowel, Cipher);
            Cipher = AddIndexesOfKeyToCipher(number, Cipher);
            Cipher = AddIndexesOfKeyToCipher(specialChar, Cipher);
            #endregion

            #region ShowCrypt
            Console.WriteLine("\n\n******* CIPHER:"); //SHOW CIPHER
            foreach (string key in Cipher)
            {
                Console.Write(key);
            }
        #endregion
        }
    }
}
