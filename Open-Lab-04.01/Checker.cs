using System;

namespace Open_Lab_04._01
{
    public class Checker
    {
        public bool DoubleLetters(string str)
        {
            if (string.IsNullOrEmpty(str)) return false;

            bool containsDupes = false;
            for (int i = 1; i < str.Length && !containsDupes; ++i)
            {
                containsDupes = str[i] == str[i - 1];
            }

            return containsDupes;
        }
    }
}
