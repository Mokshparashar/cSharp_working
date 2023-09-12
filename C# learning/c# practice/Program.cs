
using System;


namespace myStringMethods
{
    class stringMethod
    {
        static void Main(string[] args)
        {
            string myString = "     ";

            int lengthString =  myString.Length;
            Console.WriteLine(lengthString);

            int index = myString.IndexOf('l');
            Console.WriteLine(index);

            string subString = myString.Substring(0);
            Console.WriteLine(subString);
        }
    }
}