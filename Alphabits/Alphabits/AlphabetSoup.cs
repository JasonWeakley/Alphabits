using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabits
{
  public class AlphabetSoup
  {
        // Keep user's successfully input letters as a list of characters
        public List<char> userAlphabet = new List<char>();

        public void isChar(char userEntry)
        {
            char lowerCase = char.ToLower(userEntry);
            if (Char.IsLetter(lowerCase))
            {
                isInList(lowerCase);
            }
           
            else
            {
                Console.Clear();
                Console.WriteLine("That character is not in the alphabet. Please try again.");
                Console.ReadLine();
            }
        }

        // Check to see if entry was already entered
        public void isInList(char charToCompare)
        {
            if (userAlphabet.Contains(charToCompare))
            {
                Console.Clear();
                Console.WriteLine("That letter has already been entered. Press enter to continue.");
                Console.ReadLine();
            }
            else
            {
                addChar(charToCompare);
            }
        }

        // Have an addChar method
        public void addChar(char izaLetter)
        {
            userAlphabet.Add(izaLetter);
        }

        // Have a listLength method
        public int listLength()
        {
            return userAlphabet.Count;
        }

  }
}
