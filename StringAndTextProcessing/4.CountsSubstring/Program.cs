//Write a program that finds how many times a substring 
//is contained in a given text (perform case insensitive search).

using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        //string text = "in In";
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string substring = "in";
        Regex r = new Regex(substring, RegexOptions.IgnoreCase);
        int counter = r.Matches(text).Count;
        Console.WriteLine("The substring \"{0}\" is contained {1} times in the text.",substring,counter);
    }
}

