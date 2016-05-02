using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// accept only alpha chars, and only once per alpha, until all letters A-Z are entered

// count the number of correct characters typed, and output number to console

// compare typed char to list of A-Z: if typed char matches this list and is not in 
// user's list of already typed chars add it to the user's list. 

// if a typed char does not match A-Z list output message that char is not a letter A-Z

// if typed char matches user's list output message saying char has been typed already

// Use one Class in addition to the program file.

// Use the String.Format method to craft your messages to users.

// Your class should include a constructor function, an "addChar" method, and a "listLength" method.

// I think this will be needed: 
// https://msdn.microsoft.com/en-us/library/system.windows.forms.keypresseventargs.keychar(v=vs.110).aspx

// Char.ToLower is a method for turning caps to lower, if not a char or already lower, no change

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
