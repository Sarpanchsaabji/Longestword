﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("The longest word is: ");
            a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for procession by an Analytical Engine");
        }

        public void MyFunctionA(string output)
        {
            string[] words = output.Split(' ');
            string b;
            int wordArrayLength = words.Length;
            int x = 0;
            foreach (var word in words)
            {
                string a;
                foreach (var word2 in words)
                {
                    if (word2.Length > word.Length)
                    {
                        a = word2;
                        Console.WriteLine("{0} : This is longest word now", a);
                    }
                }

            }
            Console.ReadLine();

        }
    }
}