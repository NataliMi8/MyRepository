using System;
using System.Collections.Generic;
using System.Text;

namespace VigenèreDecoder
{
    class Decryption
    {
       
        public static string Decode(string _inputValue, string _keyGen)
        {
            char[] charValue = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                                             'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
                                             't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '1',
                                             '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            int _arrayElement = charValue.Length;

            _inputValue = _inputValue.ToLower();
            _keyGen = _keyGen.ToLower();

            string _result = "";

            int _keyGen_index = 0;

            foreach (char symbol in _inputValue)
            {
                int _sourceMessageCharacter = (Array.IndexOf(charValue, symbol) + _arrayElement - Array.IndexOf(charValue, _keyGen[_keyGen_index])) % _arrayElement;

                _result += charValue[_sourceMessageCharacter];

                _keyGen_index++;

                if ((_keyGen_index + 1) == _keyGen.Length)
                {
                    _keyGen_index = 0;
                }                   
            }
            return _result;
        }
    }
}
