using MyCipher.Service;

namespace MyCipher.Encrypt
{
    internal class EncryptSecondStage
    {
        public int AmountOfSpecialChars(List<string> listToEncryption)
        {

            AllChars allChars = new();

            int amountSpecialChars = 0;

            foreach (string key in listToEncryption)
            {
                foreach (string specialChar in allChars.specialChars)
                {
                    if (key == specialChar)
                    {
                        amountSpecialChars++;
                    }
                }
            }

            return amountSpecialChars;
        }

        
    }
}
