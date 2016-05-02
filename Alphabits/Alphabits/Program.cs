using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabits
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ABCs = true;
            AlphabetSoup buildUserAlpha = new AlphabetSoup();
            

            while (ABCs)
            {
                // Prompt user to type the alphabet
                if (buildUserAlpha.listLength()==0)
                {
                    string output = String.Format("Type all 26 letters of the alphabet.");
                    Console.WriteLine(output);
                }
                
                // assign whatever is typed to a string called entry
                string entry = Console.ReadLine();

                // get the first char of whatever the user types and test if a letter using isChar method from AlphabetSoup
                char entryChar = entry[0];
                buildUserAlpha.isChar(entryChar);

                string counter = String.Format("You have entered {0} of 26 letters.",
                   buildUserAlpha.userAlphabet.Count);

                if (buildUserAlpha.listLength()==26)
                {
                    Console.Clear();
                    string congrats = String.Format("CONGRATULATIONS! You have finished the alphabet!");
                    Console.WriteLine(congrats);
                    Console.ReadLine();
                    ABCs = false;
                }
                else if (buildUserAlpha.listLength()>=1)
                {
                    Console.Clear();
                    counter += String.Format(" Keep going!");
                    Console.WriteLine(counter);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(counter);
                    continue;
                }
               
            }



            //var allUserInput = "";



            //AlphabetSoup alpha = new AlphabetSoup();

            //var alphaBET = alpha.WriteAlphabet();
            //Console.WriteLine(alphaBET);
            //Console.ReadLine();
        }
    }
}
