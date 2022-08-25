using MyCipher.Service;

namespace MyCipher.Encrypt
{
    internal class Encryption : DrawLetter
    {
        public List<string> ListToEncryption { get; set; }

        public Encryption()
        {
            string textToEncryption;

            List<string> Cipher = new();

            //FIRST STAGE 11111111111111111111111111111111111111111111111111111111111111111111111111111111
            textToEncryption = Console.ReadLine();
            ListToEncryption = ConvertTypeOfTextToEncryptionFromStringToList(textToEncryption);

            Cipher.Add("" + ListToEncryption.Count());
            Cipher.Add(AddLetter());
            //END FIRST STAGE 1111111111111111111111111111111111111111111111111111111111111111111111111111
            

            //ND STAGE 22222222222222222222222222222222222222222222222222222222222222222222222222222222222
            EncryptSecondStage encryptSecondStage = new(); //amount of special chars and take order them
            
            Cipher.Add("" + encryptSecondStage.AmountOfConsonants(ListToEncryption));
            Cipher.Add(AddLetter());
            Cipher.Add("" + encryptSecondStage.AmountOfVowels(ListToEncryption));
            Cipher.Add(AddLetter());
            Cipher.Add("" + encryptSecondStage.AmountOfNumbers(ListToEncryption));
            Cipher.Add(AddLetter());
            Cipher.Add("" + encryptSecondStage.AmountOfSpecialChars(ListToEncryption));
            Cipher.Add(AddLetter());
            Cipher.Add("" + encryptSecondStage.AmountOfSpaces(ListToEncryption));
            Cipher.Add(AddLetter());
            //END ND STAGE 2222222222222222222222222222222222222222222222222222222222222222222222222222222


            //RD STAGE 33333333333333333333333333333333333333333333333333333333333333333333333333333333333
            EncryptThirdStage encryptThirdStage = new();
            Cipher = encryptThirdStage.AddOrder(Cipher, encryptSecondStage.IndexesOfConsonants);
            Cipher = encryptThirdStage.AddOrder(Cipher, encryptSecondStage.IndexesOfVowels);
            Cipher = encryptThirdStage.AddOrder(Cipher, encryptSecondStage.IndexesOfSpecialChars);
            Cipher = encryptThirdStage.AddOrder(Cipher, encryptSecondStage.IndexesOfNumbers);
            Cipher = encryptThirdStage.AddOrder(Cipher, encryptSecondStage.IndexesOfSpaces);
            //END RD STAGE 3333333333333333333333333333333333333333333333333333333333333333333333333333333

            Console.WriteLine("\n\n******* CIPHER:");
            foreach (string key in Cipher)
            {
                Console.Write(key);
            }
        }

        public string AddLetter()
        {
            string temp;

            DrawLetter drawLetter = new();
            temp = drawLetter.DrawLetterFromAToZ();

            return temp;
        }

        public List<string> ConvertTypeOfTextToEncryptionFromStringToList(string stringToList)
        {
            ListToEncryption = new();
            ListToEncryption.AddRange(stringToList.Select(c => c.ToString()));

            return ListToEncryption;
        }
    }
}
