namespace MyCipher.Service
{
    public interface IKeysService
    {
        public List<string> Indexes { get; set; }
        public int Amount { get; set; }
    }
}
