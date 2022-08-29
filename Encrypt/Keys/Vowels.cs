using MyCipher.Service;

namespace MyCipher.Encrypt.Keys
{
    internal class Vowels : IKeysService
    {
        public List<string> Indexes { get; set; }
        public int Amount { get; set; }
    }
}
