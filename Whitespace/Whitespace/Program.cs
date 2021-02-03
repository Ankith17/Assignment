using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


    class Program
    {
        static void Main(string[] args)
        {
        string s = "this    is book";
        string sen = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ' && s[i + 1] == ' ')
            {
                continue;
            }
            else
            {
                sen += s[i];
            }
        }
        Console.Write(sen);
        Console.ReadLine();
    }
    }

