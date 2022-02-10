using System;
using System.Collections;

public class Program{

    public static void Main(string[]args)
    {
        Func<int,int,int> sumObj = sum;
        Console.WriteLine(sumObj(4,5));

        //With anonymous method
        Func<int,int,int> area = delegate(int l,int b){
            return l*b;
        };
        Console.WriteLine("Area of rectangle : {0}",area(4,5));

        //With Lambda method
        Func<int,int,int> perimeter = (int l,int b)=>{return 2*(l+b);};
        Console.WriteLine("Perimeter of rectangle : {0}",perimeter(4,5));

    }

    static int sum(int a,int b)
    {
        return a+b;
    }
}