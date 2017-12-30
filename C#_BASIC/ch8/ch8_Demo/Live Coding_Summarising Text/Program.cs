using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Coding_Summarising_Text
{
class Program
{
    static void Main(string[] args)
    {
        var sentence = "This is giong to be a really really really really reallly long text";
        var summary = StringUtility.SummerizeText(sentence,25);
        Console.WriteLine(summary);
    }
}
}
