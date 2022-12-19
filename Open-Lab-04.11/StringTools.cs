using System;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
           char[] chars=str.ToCharArray();
           Array.Sort(chars);
           string result= new string(chars);
           return result;
        }
    }
}
