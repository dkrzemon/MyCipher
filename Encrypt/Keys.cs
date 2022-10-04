using MyCipher.Service;

namespace MyCipher.Encrypt
{
    internal class Keys : IKeysService
    {
        public List<string> Indexes { get; set; }
        public int Amount { get; set; }
    }
}