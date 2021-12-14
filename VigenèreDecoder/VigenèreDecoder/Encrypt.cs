using System;
using System.Collections.Generic;
using System.Text;

namespace VigenèreDecoder
{
    class Encrypt
    {
        public static string Encode(string _inputValue, string _keyGen)
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
                int _codedMessageSymbol = (Array.IndexOf(charValue, symbol) + Array.IndexOf(charValue, _keyGen[_keyGen_index])) % _arrayElement;

                _result += charValue[_codedMessageSymbol];

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
