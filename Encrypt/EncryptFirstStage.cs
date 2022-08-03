
namespace MyCipher.Encrypt
{
    internal class EncryptFirstStage
    {
        public string TextToEncryption { get; set; } //user write this

        public int TakeNumberOfChars()
        {
            TextToEncryption = Console.ReadLine();

            char[] charsArrayToEncryption = TextToEncryption.ToCharArray();

            return charsArrayToEncryption.Length;
        }
    }
}
