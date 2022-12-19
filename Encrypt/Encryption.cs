using MyCipher.Keys;
using MyCipher.Common;

namespace MyCipher.Encrypt
{
    internal class Encryption : EncryptionService
    {
        public Encryption()
        {
            #region Load_data
            //Basic variables
            List<string> Cipher = new();
            List<string> ListToEncryption = new();
            //

            //Keys
            Key consonant = new();
            Key vowel = new();
            Key number = new();
            Key specialChar = new();

            List<Key> listKeys = new(){
                consonant,
                vowel,
                number,
                specialChar
            };

            AllChars allChars = new();
            List<List<string>> listChars = new()
            {
                allChars.consonants,
                allChars.vowels,
                allChars.numbers,
                allChars.specialChars
            };
            //

            //Service
            KeysService keysService = new();
            //
            #endregion load_data

            ListToEncryption = GetListOfStringsToEncryptDecrypt(ListToEncryption);

            for(var i=0; i<4; i++)
            {
                keysService.SetIndexesAndAmount(listKeys[i], allChars.alphabet, listChars[i], ListToEncryption);
            }

            for (var i = 0; i < 8; i++)
            {
                Cipher = (i<4) ? AddAmountOfKeyToCipher(listKeys[i], Cipher) : Cipher = AddIndexesOfKeyToCipher(listKeys[i - 4], Cipher);
            }

            AddOrderOfKeysToCipher(ListToEncryption, listChars, Cipher);

            ShowCipher(Cipher);
        }
    }
}