using MyCipher.Service;

namespace MyCipher.Encrypt
{
    internal class Encryption : DrawLetter
    {
        public string TextToEncryption { get; set; }

        public Encryption()
        {
            TextToEncryption = Console.ReadLine();
        }

        public void FirstStage()
        {
            Console.Write(TextToEncryption);
        }
    }
}
