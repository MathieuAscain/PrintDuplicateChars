using System;
using System.Collections.Generic;

namespace PrintDuplicateChars
{
    class Program
    {

        static string RemovePunctuation(string message)
        {
            message = message.ToLower();

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] < 'a' || message[i] > 'z')
                {
                    message = message.Replace(message[i].ToString(),"");
                }
            }

            return message;
        }

        static void Main(string[] args)
        {

            string message = "A";

            do
            {
                Console.Write("Enter a sentence ");
                message = Console.ReadLine();
            } while (message == "");


            message = RemovePunctuation(message);

            var letters = new Dictionary<char, int>() { {message[0], 1} };

            for(int i = 1; i < message.Length; i++)
            {
                    if(letters.ContainsKey(message[i]))
                {
                    letters[message[i]]++;
                }
                else
                {
                    letters.Add(message[i], 1);
                }
            }

            Boolean duplicate = false;

            foreach (KeyValuePair<char, int> kvp in letters)
            {
                if(kvp.Value > 1)
                {
                    Console.WriteLine("{0} is a duplicate character", kvp.Key);
                    duplicate = true;
                }
                
            }

            if (!duplicate)
            {
                Console.WriteLine("No duplicates");
            }
        }
    }
}
