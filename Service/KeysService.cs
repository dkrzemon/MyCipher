namespace MyCipher.Service
{
    internal class KeysService
    {
        public void SetIndexesAndAmount(IKeysService IndividualKey, List<string> BigLetters, List<string> ArrayCharsToCheck, List<string> listToEncryption)
        {
            int IndexesPlusMinusSeventeen;
            IndividualKey.Indexes = new();
            IndividualKey.Amount = 0;

            foreach (string key in listToEncryption)
            {
                foreach (string temp in ArrayCharsToCheck)
                {
                    if (key.ToLower() == temp)
                    {
                        IndexesPlusMinusSeventeen = ArrayCharsToCheck.IndexOf(key.ToLower());

                        foreach (string temp2 in BigLetters) //if its true, then IndexOfKey + 17
                        {
                            if (key == temp2) //then letter is big
                            {
                                IndexesPlusMinusSeventeen += 17;

                                break;
                            }
                        }

                        IndividualKey.Indexes.Add("" + IndexesPlusMinusSeventeen);
                        IndividualKey.Amount++;
                    }
                }
            }
        }
    }
}