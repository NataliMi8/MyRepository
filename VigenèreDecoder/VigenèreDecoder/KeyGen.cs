using System;
using System.Collections.Generic;
using System.Text;

namespace VigenèreDecoder
{
    class KeyGen
    {
        public static string GenerateKeyWord(int _lengthKey, int _initialKey)
        {
            char[] charValue = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                                             'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
                                             't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '1',
                                             '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            Random rand = new Random(_initialKey);

            string _result = "";

            for (int i = 0; i < _lengthKey; i++)
            {
                _result += charValue[rand.Next(0, charValue.Length)];              
            }
            return _result; 
        }
    }
}
