using System;

namespace ConsoleApp1;


public class try_parse
{
    static string a = "12";
    bool b = int.TryParse(a,out int c);

    public static void Main(){
        Console.WriteLine(a);
    }
}
