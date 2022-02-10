using System;
using System.Collections;

public class Program{



    public static void Main(string[]args)
    {
        string s = "Helloss";
        
        myDelegate obj = check;
        Console.WriteLine(obj(s));

        Predicate<string> pObj = check;
        Console.WriteLine(pObj(s));

        //Anonymous method
        Predicate<string> anonymousObj = delegate(string str){
            return str.Length>5;
        };
        Console.WriteLine(anonymousObj(s));

        //Lambda expression
        Predicate<string> lambdaObj = str=>{
            return str.Length>5;
        };
        Console.WriteLine(lambdaObj(s));

    }

    public delegate bool myDelegate(String s);
    public static bool check(String s)
    {
        return s.Length>5;
    }
}