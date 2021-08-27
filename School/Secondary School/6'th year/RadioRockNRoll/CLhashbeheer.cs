using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioRockNRoll
{


    class CLhashbeheer
    {
        private readonly byte[] _value;
        public string Input { get; }
        public string Scrambler { get; }
        public string HashedValue { get; private set; }
        private int ScambledNumber { get; }

        public CLhashbeheer(string input, int scrambler, string[] scrambleValues)
        {

            if (scrambler > scrambleValues.Length - 1) throw new IndexOutOfRangeException("De gevraagde scrambler waarde bestaat niet!");

            Input = input;
            Scrambler = scrambleValues[scrambler];
            ScambledNumber = scrambler;
            _value = GetUtfReady(input, Scrambler);
        }

        private byte[] GetUtfReady(string input, string scrambler)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            input = new string(chars);
            return new UTF32Encoding().GetBytes(string.Format(scrambler, input));
        }

        public void GenerateHashSha512()
        {
            string hash = Convert.ToBase64String(new SHA512Managed().ComputeHash(_value));
            hash = hash.Substring(0, hash.Length - 2);
            HashedValue = $"{hash}@RockNRoll{ScambledNumber}";
        }
    }
}
