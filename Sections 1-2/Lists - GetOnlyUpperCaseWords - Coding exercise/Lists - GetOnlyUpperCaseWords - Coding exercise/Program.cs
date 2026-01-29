/* Lists - GetOnlyUpperCaseWords

Implement the GetOnlyUpperCaseWords method, which given a collection of strings, returns a List with only those strings which contain only uppercase letters.

The result collection should not contain duplicates.


For example:

    for input List {"one", "TWO", "THREE", "four"} the result shall be {"TWO", "THREE"}

    for input List {"one", "TWO", "THREE", "four", "TWO"} the result shall be {"TWO", "THREE"} (the second "TWO" is ignored)

    for input List {"one", "TWO123", "THREE!&^", "four"} the result shall be an empty List because no word in this collection is built from only uppercase letters (digits and special characters are not letters at all).

Tips:

Strings are collections of characters. It means we can iterate a string with a foreach loop, and in each iteration, we have access to a specific character from this string.



To check if a character is an uppercase letter, we can use the char.IsUpper method:

Please notice that digits and special characters are not letters at all, so words containing them should not be considered uppercase words. Luckily, the char.IsUpper method covers that; it returns false for any non-letter characters. 
*/

using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public List<string> GetOnlyUpperCaseWords(List<string> words)
        {
            var wordsContainingOnlyUpperCaseLetters = new List<string>();
            foreach (var word in words)
            {
                if (wordsContainingOnlyUpperCaseLetters.Contains(word))
                {
                    continue;
                }
                bool isWordUpperCase = true;
                foreach (char character in word)
                {
                    if (!char.IsUpper(character))
                    {
                        isWordUpperCase = false;
                    }
                }
                if (isWordUpperCase)
                {
                    wordsContainingOnlyUpperCaseLetters.Add(word);
                }
            }
            return wordsContainingOnlyUpperCaseLetters;
        }
    }
}