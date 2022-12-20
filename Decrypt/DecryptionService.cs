using MyCipher.Keys;
using MyCipher.Common;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Emit;

namespace MyCipher.Decrypt
{
    internal class DecryptionService : CryptService
    {
        public List<int> GetKeys(List<string> list)
        {
            //Variables
            int result = 0;
            int result2 = 0;

            bool tempBool = false;
            bool tempBool2 = false;

            List<int> AllOfKeys = new();
            //

            #region Get_individual_keys_to_list
            for (int i = 0; i < list.Count; i++) //deleting chars (a-Z) from string to decryption
            {
                try //for single digits
                {
                    result = Int32.Parse(list[i]);
                    tempBool = true;

                    try //for double digits
                    {
                        result2 = Int32.Parse(list[i + 1]);
                        tempBool2 = true;
                    }
                    catch (FormatException)
                    {
                        tempBool2 = false;
                    }

                    //Console.WriteLine(result + " " + result2);
                }
                catch (FormatException)
                {
                    tempBool = false;
                }

                if (tempBool == true) //for single digits  
                {
                    if (tempBool2 == true) //for double digits 
                    {
                        AllOfKeys.Add(Int32.Parse(result + "" + result2));
                        i++;
                    }
                    else
                    {
                        AllOfKeys.Add(result);
                    }
                }
            }
            #endregion

            return AllOfKeys;
        }

        public List<int> SetAmount(IKeysService iKeyService, List<int> IndividualKeys)
        {
            iKeyService.Amount = IndividualKeys[0]; //take value
            IndividualKeys.RemoveAt(0); //and delete from main list of keys

            return IndividualKeys;
        }

        public List<int> SetIndexes(IKeysService iKeyService, List<int> IndividualKeys)
        {
            iKeyService.Indexes = new();

            for (int i = 0; i < iKeyService.Amount; i++)
            {
                iKeyService.Indexes.Add(IndividualKeys[0].ToString());
                IndividualKeys.RemoveAt(0);
            }

            return IndividualKeys;
        }

        public static bool IsBetween(int item, int start, int end) //for method GetOrder(...)
        {
            if ((item >= start) && (item < end))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string CheckTypeOfKey(int key) //for method OrderDataWithSense(...)
        {
            string result = "";

            if (IsBetween(key, 0, 3)) //consonant
            {
                result = "consonant";
            }
            else if (IsBetween(key, 3, 6)) //consonantBig
            {
                result = "consonantBig";
            }
            else if (IsBetween(key, 6, 9)) //vowel
            {
                result = "vowel";
            }
            else if (IsBetween(key, 9, 12)) //vowelBig
            {
                result = "vowelBig";
            }
            else if (IsBetween(key, 12, 15)) //number
            {
                result = "number";
            }
            else if (IsBetween(key, 15, 18)) //specialChar
            {
                result = "specialChar";
            }

            return result;
        }

        public string UpdateCipher(IKeysService iKeysService, List<string> allChars, string size = "small")
        {
            string EncryptedKey;
            EncryptedKey = allChars[Int32.Parse(iKeysService.Indexes[0])];

            if(size == "big")
            {
                EncryptedKey = EncryptedKey.ToUpper();
            }

            iKeysService.Indexes.RemoveAt(0);

            return EncryptedKey;
        }

		public void ShowCipher(List<string> cipher)
		{
			changeTextColor("red");
			Console.WriteLine("\n\nCIPHER:"); //SHOW CIPHER

			changeTextColor("darkRed");
			foreach (string key in cipher) Console.Write(key);
		}
	}
}
