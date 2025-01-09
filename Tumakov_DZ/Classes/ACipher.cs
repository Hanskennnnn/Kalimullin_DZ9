using DZ.Interfaces;


namespace DZ.Classes
{
    internal class ACipher : ICipher
    {
        public string Encode(string input)
        {
            char[] result = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'А' : 'а';
                    result[i] = (char)((c - offset + 1) % 32 + offset);
                }
                else
                {
                    result[i] = c;
                }
            }
            return new string(result);
        }
        public string Decode(string input)
        {
            char[] result = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'А' : 'а';
                    result[i] = (char)((c - offset - 1 + 32) % 32 + offset);
                }
                else
                {
                    result[i] = c;
                }
            }
            return new string(result);
        }
    }
}
