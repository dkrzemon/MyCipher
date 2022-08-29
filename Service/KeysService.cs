namespace MyCipher.Service
{
    internal class KeysService
    {
        public void SetIndexesAndAmount(IKeysService IndividualKey, List<string> ArrayCharsToCheck, List<string> listToEncryption)
        {
            IndividualKey.Indexes = new();
            IndividualKey.Amount = 0;

            foreach (string key in listToEncryption)
            {
                foreach (string temp in ArrayCharsToCheck)
                {
                    if (key == temp)
                    {
                        IndividualKey.Indexes.Add("" + ArrayCharsToCheck.IndexOf(key));
                        IndividualKey.Amount++;
                    }
                }
            }
        }


    }

















    //public int GetIndexAndAmountOfIndividualKey(IEncryptService IndividualKey, List<string> listToEncryption)
    //{
    //    Indexes = IndividualKey.Indexes;
    //    Amount = IndividualKey.Amount;

    //    Amount = 0;
    //    Indexes = new(); //TO ORDER OF CONSONANTS

    //    AllChars allChars = new();

    //    foreach (string key in listToEncryption)
    //    {
    //        foreach (string consonant in allChars.consonants)
    //        {
    //            if (key == consonant)
    //            {
    //                Indexes.Add("" + allChars.consonants.IndexOf(key));
    //                Amount++;
    //            }
    //        }
    //    }

    //    return Amount;
    //}


}
