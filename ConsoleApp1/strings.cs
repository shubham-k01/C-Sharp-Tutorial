namespace ConsoleApp1;

public class strings
{
    // static string[] a = ["batman","iron_man","spider_man"];
    static string[] a = { "batman", "iron_man", "spider_man" };

    // string ab = new string("String");
    // this can also be wriiten as
    static string ab = new("String");


    List<string> b = ["","abc","cdef"];

    // Can also be instantiated as
    
    // List<string> b = new(){
    //     "","abc","cdef"
    // };

    // List<string> b = new List<string>{
    //     "","abc","cdef"
    // };

    static void Main(){
        System.Console.WriteLine(ab);
        foreach (var item in a)
        {
            System.Console.WriteLine(item);
        }

    }


}
