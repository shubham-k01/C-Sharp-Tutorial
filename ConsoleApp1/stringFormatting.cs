using System;

namespace ConsoleApp1;

public class stringFormatting
{
    static string a = "Hello there";
    static string? name;

    public void Main(){
        Console.WriteLine("Enter your name: ");
        name = Console.ReadLine();

        System.Console.WriteLine(a + name);
        System.Console.WriteLine("Hello there " + name);
        System.Console.WriteLine("{0} {1}",a,name);
        System.Console.WriteLine($"{a} {name}");

    }
}
