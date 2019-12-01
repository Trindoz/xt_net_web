using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyString
    {
        public MyString() { }
        public MyString(string s)
        {
            char[] ch = ToCharArray(s);
        }
        public MyString(string s,string s1)
        {
            bool result = Equal(s, s1);
        }
        public MyString(char[] ch)
        {
            string s = ToString(ch);
        }
        public MyString(string s, char c)
        {
            int i = Search(s, c);
        }
        public char[] ToCharArray(string s)
        {
            char[] ch = new char[s.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = s[i];
            }
            return ch;
        }
        public bool Equal(string s,string s1)
        {
            if (s.Length != s1.Length)
                return false;
            else
            {
                for (int i = 0; i < s.Length; i++)
                    if (s[i] != s1[i])
                        return false;
            }return true;          
        }
        public string ToString(char[] ch)
        {
            string s = "";
            for (int i = 0; i < ch.Length; i++)
            {
                s += ch[i];
            }
            return s;
        }
        public int Search(string s,char c)
        {
            for(int i=0; i < s.Length; i++)
            {
                if (c == s[i])
                    return i;
            }return -1;
        }
        public string Concat(string s, string s1)
        {
            return s + s1;
        }
      
       
    }
}
