using System;
using System.Collections;

public class Program{

    public static void Main(string[]args)
    {
        basicDelegate basicCall = basic;
        basicCall += basic2;
        basicCall();

        addDelegate sumFunc = new addDelegate(addNum);
        sumFunc +=addNum2;
        Console.WriteLine("Sum of numbers: {0}",sumFunc(4,5));

        //Lambda delegateObj
        basicDelegate d = ()=>{Console.WriteLine("Lambda");};
        d+=()=>{Console.WriteLine("Lambda 2");};
        d();

        //Anonymous delegateObj
        basicDelegate ano = delegate(){
            Console.WriteLine("Anonymous");
        };
        ano+=delegate(){
            Console.WriteLine("Anonymous 2");
        };
        ano();


    }

    public delegate void basicDelegate();
    static void basic()
    {
        Console.WriteLine("This is a basic example of delegate");
    }

    static void basic2()
    {
        Console.WriteLine("This is a basic 2 example ");
    }

    static int addNum(int a,int b){return a+b;}
    static int addNum2(int a,int b){return a-b;}
    public delegate int addDelegate(int a,int b);
}