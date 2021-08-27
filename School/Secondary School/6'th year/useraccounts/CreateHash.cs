using System;
using System.Security.Cryptography;
using System.Text;

namespace useraccounts
{
    class CreateHash
    {
        private byte[] value;
        public CreateHash(string input, string scrambler)
        {
            value = GetUtfReady(input, scrambler);
        }

        private byte[] GetUtfReady(string input, string scrambler)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            input += chars.ToString();
            return new UTF8Encoding().GetBytes(string.Format(scrambler, input));
        }

        public string getHashSHA512() => Convert.ToBase64String(new SHA512Managed().ComputeHash(value));
    }
}
