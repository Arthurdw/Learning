// ©Arthurdw | GO-AO
using System;

namespace LearningOOP
{
    internal class ClAccessKey
    {
        private readonly string _accessToken;
        public ClAccessKey(string input)
        {
            try
            {
                _accessToken = GenerateCode(input);
            }
            catch (ArgumentOutOfRangeException)
            {
                _accessToken = "Code generation failed.";
            }
        }

        public string GetCode() => _accessToken;

        private string GenerateCode(string input) => 
            $"{DateTime.Now.Millisecond}{DateTime.Now.Year}{DateTime.Now.Month}{input.Substring(0, 1)}{input.Length}";
    }
}
