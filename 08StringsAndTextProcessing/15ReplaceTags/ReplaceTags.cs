﻿using System.IO;
using System;
using System.Text.RegularExpressions;
//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a>with corresponding tags [URL=…]…/URL]. 
//Sample HTML fragment:
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>68
class Program
{
    static void Main()
    {
        string htmlDoc = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        Console.WriteLine(htmlDoc);
        Console.WriteLine();
        string result = Regex.Replace(htmlDoc, "<a href=\"(?<address>.*?)\">(?<text>.*?)</a>", @"[URL=$1]\$2[/URL]");
        Console.WriteLine(result);
    }
}