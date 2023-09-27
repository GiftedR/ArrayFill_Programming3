using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Xml;

namespace Staggs_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] randChars = new char[50];//output array
            int storedNumbers = 0;
            Random randomNum = new Random(DateTime.Now.Millisecond);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (storedNumbers < 50)
            {
                char tempLetter = addLetter();
                if (tempLetter != '[')
                {
                    randChars[storedNumbers] = tempLetter;
                    storedNumbers++;
                }
            }
            char addLetter()
            {
                char testChar = (char)(randomNum.Next(0, 26) + 65 + (32 * randomNum.Next(0, 2)));
                if (valExists(randChars, testChar) == false)
                {
                    return testChar;
                }
                else
                {
                    return '[';
                }
            }
            bool valExists(char[] array, char value)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == value)
                    {
                        return true;
                    }
                }
                return false;
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed.ToString());
            //Only to write the output
            //writeArray();
            void writeArray()
            {
                for (int i = 0; i < randChars.Length; i++)
                {
                    Console.Write(randChars[i]);
                }
                Console.Write('\n');
            }
        }
    }
}