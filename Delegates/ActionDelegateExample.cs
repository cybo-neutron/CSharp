using System;
using System.Collections;

public class Program{

    public static void Main(string[]args)
    {
        Action<string> obj = fun;
        obj("hello");

        Action<int,int> obj2 = sum;
        obj2(4,5);

        //Action with anonymous method
        Action<int,int> obj3 =delegate(int a,int b)
        {
            Console.WriteLine("Area of rectangle : {0}",(a*b));
        };
        obj3(4,5);

        //Action with lambda method
        Action<int,int> obj4 = (int a,int b)=>{
            Console.Write("Perimeter of rectangle : {0}",(2*(a+b)));
        };
        obj4(4,5);

    }

    static void fun(string s)
    {
        Console.WriteLine("Input : " + s);
    }

    static void sum(int a,int b)
    {
        Console.WriteLine("Sum of the numbers : {0}",(a+b));
    }


}