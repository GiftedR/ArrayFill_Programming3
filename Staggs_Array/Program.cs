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
            Random randomNum = new Random(DateTime.Now.Millisecond);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (getIndex(randChars, '\0') != -1)
            {
                randChars[getIndex(randChars, '\0')] = addLetter();
            }
            char addLetter()
            {
                char testChar = (char)(randomNum.Next(0, 26) + 65 + (32 * randomNum.Next(0, 2)));
                if (getIndex(randChars, testChar) == -1)
                {
                    return testChar;
                }
                else
                {
                    return '\0';
                }
            }
            int getIndex(char[] array, char value)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == value)
                    {
                        return i;
                    }
                }
                return -1;
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed.ToString());
        }
    }
}