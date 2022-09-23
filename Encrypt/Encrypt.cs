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
            //

            //Keys
            Keys consonant = new();
            Keys vowel = new();
            Keys number = new();
            Keys specialChar = new();

            List<Keys> listKeys = new(){
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
            #endregion LoadData

            ListToEncryption = GetListOfStringsToEncrypt(ListToEncryption);

            #region SetIndexesAndAmountOfKeys
            for(var i=0; i<4; i++)
            {
                keysService.SetIndexesAndAmount(listKeys[i], allChars.alphabet, listChars[i], ListToEncryption);
            }
            #endregion

            #region CreatingCipher
            for (var i = 0; i < 8; i++)
            {
                Cipher = (i<4) ? AddAmountOfKeyToCipher(listKeys[i], Cipher) : Cipher = AddIndexesOfKeyToCipher(listKeys[i - 4], Cipher);
            }
            #endregion

            ShowCipher(Cipher);
        }
    }
}
