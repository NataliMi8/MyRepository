using System;
using System.Collections.Generic;
using System.Text;


namespace VigenèreDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string _enteredWord;
            Console.WriteLine("Enter the word you want to encrypt ");
            _enteredWord = Console.ReadLine();
            
            string _KeyGen = KeyGen.GenerateKeyWord(7, 2);
            Console.WriteLine("Your key for encryption " + _KeyGen);

            string _EncryptedWord = Encrypt.Encode(_enteredWord, _KeyGen);

            Console.WriteLine("Your encrypted word " + _EncryptedWord);
            Console.WriteLine("Would you like to decipher your word? yes/no");
            string _answerOption = Console.ReadLine();

            switch (_answerOption)
            {
                case "yes":
                    Console.WriteLine(Decryption.Decode(_EncryptedWord, _KeyGen));
                    break;

                case "no":
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("You entered an action that was not intended! ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
