using System;
using System.Security.Cryptography;
using System.Text;

namespace Server
{
    public class HashHandler
    {
        private readonly byte[] _value;
        public string Input { get; }
        public string Scrambler { get; }

        public HashHandler(string input, string scrambler)
        {
            Input = input;
            Scrambler = scrambler;
            _value = GetUtfReady(input, scrambler);
        }

        private static byte[] GetUtfReady(string input, string scrambler)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            foreach (char c in chars) input += c;
            return new UTF8Encoding().GetBytes(string.Format(scrambler, input));
        }

        public string GetHashSha512() => Convert.ToBase64String(new SHA512Managed().ComputeHash(_value));
    }
}