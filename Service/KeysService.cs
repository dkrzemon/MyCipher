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
}
