using MyCipher.Service;

namespace MyCipher.Encrypt
{
    internal class EncryptSecondStage
    {
        public List<string> IndexesOfConsonants { get; set; }
        public List<string> IndexesOfVowels { get; set; }
        public List<string> IndexesOfNumbers { get; set; }
        public List<string> IndexesOfSpecialChars { get; set; }
        public List<string> IndexesOfSpaces { get; set; }

        public int AmountOfConsonants(List<string> listToEncryption)
        {
            int amountConsonants = 0;
            IndexesOfConsonants = new(); //TO ORDER OF CONSONANTS

            AllChars allChars = new();

            foreach (string key in listToEncryption)
            {
                foreach (string consonant in allChars.consonants)
                {
                    if (key == consonant)
                    {
                        IndexesOfConsonants.Add("" + allChars.consonants.IndexOf(key));

                        //Console.WriteLine("consonant (INDEX) -> " + allChars.consonants.IndexOf(consonant));
                        amountConsonants++;
                    }
                }
            }

            return amountConsonants;
        }

        public int AmountOfVowels(List<string> listToEncryption)
        {
            int amountVowels = 0;
            IndexesOfVowels = new(); //TO ORDER OF VOWELS
            AllChars allChars = new();

            foreach (string key in listToEncryption)
            {
                foreach (string vowel in allChars.vowels)
                {
                    if (key == vowel)
                    {
                        IndexesOfVowels.Add("" + allChars.vowels.IndexOf(key));
                        //Console.WriteLine("****" + allChars.numbers.IndexOf(vowel) + "****");
                        amountVowels++;
                    }
                }
            }

            return amountVowels;
        }

        public int AmountOfNumbers(List<string> listToEncryption)
        {
            int amountNumbers = 0;
            IndexesOfNumbers = new(); //TO ORDER OF NUMBERS
            AllChars allChars = new();

            foreach (string key in listToEncryption)
            {
                foreach (string number in allChars.numbers)
                {
                    if (key == number)
                    {
                        IndexesOfNumbers.Add("" + allChars.numbers.IndexOf(key));
                        amountNumbers++;
                    }
                }
            }

            return amountNumbers;
        }

        public int AmountOfSpecialChars(List<string> listToEncryption) //ADDITIONAL FUNCTION -> take index this special chars
        {
            int amountSpecialChars = 0;
            IndexesOfSpecialChars = new(); //TO ORDER OF SPECIAL CHARS
            AllChars allChars = new();

            foreach (string key in listToEncryption)
            {
                foreach (string specialChar in allChars.specialChars)
                {
                    if (key == specialChar)
                    {
                        IndexesOfSpecialChars.Add("" + allChars.specialChars.IndexOf(key));
                        amountSpecialChars++;
                    }
                }
            }

            return amountSpecialChars;
        }

        public int AmountOfSpaces(List<string> listToEncryption) //ADDITIONAL FUNCTION -> take index this special chars
        {
            int i = 0;
            int amountOfSpaces = 0;
            IndexesOfSpaces = new(); //TO ORDER OF SPACES


            foreach (string key in listToEncryption)
            {
                    if (key == " ")
                    {
                        IndexesOfSpaces.Add("" + i);
                        amountOfSpaces++;
                    }
                i++;
            }

            return amountOfSpaces;
        }

        //public List<string> GetOrderOfConsonants(List<string> list)
        //{
        //    return IndexesOfConsonants;
        //}
    }
}
