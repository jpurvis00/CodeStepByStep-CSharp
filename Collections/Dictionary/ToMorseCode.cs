/* Write a method named ToMorseCode that converts strings into their Morse code equivalents. Morse code is a dictionaryping from each character from A-Z to a sequence of dots and dashes. For example, the string "SOS" could be represented in Morse code as "... --- ...".

Your method accepts two parameters: a SortedDictionary from char to string, and a string of text to convert. Assume that the provided client code builds a dictionary from individual text characters to their Morse code equivalents. For example, the key 'A' maps to ".-" . Your method accepts such a dictionary, and a string to be converted, and should print out the Morse code equivalent of the given string to the console.

For example, if the letter to Morse code dictionary is stored in a variable called mapping, the call of ToMorseCode(mapping, "SOS TITANIC"); should print the following console output:

... --- ... - .. - .- -. .. -.-.
Note that the string might contain some characters that are not uppercase A-Z letters (like spaces); just skip those characters. You may assume that the dictionaryping passed contains a dictionaryping for every letter from A-Z in uppercase. Do not modify the letter dictionary that is passed in.
*/
namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class ToMorseCode
    {
        public static void RunToMorseCode()
        {
            Dictionary<char, string> mapping = new()
            {
                { 'A', ".-" }, { 'B', "-..." }, { 'C', "-.-." }, { 'D', "-.." }, { 'E', "." }, { 'F', "..-." },
                    { 'G', "--. " }, { 'H', "...." }, { 'I', ".." }, { 'J', ".---" }, { 'K', "-.-" }, { 'L', ".-.." },
                    { 'M', "--" }, { 'N', "-." }, { 'O', "---" }, { 'P', ".--." }, { 'Q', "--.-" }, { 'R', ".-." },
                    { 'S', "..." }, { 'T', "-" }, { 'U', "..-" }, { 'V', "...-" }, { 'W', ".--" }, { 'X', "-..-" },
                    { 'Y', "-.--" }, { 'Z', "--.." }, { ' ', "-.-.-.-" }, { ',', "--..--" }, { ':', "---..." }, { ';', "-.-.-." },
                    { '.', ".-.-.-" }, { '"', ".-..-." }, { '(', "-----." }, { ')', ".-----" }, { '\'', "-.--.-" }, { '1', ".----" },
                    { '2', "..---" }, { '3', "...-- " }, { '4', "....-" }, { '5', "....." }, { '6', "-...." }, { '7', "--..." },
                    { '8', "---.." }, { '9', "----." }, { '0', "-----" }
            };

            string convertText = "SOS TITANIC";

            foreach (char character in convertText)
            {
                if (mapping.ContainsKey(character))
                {
                    Console.Write(mapping[character] + " ");
                }
            }
        }
    }
}
