

namespace DZ.Interfaces
{
    internal interface ICipher
    {
        string Decode(string input);
        string Encode(string input);
    }
}
