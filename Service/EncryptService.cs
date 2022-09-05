namespace MyCipher.Service
{
    internal class EncryptService
    {
        public List<string> GetListOfStringsToEncrypt(List<string> list)
        {
            string stringToList = Console.ReadLine(); //to check stringToList != null
            list = new();
            list.AddRange(stringToList.Select(c => c.ToString())); //ConvertTypeOfTextToEncryptionFromStringToList

            return list;
        }

        public List<string> AddAmountOfKeyToCipher(IKeysService iKeyService, List<string> cipher)
        {
            cipher.Add("" + iKeyService.Amount);
            cipher.Add(AddLetter());

            return cipher;
        }

        public List<string> AddIndexesOfKeyToCipher(IKeysService iKeyService, List<string> cipher)
        {
            foreach (string key in iKeyService.Indexes)
            {
                cipher.Add(key);
                cipher.Add(AddLetter());
            }

            return cipher;
        }

        public void EncryptEnded(List<string> cipher)
        {
            Console.WriteLine("\n\n******* CIPHER:"); //SHOW CIPHER

            foreach (string key in cipher) Console.Write(key);
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
