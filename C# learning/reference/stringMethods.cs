using System;

namespace myReferenceNamespace
{
    class myReferenceClass
    {
        static void Main(string[] args)
        {
            string myString = "   Hello, World!   ";

            // Length: Gets the length (number of characters) of the string
            int length = myString.Length; // Returns 18

            // Substring: Extracts a substring starting from the specified index
            string substring1 = myString.Substring(3); // Returns "Hello, World!   "

            // Substring with length: Extracts a substring starting from the specified index with the given length
            string substring2 = myString.Substring(3, 5); // Returns "Hello"

            // ToLower: Converts the string to lowercase
            string lowerCase = myString.ToLower(); // Returns "   hello, world!   "


            // ToUpper: Converts the string to uppercase
            string upperCase = myString.ToUpper(); // Returns "   HELLO, WORLD!   "

            // Trim: Removes leading and trailing white spaces
            string trimmed = myString.Trim(); // Returns "Hello, World!"

            // Replace: Replaces all occurrences of a specified string with another string
            string replaced = myString.Replace("World", "Universe"); // Returns "   Hello, Universe!   "

            // Contains: Checks if the string contains a specific substring
            bool contains = myString.Contains("Hello"); // Returns true

            // StartsWith: Checks if the string starts with a specific substring
            bool startsWith = myString.StartsWith("   "); // Returns true

            // EndsWith: Checks if the string ends with a specific substring
            bool endsWith = myString.EndsWith("   "); // Returns true

            // IndexOf: Finds the index of the first occurrence of a specified substring
            int indexOf = myString.IndexOf("World"); // Returns 9

            // Split: Splits the string into an array of substrings based on a separator
            string fruits = "apple,banana,cherry";
            string[] fruitArray = fruits.Split(','); // Returns an array: ["apple", "banana", "cherry"]

            // Join: Combines an array of strings into a single string, separated by a specified separator
            string[] colors = { "red", "green", "blue" };
            string colorString = string.Join(", ", colors); // Returns "red, green, blue"

        }
    }
}

