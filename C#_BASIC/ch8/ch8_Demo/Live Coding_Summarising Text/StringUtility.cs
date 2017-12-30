﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Live_Coding_Summarising_Text
{
    class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }
            var words = text.Split(' ');
            Console.WriteLine(words);
            var totalCharacters = 0;
            var summaryWords = new List<string>();
            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;

                if (totalCharacters > maxLength)
                {
                    break;
                }
            }
            return String.Join(" ", summaryWords) + "...";
        }
    }
}