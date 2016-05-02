using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace Alphabits
{
  public class AlphabetSoup
  {
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

    // This is a method, and look like a function from Javascript
    public string WriteAlphabet()
    {
      char[] theAlphabet = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < theAlphabet.Length; i++)
      {
        // Get character from array.
        char letter = theAlphabet[i];

        sb.Append("You typed: ");
        sb.Append(letter);
        return sb.ToString;
        // Display each letter.
        // Console.Write("Letter: ");
        // Console.WriteLine(letter);
      }
    }
  }
}
