using MyCipher.Service;

namespace MyCipher.Encrypt
{
    internal class Encryption : DrawLetter
    {
        public Encryption() //load all classes to do Cipher
        {
            string temp;

            List<string> Cipher = new List<string>();

            //FIRST STAGE 11111111111111111111111111111111111111111111111111111111111111111111111111111111
            EncryptFirstStage encryptFirstStage = new EncryptFirstStage(); //number of chars
            temp = ""+encryptFirstStage.TakeNumberOfChars();
            Cipher.Add(temp);
            Cipher.Add(AddLetter());
            //END FIRST STAGE 1111111111111111111111111111111111111111111111111111111111111111111111111111
        }

        public string AddLetter()
        {
            string temp;

            DrawLetter drawLetter = new DrawLetter();
            temp = drawLetter.DrawLetterFromAToZ();

            return temp;
        }
    }
}
